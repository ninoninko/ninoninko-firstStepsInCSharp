using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Methods
    {
        public static void executionMethod()
        {
            Console.WriteLine("Dear user, please pick a number between 7 and 10." +
                "\nPlease pick 0 if you wish to cancel the execution of this program");
            string choicer = Console.ReadLine();
            int choice = 0;



            while (!((int.TryParse(choicer, out choice)) && (choice >= 7 && choice <= 10 || choice == 0)))
            {

                Console.WriteLine("Dear user, please input a number between 7 and 10. Don't be gay");
                choicer = Console.ReadLine();

                if (int.TryParse(choicer, out choice) == true && choice == 0)
                {
                    Console.WriteLine("Dear user, you have chosen to cancel the execution of this program." +
                        "\nWe hope to see you soon again");
                    Environment.Exit(0);
                }
            }


            switch (choice)
            {
                case 7:
                    Task7.goToProgram7();
                    break;
                case 8:
                    Task8.goToProgram8();
                    break;
                case 9:
                    Task9.goToProgram9();
                    break;
                case 10:
                    Task10.goToProgram10();
                    break;
            }
        }

        public static int getNumber()
        {
            string input = Console.ReadLine();
            int number = 0;

            while (!(int.TryParse(input, out number) && number > 0))
            {
                Console.WriteLine("Dear user, please input a number which is bigger than 0");
                input = Console.ReadLine();
            }

            return number;
        }

        public static double[] getArrayFromString()
        {
            Console.WriteLine("Dear user, please input the array as a string. Separate them in" +
               "\na normal way, otherwise we cannot guarantee that the program will work");
            string arrayAsString = Console.ReadLine();
            string[] splitters = { " ", ", ", "|", "| ", ";", "\\", "=", ",", "= " };
            double[] arrayAsIntegers = arrayAsString
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => double.Parse(s))
                .ToArray();

            return arrayAsIntegers;
        }

        public static int[] getArrayFromStringInt()
        {
            Console.WriteLine("Dear user, please input the array as a string. Separate them in" +
               "\na normal way, otherwise we cannot guarantee that the program will work");
            string arrayAsString = Console.ReadLine();
            string[] splitters = { " ", ", ", "|", "| ", ";", "\\", "=", ",", "= " };
            int[] arrayAsIntegers = arrayAsString
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToArray();

            return arrayAsIntegers;
        }
    }
}

