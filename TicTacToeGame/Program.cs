using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int position;
        static int player = 1;
        static int check = 0;



        public static void Board()
        {
            Console.WriteLine("       |       |       |");
            Console.WriteLine("    " + arr[1] + "  |    " + arr[2] + "  |    " + arr[3] + "  |");
            Console.WriteLine("------------------------");
            Console.WriteLine("       |       |       |");
            Console.WriteLine("    " + arr[4] + "  |    " + arr[5] + "  |    " + arr[6] + "  |");
            Console.WriteLine("------------------------");
            Console.WriteLine("       |       |       |");
            Console.WriteLine("    " + arr[7] + "  |    " + arr[8] + "  |    " + arr[9] + "  |");
        }



        public static int WinnerCheck()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }



            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }



        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n");
                Board();
                Console.WriteLine("Player 1 : 'X' & player 2 : 'O'");
                Console.WriteLine();
                if (player % 2 != 0)
                {
                    Console.Write("Player 1 turn : ");
                }
                else
                {
                    Console.Write("Player 2 turn : ");
                }
                position = int.Parse(Console.ReadLine());



                if (arr[position] != 'X' && arr[position] != 'O')
                {
                    if (player % 2 != 0)
                    {
                        arr[position] = 'X';
                        player++;
                    }
                    else
                    {
                        arr[position] = 'O';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The position " + position + " is already occupied choose different.");
                    Console.WriteLine();



                }
                check = WinnerCheck();
            }
            while (check != 1 && check != -1);
            Board();



            if (check == 1)
            {
                if (player % 2 == 0)
                    Console.WriteLine("Winner is Player 1");
                else
                    Console.WriteLine("Winner is player 2");
            }
            else
            {
                Console.WriteLine("Match tied");
            }
            Console.ReadLine();
        }
    }
}
