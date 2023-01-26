using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GaussEliminacio
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("DiMat II Szorgalmi 1\nHeidrich Lorand (GWJZ4T)\n09/18/2022\n");

            Console.WriteLine("Rendezetlen random matrix[4,4]:");
            Random r = new Random();
            int[,] mx = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mx[i, j] = (int)(r.Next(-10, 11));
                    Console.Write(mx[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //masodik sor elso elem legyen 0
            if (mx[1, 0] != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    mx[1, i] = mx[1, i] - (mx[0, i] / mx[0, 0]) * mx[1, 0];
                }
            }
            //harmadik sor elso elem legyen 0
            if (mx[2, 0] != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    mx[2, i] = mx[2, i] - (mx[0, i] / mx[0, 0]) * mx[2, 0];
                }
            }
            //negyedik sor elso elem legyen 0
            if (mx[3, 0] != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    mx[3, i] = mx[3, i] - (mx[0, i] / mx[0, 0]) * mx[3, 0];
                }
            }
            //harmadik sor masodik eleme legyen 0
            if (mx[2, 1] != 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    mx[2, i] = mx[2, i] - (mx[1, i] / mx[1, 1] * mx[2, 1]);
                }
            }
            //negyedik sor masodik eleme legyen 0
            if (mx[3, 1] != 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    mx[3, i] = mx[3, i] - (mx[1, i] / mx[1, 1] * mx[3, 1]);
                }
            }
            //negyedik sor harmadik eleme legyen 0
            if (mx[3, 2] != 0)
            {
                for (int i = 2; i < 4; i++)
                {
                    mx[3, i] = mx[3, i] - (mx[1, i] / mx[1, 2] * mx[3, 2]);
                }
            }
            //sorok vezeto eleme 1
            for (int i = 0; i < 4; i++)
            {
                if (mx[i, i] != 1)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        mx[i, j] = mx[i, j] / mx[i, i];
                    }
                }
            }
            //masodik oszlop nullaz
            if (mx[0, 1] != 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    mx[0, i] = mx[0, i] - (mx[1, i] * mx[0, 1]);
                }
            }
            //harmadik oszlop nullaz
            for (int n = 0; n < 2; n++)
            {
                if (mx[n, 2] != 0)
                {
                    for (int i = 2; i < 4; i++)
                    {
                        mx[n, i] = mx[n, i] - (mx[2, i] * mx[n, 2]);
                    }
                }
            }

            Console.WriteLine("\nRendezett matrix:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(mx[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }//end Main

    }//end Program (cl)

}//end GaussEliminacio (ns)

   



