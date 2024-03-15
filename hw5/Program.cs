using TicTac1 = hw5.TicTacToe.Computer;
using TicTac2 = hw5.TicTacToe.Player;
using Translate1 = hw5.Translation.ToMorthe;
using Translate2 = hw5.Translation.FromMorthe;

namespace hw5
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-2): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        {
                            Console.Write("1. With computer\n2. With others\n");
                            int.TryParse(Console.ReadLine(), out int mode);
                            if (mode == 1)
                            {
                                TicTac1.Game game = new TicTac1.Game();
                                game.Play();
                            }
                            if (mode == 2)
                            {
                                TicTac2.Game game = new TicTac2.Game();
                                game.Play();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("1. From Text To Morthe\n2. From Morthe To Text\n");
                            int.TryParse(Console.ReadLine(), out int mode);
                            if (mode == 1)
                            {
                                Console.WriteLine("Enter text to translate to Morse code:");
                                string input = Console.ReadLine();
                                Translate1.Text text = new Translate1.Text();
                                text.TranslateToMorseCode(input);
                            }
                            if (mode == 2)
                            {
                                Console.WriteLine("Enter Morse code to translate to text:");
                                string input = Console.ReadLine();
                                Translate2.Text text = new Translate2.Text();
                                text.ToText(input);
                            }
                            break;
                        }
                }
                if (task == 0) break;
            }
        }
    }
}
