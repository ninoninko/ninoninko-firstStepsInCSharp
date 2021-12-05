using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Task6
    {
        public static void goToProgram6()
        {

            int[] firstArray = Methods.getArrayFromStringInt();
            int[] secondArray = Methods.getArrayFromStringInt();
            bool checker = true;

            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("The arrays are not of equal size.");
                checker = false;
            } else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i]) {
                        Console.WriteLine("The arrays differ at index: " + i);
                        checker = false;
                        break;
                    }
                }
            }

            if (checker)
            {
                Console.WriteLine("The two arrays are of equal elemets. The sum of the elements in one is: " + firstArray.Sum());
            }

            Console.WriteLine("Dear user, we will refer you back to the initial screen." +
                 "\nThank you for choosing number 6!");

            Methods.executionMethod();

        }
    }
}
