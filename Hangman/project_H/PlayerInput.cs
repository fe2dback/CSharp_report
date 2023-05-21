using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace project_H
{
    class PlayerInput
    {
        static char word = ' ';

        public void PlayerInput_M()
        {
            
        }
        public char userChar()
        {
            return word = return_input();
            
        }
        static char return_input()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.A:
                    return 'A';
                    break;
                case ConsoleKey.B:
                    return 'B';
                    break;
                case ConsoleKey.C:
                    return 'C';
                    break;
                case ConsoleKey.D:
                    return 'D';
                    break;
                case ConsoleKey.E:
                    return 'E';
                    break;
                case ConsoleKey.F:
                    return 'F';
                    break;
                case ConsoleKey.G:
                    return 'G';
                    break;
                case ConsoleKey.H:
                    return 'H';
                    break;
                case ConsoleKey.I:
                    return 'I';
                    break;
                case ConsoleKey.J:
                    return 'J';
                    break;
                case ConsoleKey.K:
                    return 'K';
                    break;
                case ConsoleKey.L:
                    return 'L';
                    break;
                case ConsoleKey.M:
                    return 'M';
                    break;
                case ConsoleKey.N:
                    return 'N';
                    break;
                case ConsoleKey.O:
                    return 'O';
                    break;
                case ConsoleKey.P:
                    return 'P';
                    break;
                case ConsoleKey.Q:
                    return 'Q';
                    break;
                case ConsoleKey.R:
                    return 'R';
                    break;
                case ConsoleKey.S:
                    return 'S';
                    break;
                case ConsoleKey.T:
                    return 'T';
                    break;
                case ConsoleKey.U:
                    return 'U';
                    break;
                case ConsoleKey.V:
                    return 'V';
                    break;
                case ConsoleKey.W:
                    return 'W';
                    break;
                case ConsoleKey.X:
                    return 'X';
                    break;
                case ConsoleKey.Y:
                    return 'Y';
                    break;
                case ConsoleKey.Z:
                    return 'Z';
                    break;
                default:
                    return '0';
                    break;
            }
        }
    }
}
