using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Methods
    {

        /// <summary>
        /// The following method contains the main idea
        /// of the program.It makes calls to the separates
        /// subtasks of the program.
        /// </summary>
        public static void executionMethod()
        {
            Console.WriteLine("Dear user, please pick a number between 6 and 10." +
                "\nPlease pick 0 if you wish to cancel the execution of this program");
            string choicer = Console.ReadLine();
            int choice = 0;

            while (!((int.TryParse(choicer, out choice)) && (choice >= 6 && choice <= 10 || choice == 0)))
            {

                Console.WriteLine("Dear user, please input a number between 6 and 10. Don't be gay");
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
                case 6:
                    Task6.goToProgram6();
                    break;
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

        /// <summary>
        /// The following method gets a text from the user
        /// and tries to parse it to an integer number.
        /// </summary>
        /// <returns> the number which has been inputted </returns>

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

        /// <summary>
        /// The following method gets an array of doubles as a
        /// string from the user and takes only the number 
        /// entries from it.
        /// </summary>
        /// <returns> the array as an array of doubles </returns>
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

        /// <summary>
        /// The following method gets an array of ints as a
        /// string from the user and takes only the number 
        /// entries from it.
        /// </summary>
        /// <returns> the array as an array of ints </returns>
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

