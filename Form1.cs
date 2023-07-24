using System;
using System.Diagnostics;
using System.IO;
using static TicTacToe.Form1;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int directionX = 1;
        private int directionY = 1;
        Player currentPlayer;
        Dictionary<Button, int> buttonScores;
        Dictionary<string, int> textScores;
        private Player[,] board = new Player[3, 3];
        float tempTime;
        Button[] winningButtons = new Button[3];
        private int red = 0, green = 0, blue = 0;
        private int deltaRed = -1, deltaGreen = 1, deltaBlue = 1;
        public Form1()
        {
            InitializeComponent();
            red = new Random().Next(256);
            green = new Random().Next(256);
            blue = new Random().Next(256);
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            timer.Start();
            buttonScores = new Dictionary<Button, int>();
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag != "play")
                {
                    buttonScores.Add(button, 0);
                    button.Click += buttonClick;
                }
            }
            UpdateDictionary(0, 0);
            board = new Player[3, 3] { { Player.None, Player.None, Player.None }, { Player.None, Player.None, Player.None }, { Player.None, Player.None, Player.None } };
            textScores = new Dictionary<string, int>
            {
                { "AI", 0 },
                {"Human", 0 }
            };

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            // Change the button's color every 5 ticks
            red += deltaRed;
            green += deltaGreen;
            blue += deltaBlue;

            if (red > 255 || red < 0)
            {
                deltaRed *= -1;
                red += deltaRed * 2;
            }
            if (green > 255 || green < 0)
            {
                deltaGreen *= -1;
                green += deltaGreen * 2;
            }
            if (blue > 255 || blue < 0)
            {
                deltaBlue *= -1;
                blue += deltaBlue * 2;
            }
            button10.BackColor = Color.FromArgb(red, green, blue);

        }
        public enum Player
        {
            X,
            O,
            None
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Update();
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.LightGreen;

            // Update the board
            int row = int.Parse(button.Tag.ToString()) / 3;
            int col = int.Parse(button.Tag.ToString()) % 3;
            board[row, col] = currentPlayer;
            Update();
            if (CheckWin(Player.X))
            {
                label1.Visible = true;
                label1.Text = "player X win";
                textScores["Human"]++;
                WON();
                return;
            }
            else if (IsBoardFull(board))
            {
                label1.Visible = true;
                label1.Text = "no one win";
                return;
            }
            AITIMER.Start();

        }
        private bool FirstAfterHuman()
        {
            int temp = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == Player.X)
                    {
                        temp++;
                    }
                }
            }
            if (temp == 1)
            {
                return true;
            }
            return false;
        }
        private void playAI(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            AITIMER.Stop();
            stopwatch.Start();
            if (FirstAfterHuman())
            {
                List<(int, int)> availablePositions = new List<(int, int)>();
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == Player.X)
                        {
                            for (int k = 0; k < board.GetLength(0); k++)
                            {
                                if (board[i, k] == Player.None)
                                {
                                    availablePositions.Add((i, k));
                                }
                                if (board[k, j] == Player.None)
                                {
                                    availablePositions.Add((k, j));
                                }
                            }
                        }
                    }
                }
                if (availablePositions.Count > 0)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(availablePositions.Count);
                    (int row1, int col1) = availablePositions[randomIndex];
                    Button buttonToPlay1 = GetButtonAtPosition(row1, col1);
                    buttonToPlay1.Text = Player.O.ToString();
                    buttonToPlay1.Enabled = false;
                    buttonToPlay1.BackColor = Color.LightGoldenrodYellow;
                    currentPlayer = Player.O;
                    board[row1, col1] = currentPlayer;
                }
            }
            else
            {
                Button buttonToPlay = GetBestMove();
                buttonToPlay.Text = Player.O.ToString();
                buttonToPlay.Enabled = false;
                buttonToPlay.BackColor = Color.LightGoldenrodYellow;
                currentPlayer = Player.O;
                int row = int.Parse(buttonToPlay.Tag.ToString()) / 3;
                int col = int.Parse(buttonToPlay.Tag.ToString()) % 3;
                board[row, col] = currentPlayer;
            }
            Update();
            stopwatch.Stop();
            dataGridViewTime.Rows.Add("AI", stopwatch.ElapsedMilliseconds + "ms");
            if (CheckWin(Player.O))
            {
                label1.Visible = true;
                label1.Text = "player O win";
                textScores["AI"]++;
                WON();
            }
        }

        private Button GetButtonAtPosition(int row, int col)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Tag != "play" && button.Tag == (row * 3 + col).ToString())
                {
                    return button;
                }
            }
            return null;
        }


        private Button GetBestMove()
        {
            int bestScore = int.MinValue;
            Button bestMove = null;

            foreach (Button button in buttonScores.Keys)
            {
                if (button.Enabled)
                {
                    buttonScores[button] = 0;
                    // Simulate AI move
                    board[int.Parse(button.Tag.ToString()) / 3, int.Parse(button.Tag.ToString()) % 3] = Player.O;
                    int aiScore = MiniMax(Player.X, 0, int.MinValue, int.MaxValue, false, 4);
                    board[int.Parse(button.Tag.ToString()) / 3, int.Parse(button.Tag.ToString()) % 3] = Player.None;
                    // Simulate human move
                    board[int.Parse(button.Tag.ToString()) / 3, int.Parse(button.Tag.ToString()) % 3] = Player.X;
                    int humanScore = MiniMax(Player.O, 0, int.MinValue, int.MaxValue, true, 4);
                    board[int.Parse(button.Tag.ToString()) / 3, int.Parse(button.Tag.ToString()) % 3] = Player.None;
                    // Calculate final score
                    int score = aiScore - humanScore;
                    buttonScores[button] = score;
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = button;
                    }
                    UpdateDictionary(aiScore, humanScore);
                }
            }
            return bestMove;
        }

        private bool CheckDraw()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "play" && ((Button)x).Text == "?")
                {
                    return false;
                }
            }
            return true;
        }

        private Player PlayerSwitch(Player player)
        {
            return (player == Player.X ? Player.O : Player.X);
        }

        private bool CheckWin(Player player)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == (player) && board[i, 1] == (player) && board[i, 2] == (player))
                {
                    return true;
                }
            }
            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == (player) && board[1, j] == (player) && board[2, j] == (player))
                {
                    return true;
                }
            }
            // Check diagonals
            if (board[0, 0] == (player) && board[1, 1] == (player) && board[2, 2] == (player))
            {
                return true;
            }
            if (board[0, 2] == (player) && board[1, 1] == (player) && board[2, 0] == (player))
            {
                return true;
            }
            return false;
        }

        private bool IsBoardFull(Player[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == Player.None)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private int MiniMax(Player player, int depth, int alpha, int beta, bool maximizingPlayer, int maxDepth)
        {
            if (depth == maxDepth || CheckWin(Player.X) || CheckWin(Player.O) || IsBoardFull(board))
            {
                if (CheckWin(Player.X)) return -10;
                if (CheckWin(Player.O)) return 10;
                if (IsBoardFull(board)) return 0;
            }

            if (maximizingPlayer)
            {
                int maxEval = int.MinValue;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == Player.None)
                        {
                            board[i, j] = (player);

                            bool foundPotentialWin = false;
                            for (int k = 0; k < 3; k++)
                            {
                                if (board[i, k] == player && board[i, (k + 1) % 3] == player && board[i, (k + 2) % 3] == Player.None)
                                {
                                    foundPotentialWin = true;
                                    break;
                                }
                                if (board[k, j] == player && board[(k + 1) % 3, j] == player && board[(k + 2) % 3, j] == Player.None)
                                {
                                    foundPotentialWin = true;
                                    break;
                                }
                            }

                            if (board[1, 1] == player && ((board[0, 0] == player && board[2, 2] == Player.None) || (board[0, 2] == player && board[2, 0] == Player.None)))
                            {
                                foundPotentialWin = true;
                            }

                            int eval;
                            if (foundPotentialWin)
                            {
                                // If a potential win is found, assign a high negative score
                                eval = 20;
                            }
                            else
                            {
                                eval = MiniMax(player, depth + 1, alpha, beta, false, maxDepth);
                            }
                            //int eval = MiniMax(player, depth + 1, alpha, beta, false, maxDepth);
                            board[i, j] = Player.None;
                            maxEval = Math.Max(maxEval, eval);
                            alpha = Math.Max(alpha, eval);
                            if (beta <= alpha)
                            {
                                break;
                            }
                        }
                    }
                }
                return maxEval;
            }
            else
            {
                int minEval = int.MaxValue;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == Player.None)
                        {
                            board[i, j] = GetOpponent(player);

                            // Check for potential 2-in-a-row positions for the opponent
                            bool foundPotentialWin = false;
                            for (int k = 0; k < 3; k++)
                            {
                                if (board[i, k] == GetOpponent(player) && board[i, (k + 1) % 3] == GetOpponent(player) && board[i, (k + 2) % 3] == Player.None)
                                {
                                    foundPotentialWin = true;
                                    break;
                                }

                                if (board[k, j] == GetOpponent(player) && board[(k + 1) % 3, j] == GetOpponent(player) && board[(k + 2) % 3, j] == Player.None)
                                {
                                    foundPotentialWin = true;
                                    break;
                                }
                            }

                            if (board[1, 1] == GetOpponent(player) && ((board[0, 0] == GetOpponent(player) && board[2, 2] == Player.None) || (board[0, 2] == GetOpponent(player) && board[2, 0] == Player.None)))
                            {
                                foundPotentialWin = true;
                            }

                            int eval;
                            if (foundPotentialWin)
                            {
                                // If a potential win is found, assign a high negative score
                                eval = 10;
                            }
                            else
                            {
                                eval = MiniMax(player, depth + 1, alpha, beta, true, maxDepth);
                            }

                            board[i, j] = Player.None;
                            minEval = Math.Min(minEval, eval);
                            beta = Math.Min(beta, eval);
                            if (beta <= alpha)
                            {
                                break;
                            }
                        }
                    }
                }
                return minEval;
            }
        }

        private Player GetOpponent(Player player)
        {
            if (player == Player.X)
            {
                return Player.O;
            }
            else
            {
                return Player.X;
            }
        }

        private void resetGame(object sender, EventArgs e)
        {
            datagridViewDictionary.Rows.Clear();
            dataGridViewBoard.Rows.Clear();
            dataGridViewTime.Rows.Clear();
            currentPlayer = Player.X;
            board = new Player[3, 3] { { Player.None, Player.None, Player.None }, { Player.None, Player.None, Player.None }, { Player.None, Player.None, Player.None } };
            Random random = new Random();
            int randomNum = random.Next(2); // generates a random number between 0 and 1
            if (randomNum == 0)
            {
                label1.Text = "Human Player start!";
            }
            else
            {
                label1.Text = "AI start!";
                AITIMER.Start();
            }
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag != "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "?";
                    ((Button)x).BackColor = Color.AliceBlue;
                }
            }
        }

        private void WON()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag != "play")
                {
                    ((Button)x).Enabled = false;
                    buttonScores[(Button)x] = 0;
                }
            }
            UpdateScore();
        }

        private void Update()
        {
            this.dataGridViewBoard.Rows.Clear();
            this.dataGridViewBoard.Rows.Add(board[0, 0].ToString(), board[0, 1].ToString(), board[0, 2].ToString());
            this.dataGridViewBoard.Rows.Add(board[1, 0], board[1, 1], board[1, 2]);
            this.dataGridViewBoard.Rows.Add(board[2, 0], board[2, 1], board[2, 2]);
        }


        private void UpdateDictionary(int ai, int hum)
        {
            this.datagridViewDictionary.Rows.Clear();
            foreach (KeyValuePair<Button, int> pair in buttonScores)
            {
                datagridViewDictionary.Rows.Add(pair.Key.Tag, pair.Value, "AI(" + ai + ")+HUM(" + hum + ")");
            }
        }

        public void UpdateScore()
        {
            dataGridViewPoints.Rows.Clear();
            dataGridViewPoints.Rows.Add(textScores["AI"], textScores["Human"]);
        }

    }



    //public partial class Form1 : Form
    //{
    //    Player currentPlayer;
    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }
    //    public enum Player
    //    {
    //        X,
    //        O
    //    }
    //    private void buttonClick(object sender, EventArgs e)
    //    {
    //        var button = (Button)sender;
    //        currentPlayer = Player.X;
    //        button.Text = currentPlayer.ToString();
    //        button.Enabled = false;
    //        button.BackColor = System.Drawing.Color.LightGreen;
    //        Check();
    //        AITIMER.Start();
    //    }

    //    private void playAI(object sender, EventArgs e)
    //    {
    //        foreach (Control x in this.Controls)
    //        {
    //            if (x is Button && x.Text == "?" && x.Enabled)
    //            {
    //                x.Enabled = false;
    //                currentPlayer = Player.O;
    //                x.Text = currentPlayer.ToString();
    //                x.BackColor = System.Drawing.Color.LightGoldenrodYellow;
    //                AITIMER.Stop();
    //                Check();
    //                break;
    //            }
    //            else
    //            {
    //                AITIMER.Stop();
    //            }
    //        }
    //    }

    //    private void Check()
    //    {
    //        if (
    //        button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
    //        button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
    //        button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
    //        button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
    //        button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
    //        button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
    //        button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
    //        button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
    //            )
    //        {
    //            WON();
    //            label1.Text = "X Wins";
    //        }
    //        else if (
    //        button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
    //        button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
    //        button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
    //        button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
    //        button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
    //        button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
    //        button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
    //        button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
    //            )
    //        {
    //            WON();
    //            label1.Text = "O Wins";
    //        }
    //    }

    //    private void WON()
    //    {
    //        foreach (Control x in this.Controls)
    //        {
    //            if (x is Button && x.Tag == "play")
    //            {
    //                ((Button)x).Enabled = false;
    //                ((Button)x).BackColor = default(Color);
    //            }
    //        }
    //    }

    //    private void resetGame(object sender, EventArgs e)
    //    {
    //        label1.Text = "??";
    //        foreach (Control x in this.Controls)
    //        {
    //            if (x is Button && x.Tag == "play")
    //            {
    //                ((Button)x).Enabled = true;
    //                ((Button)x).Text = "?";
    //                ((Button)x).BackColor = default(Color);
    //            }
    //        }
    //    }
    //}
}