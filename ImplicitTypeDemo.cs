using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class ImplicitTypeDemo
    {
        static void Main()
        {
            var a = 100;
            var name = "raavi";
            var arr = new[] { 11, 22, 33 };

            Console.WriteLine(a + " _" + a.GetType());
            Console.WriteLine(name);
            Console.WriteLine(arr);

           /* a = "c#";
            var i; //implicit variables should be initiated
            i = 100;

            var j =10,k =30:*/

        }
    }
}
