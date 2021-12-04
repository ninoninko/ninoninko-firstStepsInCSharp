using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Task9
    {
        public static void goToProgram9()
        {
            Console.WriteLine("Dear user, this will be a more interesting program." +
                "\nYou are asked to input an array of numbers and the program" +
                "\nwill return the index of the element the sums of the elements " +
                "\non its left and its right are equal." +
                "\n");

            double[] arrayAsIntegers = Methods.getArrayFromString();
            double sumLeft = 0;
            double sumRight = 0;
            int foundAtLocation = -1;


            for (int currentLocation = 0; currentLocation < arrayAsIntegers.Length; currentLocation ++)
            {
                for (int left = 0; left < currentLocation; left ++)
                {
                    sumLeft = sumLeft + arrayAsIntegers[left];
                }

                for (int right = currentLocation + 1; right < arrayAsIntegers.Length; right++)
                {
                    sumRight = sumRight + arrayAsIntegers[right];
                }

                if (sumLeft == sumRight)
                {
                    foundAtLocation = currentLocation;
                    break;
                }

                sumLeft = 0;
                sumRight = 0;

            }

            if (foundAtLocation == -1)
            {
                Console.WriteLine("No such case");
            } else
            {
                Console.WriteLine(foundAtLocation);
            }

            Console.WriteLine("Dear user, we will refer you back to the initial screen." +
                "\nThank you for choosing number 9!");

            Methods.executionMethod();
        }
    }
}
