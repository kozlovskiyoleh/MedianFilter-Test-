using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] display = new int[12,6];
            //int xs=0, ys=0;
            int count = 0;
            for (int y = 0; y < display.GetLength(0); y++)
            {
                for (int x = 0; x < display.GetLength(1); x++)
                {
                    display[y, x] =0;
                }
            }

            for (int y = 0; y < display.GetLength(0); y++)
            {
                for (int x = 0; x < display.GetLength(1); x++)
                {
                    Console.Write(display[y, x] + " ");
                }
                Console.WriteLine();
            }
            display = Window(0, 0, display, 1);
            display = Window(3, 0, display, 2);
            display = Window(0, 3, display, 3);
            display = Window(3, 3, display, 4);

            Console.ReadKey();
        }

        static int[,] Window(int xShift, int yShift, int[,] display1, int data)
        {
            int[,] windows = new int[3, 3];
            for(int y = 0; y < 3; y++)
            {
                for(int x = 0; x < 3; x++)
                {
                    //windows[x, y] = display1[x, y];
                    display1[y + yShift,x + xShift] = data;
                }
            }
            return display1;
        }
    }
}
