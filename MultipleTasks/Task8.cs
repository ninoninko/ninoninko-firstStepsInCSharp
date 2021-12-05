using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Task8
    {
        public static void goToProgram8()
        {

            int numberOfTimes = Methods.getNumber();

            double[] arrayAsIntegers = Methods.getArrayFromString();

            for (int j = 0; j < numberOfTimes; j++)
            {
                for (int i = 0; i < arrayAsIntegers.Length - 1; i++)
                {
                        double temporary = arrayAsIntegers[i];
                        arrayAsIntegers[i] = arrayAsIntegers[i + 1];
                        arrayAsIntegers[i + 1] = temporary;
                }
            }

            Console.Write("Your swapped array looks like this: ");
            for (int i = 0; i < arrayAsIntegers.Length; i++)
            {
                Console.Write(arrayAsIntegers[i] + " ");
            }

            Console.WriteLine("Dear user, we will refer you back to the initial screen." +
                "\nThank you for choosing number 8!");

            Methods.executionMethod();
        }
    }
}
