using System;
using System.Collections.Generic;
using System.Text;



namespace ISTA_421_EX12
{
    public class Math
    {
        public static void Initialize()
        {

        Start:
            Console.WriteLine("Weclcome To Math Games \n To add enter 1, \n To subtract, enter 2, \n To multiply, enter 3, \n To divide, enter 4");

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


            Console.Write("Enter the number of problems you would to slove 1 - 5:  ");
            int NumOfQuestions = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have selected to complete {NumOfQuestions} addition problems.");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();

            double Correctanswer = 0;
            for (int i = 1; i <= NumOfQuestions; i++)
            {

                Random C = new Random();
                int randomNumberA = C.Next(14, 27);
                int randomNumberB = C.Next(1, 13);
                int sum = randomNumberA + randomNumberB;

                Console.Write($" {randomNumberA} + {randomNumberB} =  ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == sum)
                {
                    Correctanswer++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"The correct answer is {sum}");
                }
            }
            double average = 100 * Correctanswer / NumOfQuestions;
            string Quite;
            Console.WriteLine($"You answered {Correctanswer} problems. Your total score is {average} ");
            Console.Write("Enter Q to quit or Press any other key to continue to do more Math problems.");
             Quite = (Console.ReadLine());
            if (Quite == "q")
            {
                System.Environment.Exit(0);
            }
            if (Quite == "Q")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Initialize();
            }
        
            
        }
        public static void Substract()
        {
            Console.Write("Enter the number of problems you would to slove 1 - 5:  ");
            int Ahowmany = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have selected to complete {Ahowmany} addition problems.");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();

            double Correctanswer = 0;
            for (int i = 1; i <= Ahowmany; i++)
            {

                Random C = new Random();
                double randomNumberA = C.Next(14, 27);
                double randomNumberB = C.Next(1, 13);
                double sum = randomNumberA - randomNumberB;

                Console.Write($" {randomNumberA} - {randomNumberB} =  ");
                double answer = int.Parse(Console.ReadLine());
                if (answer == sum)
                {
                    Correctanswer++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"The correct answer is {sum}");
                }
            }
            double average = 100 * Correctanswer / Ahowmany;
            string Quite;
            Console.WriteLine($"You answered {Correctanswer} problems. Your total score is {average} ");
            Console.Write("Enter Q to quit or Press any other key to continue to do more Math problems.");
            Quite = (Console.ReadLine());
            if (Quite == "q")
            {
                System.Environment.Exit(0);
            }
            if (Quite == "Q")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Initialize();
            }

        }
        public static void Multiply()
        {
            Console.Write("Enter the number of problems you would to slove 1 - 5:  ");
            int Ahowmany = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have selected to complete {Ahowmany} addition problems.");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();

            double Correctanswer = 0;
            for (int i = 1; i <= Ahowmany; i++)
            {

                Random C = new Random();
                double randomNumberA = C.Next(14, 27);
                double randomNumberB = C.Next(1, 13);
                double sum = randomNumberA * randomNumberB;

                Console.Write($" {randomNumberA} * {randomNumberB} =  ");
                double answer = int.Parse(Console.ReadLine());
                if (answer == sum)
                {
                    Correctanswer++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"The correct answer is {sum}");
                }
            }
            double average = 100 * Correctanswer / Ahowmany;
            string Quite;
            Console.WriteLine($"You answered {Correctanswer} problems. Your total score is {average} ");
            Console.Write("Enter Q to quit or Press any other key to continue to do more Math problems.");
            Quite = (Console.ReadLine());
            if (Quite == "q")
            {
                System.Environment.Exit(0);
            }
            if (Quite == "Q")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Initialize();
            }
        }
        public static void Divide()
        {
            Console.Write("Enter the number of problems you would to slove 1 - 5:  ");
            int Ahowmany = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have selected to complete {Ahowmany} addition problems.");
            Console.WriteLine("Press enter to start");
            Console.ReadLine();

            double Correctanswer = 0;
            for (int i = 1; i <= Ahowmany; i++)
            {

                Random C = new Random();
                double randomNumberA = C.Next(14, 27);
                double randomNumberB = C.Next(1, 13);
                double sum = randomNumberA / randomNumberB;

                Console.Write($" {randomNumberA} / {randomNumberB} =  ");
                double answer = int.Parse(Console.ReadLine());
                if (answer == sum)
                {
                    Correctanswer++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"The correct answer is {sum}");
                }
            }
            double average = 100 * Correctanswer / Ahowmany;
            string Quite;
            Console.WriteLine($"You answered {Correctanswer} problems. Your total score is {average} ");
            Console.Write("Enter Q to quit or Press any other key to continue to do more Math problems.");
            Quite = (Console.ReadLine());
            if (Quite == "q")
            {
                System.Environment.Exit(0);
            }
            if (Quite == "Q")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Initialize();
            }
        }

    }

}
