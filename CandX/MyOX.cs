using System;
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
$@"{arr[0, 0]}|{arr[0,1]}|{arr[0, 2]}
-+-+- 
{arr[1, 0]}|{arr[1, 1]}|{arr[1,2]} 
-+-+-
{arr[2, 0]}|{arr[2, 1]}|{arr[2, 2]}
");
            Console.SetCursorPosition(X, Y);
        }
        string[,] arr = new string[,] { {" "," "," " }, { " ", " ", " " }, { " ", " ", " " } };
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(ConsoleKey key)
        {
            bool isX = false;
            switch (key)
            {
                case ConsoleKey.RightArrow:
                    if (X != 4)
                        X+=2;                    
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
                        Y+=2;
                    break;
                case ConsoleKey.Spacebar:
                    if (isX == false)
                    {
                        arr[X,Y] = "X";
                        isX = true;
                    }
                    else
                        arr[X, Y] = "O";
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
            } while (key != ConsoleKey.Enter);
        }

    }
}

