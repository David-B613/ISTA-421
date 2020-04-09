using System;

namespace Base_Number_Conversion
{
    class Program 
    {
       public static void Main(string[] args)
        {
            int num1;
            int basenum;

            Console.Write("Please enter a integer to convert: \n");
             num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the base to convert from:  2 |  8  |  10  |: ");
             basenum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number: {num1}, base: {basenum}");

            Conversions.Dec2Bin(num1);






        }
    }
}
