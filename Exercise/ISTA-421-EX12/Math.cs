using System;
using System.Collections.Generic;
using System.Text;


namespace ISTA_421_EX12
{
    class Math
    {
        public static void initialize()
        {
        Start:
            Console.WriteLine("Weclcome To Math Games \n To add enter 1, \n To subtract, enter 2, \n To multiply, enter 3, \n To divide, enter 4.");

            Console.Write("Choose your problem:   ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Substract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                default:
                    Console.WriteLine("You have selected an invalid option please try again.");
                    goto Start;

            }


        }
        public static void Add()
        {
        
            int randomNumber;
            int randomNumberB;

            Random A = new Random();
            randomNumber = A.Next(1, 13);

            Random B = new Random();
            randomNumberB = B.Next(1, 13);

            int sum = randomNumber + randomNumberB;
            

           
            Console.Write("Enter the number of problems you would to slove 1 - 5:  ");
            int Ahowmany = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have selected to complete {Ahowmany} addition problems.");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();


            if (Ahowmany == 1)
            {
                
                Console.Write($" {randomNumber} + {randomNumberB} =  "); 
                int answer = int.Parse(Console.ReadLine());
                                                           

                if (answer == sum)
                {
                    Console.WriteLine("Correct");
                                   
                }

                else
                {
                    Console.WriteLine($"The correct answer is {sum}");
                    
                }


            }



            









        }
        public static void Substract()
        {
            Console.WriteLine();
        }
        public static void Multiply()
        {
            Console.WriteLine();
        }
        public static void Divide()
        {
            Console.WriteLine();
        }
        public static void Report()
        {
            Console.WriteLine();
        }

    }

}
