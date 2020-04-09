using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Ex12a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ArrayA = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> Testing  = ArrayA.Where(integer => integer % 2 == 0);
           
            foreach (int i in Testing)
            {
                Console.WriteLine(i);
            }



            
            
            
            


        }
    }
}
