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
        public bool ISx { get; set; }


        public void Move(ConsoleKey key)
        {
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
                    if (ISx && arr[X,Y] == " ")
                    {
                        if(X== 4)
                            X -= 2;
                        else if(X == 6)
                            X -= 2;
                        else if(Y == 4)
                            Y -= 2;
                         else if (Y == 6)
                            Y -= 2;
                        arr[X, Y] = "O";
                        ISx = false;
                        break;
                    }
                    else if(!ISx && arr[X, Y] == " ")
                    {
                        if (X == 4)
                            X -= 2;
                        else if (X == 6)
                            X -= 2;
                        else if (Y == 4)
                            Y -= 2;
                        else if (Y == 6)
                            Y -= 2;
                        arr[X, Y] = "X";
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
            } while (key != ConsoleKey.Enter);
        }

    }
}

