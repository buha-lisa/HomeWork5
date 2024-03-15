namespace hw5.TicTacToe.Player
{
    internal class Game
    {
        private char[,] _board;
        private char _player1;
        private char _player2;
        private bool _is_playerTurn;

        public Game()
        {
            _board = new char[3, 3];
            _player1 = 'X';
            _player2 = 'O';
            _is_playerTurn = new Random().Next(2) == 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _board[i, j] = ' ';
                }
            }
        }

        public void Play()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine($"Start the game.");

            while (true)
            {
                Draw_board();

                if (_is_playerTurn)
                {
                    _player1Move();
                    if (IsWinner(_player1))
                    {
                        Draw_board();
                        Console.WriteLine($"Congratulations! player {_player1} wins!");
                        break;
                    }
                }
                else
                {
                    _player2Move();
                    if (IsWinner(_player2))
                    {
                        Draw_board();
                        Console.WriteLine($"Congratulations! player {_player2} wins!");
                        break;
                    }
                }

                if (Is_boardFull())
                {
                    Draw_board();
                    Console.WriteLine("It's a draw!");
                    break;
                }

                _is_playerTurn = !_is_playerTurn;
            }
        }

        private void _player1Move()
        {
            Console.WriteLine($"Enter row (1-3) and column (1-3) separated by space:");
            string[] input = Console.ReadLine().Split();
            int.TryParse(input[0], out int row);
            int.TryParse(input[1], out int col);
            row -= 1; col -= 1;

            if (IsValidMove(row, col))
            {
                _board[row, col] = _player1;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                _player1Move();
            }
        }

        private void _player2Move()
        {
            Console.WriteLine($"Enter row (1-3) and column (1-3) separated by space:");
            string[] input = Console.ReadLine().Split();
            int.TryParse(input[0], out int row);
            int.TryParse(input[1], out int col);
            row -= 1; col -= 1;

            if (IsValidMove(row, col))
            {
                _board[row, col] = _player2;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                _player2Move();
            }
        }

        private bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < 3 && col >= 0 && col < 3 && _board[row, col] == ' ';
        }

        private bool IsWinner(char _player1)
        {
            for (int i = 0; i < 3; i++)
            {
                if (_board[i, 0] == _player1 && _board[i, 1] == _player1 && _board[i, 2] == _player1)
                    return true;
                if (_board[0, i] == _player1 && _board[1, i] == _player1 && _board[2, i] == _player1)
                    return true;
            }

            if (_board[0, 0] == _player1 && _board[1, 1] == _player1 && _board[2, 2] == _player1)
                return true;
            if (_board[0, 2] == _player1 && _board[1, 1] == _player1 && _board[2, 0] == _player1)
                return true;

            return false;
        }

        private bool Is_boardFull()
        {
            foreach (char i in _board)
            {
                if (i == ' ')
                    return false;
            }
            return true;
        }

        private void Draw_board()
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_board[i, j] + " | ");
                }
                Console.WriteLine("\n-------------");
            }
        }

    }
}
