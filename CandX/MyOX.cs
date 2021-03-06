﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandX
{
    class MyOX
    {
        public void Menu()
        {
            Console.Clear();
            Console.Write(
$@"{arr[0, 0]}|{arr[1, 0]}|{arr[2, 0]}
-+-+- 
{arr[0, 1]}|{arr[1, 1]}|{arr[2, 1]} 
-+-+-
{arr[0, 2]}|{arr[1, 2]}|{arr[2, 2]}
");
            Console.SetCursorPosition(X, Y);
        }
        string[,] arr = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        public int X { get; set; }
        public int Y { get; set; }
        public bool ISx { get; set; }
        public bool IsWin { get; set; }// false
        public int WinX { get; set; }
        public int WinO { get; set; }
        public int NoWinner { get; set; }
        public bool Info()
        {
            if (arr[0, 0] == "X" && arr[0, 1] == "X" && arr[0, 2] == "X"
                || arr[1, 0] == "X" && arr[1, 1] == "X" && arr[1, 2] == "X"
                || arr[2, 0] == "X" && arr[2, 1] == "X" && arr[2, 2] == "X"
                || arr[0, 0] == "X" && arr[1, 0] == "X" && arr[2, 0] == "X"
                || arr[0, 1] == "X" && arr[1, 1] == "X" && arr[2, 1] == "X"
                || arr[0, 2] == "X" && arr[1, 2] == "X" && arr[2, 2] == "X"
                || arr[0, 0] == "X" && arr[1, 1] == "X" && arr[2, 2] == "X"
                || arr[2, 2] == "X" && arr[1, 1] == "X" && arr[0, 0] == "X"
                )
            {
                WinX++;
                return IsWin = true;
            }
            else if (arr[0, 0] == "O" && arr[1, 0] == "O" && arr[2, 0] == "O"
                || arr[0, 1] == "O" && arr[1, 1] == "O" && arr[2, 1] == "O"
                || arr[0, 2] == "O" && arr[1, 2] == "O" && arr[2, 2] == "O"
                || arr[0, 0] == "O" && arr[1, 1] == "O" && arr[2, 2] == "O"
                || arr[2, 2] == "O" && arr[1, 1] == "O" && arr[0, 0] == "O"
                || arr[0, 0] == "O" && arr[0, 1] == "O" && arr[0, 2] == "O"
                || arr[1, 0] == "O" && arr[1, 1] == "O" && arr[1, 2] == "O"
                || arr[2, 0] == "O" && arr[2, 1] == "O" && arr[2, 2] == "O"
                )
            {
                WinO++;
                return IsWin = true;
            }
            else
                NoWinner++;
            return IsWin;
        }
        public void Move(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.RightArrow:
                    if (X != 4)
                        X += 2;
                    break;
                case ConsoleKey.LeftArrow:
                    if (X != 0)
                        X -= 2;
                    break;
                case ConsoleKey.UpArrow:
                    if (Y != 0)
                        Y -= 2;
                    break;
                case ConsoleKey.DownArrow:
                    if (Y != 4)
                        Y += 2;
                    break;
                case ConsoleKey.Spacebar:
                    if (ISx && arr[X / 2, Y / 2] == " ")
                    {
                        arr[X / 2, Y / 2] = "O";
                        ISx = false;
                        break;
                    }
                    else if (!ISx && arr[X / 2, Y / 2] == " ")
                    {
                        arr[X / 2, Y / 2] = "X";
                        ISx = true;
                        break;
                    }
                    break;

            }
        }

        public void Engine()
        {
            ConsoleKey key;
            Menu();
            do
            {
                key = Console.ReadKey().Key;
                Move(key);
                Menu();
                if (Info() == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("\n\n\n\nyou won");
                    break;
                }
            } while (key != ConsoleKey.Enter);

        }

    }
}

