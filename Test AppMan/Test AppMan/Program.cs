using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_AppMan
{
    class Program
    {
        //Bingo 5x5
        const int  xLength =5 , yLength =5;
        static int[,] table = new int[xLength, yLength] {
                    {1,2,3,4,5},
                    {6,7,8,9,10},
                    {11,12,13,14,15},
                    {16,17,18,19,20},
                    {21,22,23,24,25},
                };
        static void Main(string[] args)
        {
            int[] ans = { 3, 4, 8, 13, 18, 19, 23 };
            Console.WriteLine("{ 3, 4, 8, 13, 18, 19, 23 }");
            if (findBingo(ans)) { Console.WriteLine("Bingo"); } else { Console.WriteLine("Not Bingo"); }

            Console.WriteLine("{ 1, 13, 19, 25, 23, 2 }");
            ans = new int[]{ 1, 13, 19, 25, 23, 2 };
            if (findBingo(ans)) { Console.WriteLine("Bingo"); } else { Console.WriteLine("Not Bingo"); }

            Console.WriteLine("{ 2, 1, 12, 15, 6, 18 , 16 ,4 ,3,21,11  }");
            ans = new int[] { 2, 1, 12, 15, 6, 18 , 16 ,4 ,3,21,11  };
            if (findBingo(ans)) { Console.WriteLine("Bingo"); } else { Console.WriteLine("Not Bingo"); }




            //// bingo will be x 1-5 or y 1-5 which one equal 1-5 and must order will be bingo
            //Console.WriteLine(table[0, 0]);
            //Console.WriteLine(table[1, 0]);
            //Console.WriteLine(table[2, 0]);
            //Console.WriteLine(table[3, 0]);
            //Console.WriteLine(table[4, 0]);

            //Console.WriteLine(table[0, 1]);
            //Console.WriteLine(table[1, 1]);
            //Console.WriteLine(table[2, 1]);
            //Console.WriteLine(table[3, 1]);
            //Console.WriteLine(table[4, 1]);

            //Console.WriteLine(table[0, 2]);
            //Console.WriteLine(table[1, 2]);
            //Console.WriteLine(table[2, 2]);
            //Console.WriteLine(table[3, 2]);
            //Console.WriteLine(table[4, 2]);

            //// bingo slide will be 
            //Console.WriteLine(table[0, 0]);
            //Console.WriteLine(table[1, 1]);
            //Console.WriteLine(table[2, 2]);
            //Console.WriteLine(table[3, 3]);
            //Console.WriteLine(table[4, 4]);

            //Console.WriteLine(table[0, 4]);
            //Console.WriteLine(table[1, 3]);
            //Console.WriteLine(table[2, 2]);
            //Console.WriteLine(table[3, 1]);
            //Console.WriteLine(table[4, 0]);


            Console.ReadLine();
        }
        static bool findBingo(int[] ans)
        {
  
            List<int> xAxisBingo = new List<int>();
            List<int> yAxisBingo = new List<int>();
            foreach (var item in ans)
            {
                int[] result = findNumber(item);
                int x = result[0];
                int y = result[1];
                if (xAxisBingo.IndexOf(x) == -1)
                {
                    xAxisBingo.Add(x);
                }
                if (yAxisBingo.IndexOf(y) == -1)
                {
                    yAxisBingo.Add(y);
                }
            }
            bool isBingo = false;
            if (xAxisBingo.Count == xLength)
            {
                isBingo = true;
                //and must order 1,2,3,4,5
                for (int i = 0; i < xAxisBingo.Count; i++)
                {
                    if (xAxisBingo[i] != i)
                    {
                        //this axis not order then not bingo
                        isBingo = false;
                        break;
                    }
                }


            }
            if (!isBingo && yAxisBingo.Count == yLength)
            {
                isBingo = true;
                //and must order 1,2,3,4,5
                for (int i = 0; i < yAxisBingo.Count; i++)
                {
                    if (yAxisBingo[i] != i)
                    {
                        //this axis not order then not bingo
                        isBingo = false;
                        break;
                    }
                }
            }
            if(xAxisBingo.Count == xLength && yAxisBingo.Count == yLength)
            {
                isBingo = true;
            }
            return isBingo;
    
        }
        static int[] findNumber(int findNum)
        {
            int x = 0, y = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(findNum == table[i, j])
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[2] {1,2};
        }
    }
}
