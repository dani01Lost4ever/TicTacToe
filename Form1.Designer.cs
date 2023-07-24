namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            AITIMER = new System.Windows.Forms.Timer(components);
            button10 = new Button();
            dataGridViewBoard = new DataGridView();
            Colonna0 = new DataGridViewTextBoxColumn();
            Colonna1 = new DataGridViewTextBoxColumn();
            Colonna2 = new DataGridViewTextBoxColumn();
            datagridViewDictionary = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dataGridViewPoints = new DataGridView();
            AI = new DataGridViewTextBoxColumn();
            Human = new DataGridViewTextBoxColumn();
            label3 = new Label();
            dataGridViewTime = new DataGridView();
            Giocatore = new DataGridViewTextBoxColumn();
            Tempo = new DataGridViewTextBoxColumn();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridViewDictionary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTime).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(785, 115);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(130, 130);
            button1.TabIndex = 0;
            button1.Tag = "0";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClick;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(922, 115);
            button2.Margin = new Padding(5, 3, 5, 3);
            button2.Name = "button2";
            button2.Size = new Size(130, 130);
            button2.TabIndex = 1;
            button2.Tag = "1";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClick;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1059, 115);
            button3.Margin = new Padding(5, 3, 5, 3);
            button3.Name = "button3";
            button3.Size = new Size(130, 130);
            button3.TabIndex = 2;
            button3.Tag = "2";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonClick;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(785, 251);
            button4.Margin = new Padding(5, 3, 5, 3);
            button4.Name = "button4";
            button4.Size = new Size(130, 130);
            button4.TabIndex = 3;
            button4.Tag = "3";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(922, 251);
            button5.Margin = new Padding(5, 3, 5, 3);
            button5.Name = "button5";
            button5.Size = new Size(130, 130);
            button5.TabIndex = 4;
            button5.Tag = "4";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(1059, 251);
            button6.Margin = new Padding(5, 3, 5, 3);
            button6.Name = "button6";
            button6.Size = new Size(130, 130);
            button6.TabIndex = 5;
            button6.Tag = "5";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(785, 387);
            button7.Margin = new Padding(5, 3, 5, 3);
            button7.Name = "button7";
            button7.Size = new Size(130, 130);
            button7.TabIndex = 6;
            button7.Tag = "6";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(922, 387);
            button8.Margin = new Padding(5, 3, 5, 3);
            button8.Name = "button8";
            button8.Size = new Size(130, 130);
            button8.TabIndex = 7;
            button8.Tag = "7";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(1059, 387);
            button9.Margin = new Padding(5, 3, 5, 3);
            button9.Name = "button9";
            button9.Size = new Size(130, 130);
            button9.TabIndex = 8;
            button9.Tag = "8";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(922, 535);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 42);
            label1.TabIndex = 10;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // AITIMER
            // 
            AITIMER.Interval = 50;
            AITIMER.Tick += playAI;
            // 
            // button10
            // 
            button10.BackColor = Color.MediumSlateBlue;
            button10.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlText;
            button10.Location = new Point(785, 594);
            button10.Margin = new Padding(5, 3, 5, 3);
            button10.Name = "button10";
            button10.Size = new Size(405, 120);
            button10.TabIndex = 11;
            button10.Tag = "play";
            button10.Text = "PLAY";
            button10.UseVisualStyleBackColor = false;
            button10.Click += resetGame;
            // 
            // dataGridViewBoard
            // 
            dataGridViewBoard.AllowUserToDeleteRows = false;
            dataGridViewBoard.AllowUserToOrderColumns = true;
            dataGridViewBoard.AllowUserToResizeColumns = false;
            dataGridViewBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBoard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBoard.Columns.AddRange(new DataGridViewColumn[] { Colonna0, Colonna1, Colonna2 });
            dataGridViewBoard.Location = new Point(1391, 115);
            dataGridViewBoard.Margin = new Padding(5, 3, 5, 3);
            dataGridViewBoard.Name = "dataGridViewBoard";
            dataGridViewBoard.ReadOnly = true;
            dataGridViewBoard.RowHeadersWidth = 51;
            dataGridViewBoard.RowTemplate.Height = 29;
            dataGridViewBoard.ScrollBars = ScrollBars.None;
            dataGridViewBoard.Size = new Size(398, 198);
            dataGridViewBoard.TabIndex = 12;
            // 
            // Colonna0
            // 
            Colonna0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Colonna0.HeaderText = "0";
            Colonna0.MinimumWidth = 6;
            Colonna0.Name = "Colonna0";
            Colonna0.ReadOnly = true;
            // 
            // Colonna1
            // 
            Colonna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Colonna1.HeaderText = "1";
            Colonna1.MinimumWidth = 6;
            Colonna1.Name = "Colonna1";
            Colonna1.ReadOnly = true;
            // 
            // Colonna2
            // 
            Colonna2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Colonna2.HeaderText = "2";
            Colonna2.MinimumWidth = 6;
            Colonna2.Name = "Colonna2";
            Colonna2.ReadOnly = true;
            // 
            // datagridViewDictionary
            // 
            datagridViewDictionary.AllowUserToDeleteRows = false;
            datagridViewDictionary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridViewDictionary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridViewDictionary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridViewDictionary.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            datagridViewDictionary.Location = new Point(1391, 320);
            datagridViewDictionary.Margin = new Padding(5, 3, 5, 3);
            datagridViewDictionary.Name = "datagridViewDictionary";
            datagridViewDictionary.RowHeadersWidth = 51;
            datagridViewDictionary.RowTemplate.Height = 29;
            datagridViewDictionary.ScrollBars = ScrollBars.None;
            datagridViewDictionary.Size = new Size(398, 394);
            datagridViewDictionary.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.HeaderText = "Button";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Score";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 90;
            // 
            // Column3
            // 
            Column3.HeaderText = "Details Score";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 154;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(1488, 72);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 40);
            label2.TabIndex = 14;
            label2.Text = "Analytics";
            // 
            // dataGridViewPoints
            // 
            dataGridViewPoints.AllowUserToDeleteRows = false;
            dataGridViewPoints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPoints.Columns.AddRange(new DataGridViewColumn[] { AI, Human });
            dataGridViewPoints.Location = new Point(225, 115);
            dataGridViewPoints.Margin = new Padding(5, 3, 5, 3);
            dataGridViewPoints.Name = "dataGridViewPoints";
            dataGridViewPoints.ReadOnly = true;
            dataGridViewPoints.RowHeadersWidth = 51;
            dataGridViewPoints.RowTemplate.Height = 29;
            dataGridViewPoints.ScrollBars = ScrollBars.None;
            dataGridViewPoints.Size = new Size(398, 71);
            dataGridViewPoints.TabIndex = 15;
            // 
            // AI
            // 
            AI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AI.HeaderText = "AI";
            AI.MinimumWidth = 6;
            AI.Name = "AI";
            AI.ReadOnly = true;
            // 
            // Human
            // 
            Human.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Human.HeaderText = "Human";
            Human.MinimumWidth = 6;
            Human.Name = "Human";
            Human.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(360, 72);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 40);
            label3.TabIndex = 16;
            label3.Text = "POINTS";
            // 
            // dataGridViewTime
            // 
            dataGridViewTime.AllowUserToDeleteRows = false;
            dataGridViewTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTime.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTime.Columns.AddRange(new DataGridViewColumn[] { Giocatore, Tempo });
            dataGridViewTime.Location = new Point(225, 260);
            dataGridViewTime.Margin = new Padding(5, 3, 5, 3);
            dataGridViewTime.Name = "dataGridViewTime";
            dataGridViewTime.ReadOnly = true;
            dataGridViewTime.RowHeadersWidth = 51;
            dataGridViewTime.RowTemplate.Height = 29;
            dataGridViewTime.ScrollBars = ScrollBars.Vertical;
            dataGridViewTime.Size = new Size(398, 454);
            dataGridViewTime.TabIndex = 17;
            // 
            // Giocatore
            // 
            Giocatore.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Giocatore.HeaderText = "Giocatore";
            Giocatore.MinimumWidth = 6;
            Giocatore.Name = "Giocatore";
            Giocatore.ReadOnly = true;
            // 
            // Tempo
            // 
            Tempo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tempo.HeaderText = "Tempo(ms)";
            Tempo.MinimumWidth = 6;
            Tempo.Name = "Tempo";
            Tempo.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(371, 217);
            label4.Name = "label4";
            label4.Size = new Size(101, 40);
            label4.TabIndex = 18;
            label4.Text = "TIME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 785);
            Controls.Add(label4);
            Controls.Add(dataGridViewTime);
            Controls.Add(label3);
            Controls.Add(dataGridViewPoints);
            Controls.Add(label2);
            Controls.Add(datagridViewDictionary);
            Controls.Add(dataGridViewBoard);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIC TAC TOE";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridViewDictionary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private System.Windows.Forms.Timer AITIMER;
        private Button button10;
        private DataGridView dataGridViewBoard;
        private DataGridView datagridViewDictionary;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label2;
        private DataGridView dataGridViewPoints;
        private Label label3;
        private DataGridView dataGridViewTime;
        private Label label4;
        private DataGridViewTextBoxColumn Colonna0;
        private DataGridViewTextBoxColumn Colonna1;
        private DataGridViewTextBoxColumn Colonna2;
        private DataGridViewTextBoxColumn AI;
        private DataGridViewTextBoxColumn Human;
        private DataGridViewTextBoxColumn Giocatore;
        private DataGridViewTextBoxColumn Tempo;
    }
}