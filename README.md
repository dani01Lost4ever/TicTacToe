# TicTacToe

A Windows Forms Tic-Tac-Toe game built with C# and .NET 6, featuring an AI opponent powered by the Minimax algorithm with alpha-beta pruning.

## Features

- **Human vs AI** — You play as X, the AI plays as O
- **Minimax AI** — The AI evaluates positions using Minimax with alpha-beta pruning (depth 4)
- **Random first move** — On its first move after the human, the AI picks randomly from the same row/column to avoid always playing the same opening
- **Randomized start** — Each new game randomly decides whether the human or the AI goes first
- **Score tracking** — Persistent win counter for both AI and Human across resets
- **Analytics panel** — Live view of the board state, per-cell AI scores, and AI move timing in milliseconds
- **Animated PLAY button** — Background color cycles through RGB values

## Requirements

- Windows 10 / 11
- [.NET 6.0 Runtime (Windows)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Visual Studio 2022 (to build from source)

## Getting Started

### Build and run

1. Clone the repository:
   ```
   git clone https://github.com/your-username/TicTacToe.git
   ```
2. Open `TicTacToe.sln` in Visual Studio 2022.
3. Press **F5** to build and run.

### How to play

1. Click **PLAY** to start a new game. The game randomly assigns who goes first.
2. If it is your turn, click any cell on the 3×3 grid (cells are highlighted in light blue).
3. Your move is marked **X** (green). The AI responds with **O** (yellow).
4. The game ends when someone gets three in a row, or the board is full (draw).
5. Click **PLAY** again to reset and start a new game. Scores persist across resets.

## Project Structure

```
TicTacToe/
├── Form1.cs              # Game logic: human input, AI, Minimax, win/draw detection
├── Form1.Designer.cs     # WinForms layout (auto-generated)
├── Program.cs            # Entry point
├── TicTacToe.csproj      # .NET 6 Windows project file
└── Properties/
    └── Resources.*       # Embedded resources
```

## AI Implementation

The AI uses **Minimax with alpha-beta pruning** (`MiniMax` method in `Form1.cs`):

- Searches up to depth 4.
- Scores terminal states: AI win = +10, Human win = −10, draw = 0.
- `GetBestMove` evaluates each available cell by simulating both an AI move and a human move, then picks the cell with the highest `aiScore − humanScore`.
- On the AI's very first move (right after the human's first move), it plays randomly within the same row or column as the human's piece to add variety.

## UI Layout

| Panel | Description |
|---|---|
| 3×3 grid (center) | Playable board |
| POINTS (left) | Win count — AI vs Human |
| TIME (left) | AI move durations in milliseconds |
| Analytics (right) | Live board state grid and per-cell Minimax scores |

## License

See [LICENSE.txt](LICENSE.txt).
