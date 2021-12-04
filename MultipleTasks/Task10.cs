using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Task10
    {
        public static void goToProgram10()
        {
            Console.WriteLine("Dear user, in the following program you are asked" +
                "\nto input an array and the program will print the leftmost " +
                "\nlongest encounter of the same symbols. The arrays must be" +
                "\nstoring ONLY integer values");

            int[] arrayAsInt = Methods.getArrayFromStringInt();

            if (arrayAsInt.Length == 1)
            {
                Console.WriteLine(arrayAsInt[0]);
                Console.WriteLine("Dear user, we will refer you back to the initial screen." +
                "\nThank you for choosing number 10!");

                Methods.executionMethod();
            }

            int currentElement = int.MinValue;
            int encounters = 1;
            int encountersLongest = 0;
            int encountersLongestElement = 0;

            currentElement = arrayAsInt[0];
            for (int i = 1; i < arrayAsInt.Length; i ++)
            {
                if (currentElement == arrayAsInt[i])
                {
                    encounters++;
                } else
                {   
                    if (encountersLongest < encounters)
                    {
                        encountersLongestElement = arrayAsInt[i - 1];
                        encountersLongest = encounters;
                    } 
                    
                    encounters = 1;
                    currentElement = arrayAsInt[i];
                }

                if (i == arrayAsInt.Length - 1)
                {
                    if (encountersLongest < encounters)
                    {
                        encountersLongestElement = arrayAsInt[i - 1];
                        encountersLongest = encounters;
                    }
                }
            }

            for (int i = 0; i < encountersLongest; i ++)
            {
                Console.Write(encountersLongestElement + " ");
            }

            Console.WriteLine("Dear user, we will refer you back to the initial screen." +
                "\nThank you for choosing number 10!");

            Methods.executionMethod();
        }
    }
}
