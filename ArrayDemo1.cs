using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class ArrayDemo1
    {
        static void Main()
        {
            int[,] a = new int[3, 3]; //declaring 2d array



            //initialisation



            a[0, 0] = 100;    //store 100 in 1st row and 1st column
            a[1, 1] = 200;
            a[2, 2] = 300;



            //traverse



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();



            }



            //declare and initialise
            int[,] b = { { 11, 22, 33 }, { 44, 55, 77 }, { 66, 88, 99 } };



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("the size of 2-D array is" + "" + b.Length);
            Console.WriteLine("the dimension of array is" + "" + b.Rank);



            int[,] c = new int[5, 10];
            Console.WriteLine("the numbe rof rows is " + b.GetLength(0));
            Console.WriteLine("the numbe rof columns is " + b.GetLength(1));



            Console.ReadKey();



        }
    }
}
