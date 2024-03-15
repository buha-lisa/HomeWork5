namespace hw5.TicTacToe.Computer
{
    internal class Game
    {
        private char[,] _board;
        private char _player;
        private char _computer;
        private bool _is_playerTurn;

        public Game()
        {
            _board = new char[3, 3];
            _player = 'X';
            _computer = 'O';
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
                    _playerMove();
                    if (IsWinner(_player))
                    {
                        Draw_board();
                        Console.WriteLine($"Congratulations! player {_player} wins!");
                        break;
                    }
                }
                else
                {
                    _computerMove();
                    if (IsWinner(_computer))
                    {
                        Draw_board();
                        Console.WriteLine("Sorry, the computer wins!");
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

        private void _playerMove()
        {
            Console.WriteLine($"Enter row (1-3) and column (1-3) separated by space:");
            string[] input = Console.ReadLine().Split();
            int.TryParse(input[0], out int row);
            int.TryParse(input[1], out int col);
            row -= 1; col -= 1;

            if (IsValidMove(row, col))
            {
                _board[row, col] = _player;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                _playerMove();
            }
        }

        private void _computerMove()
        {
            int row, col;
            do
            {
                row = new Random().Next(3);
                col = new Random().Next(3);
            } while (!IsValidMove(row, col));

            _board[row, col] = _computer;
        }

        private bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < 3 && col >= 0 && col < 3 && _board[row, col] == ' ';
        }

        private bool IsWinner(char _player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (_board[i, 0] == _player && _board[i, 1] == _player && _board[i, 2] == _player)
                    return true;
                if (_board[0, i] == _player && _board[1, i] == _player && _board[2, i] == _player)
                    return true;
            }

            if (_board[0, 0] == _player && _board[1, 1] == _player && _board[2, 2] == _player)
                return true;
            if (_board[0, 2] == _player && _board[1, 1] == _player && _board[2, 0] == _player)
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
