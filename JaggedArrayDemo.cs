using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class JaggedArrayDemo
    {
       static void Main()
        {
            int[][] a = new int[2][]; //declare 
                                      //jagged array

            //intialize the array
            a[0] = new int[] { 20, 30, 40 };
            a[1] = new int[] { 11, 22, 33, 44, 55 };

            //Transverse the array elements
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a[i].Length;j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();  
        }
    }
}
