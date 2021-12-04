using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    internal class Task7
    {
        public static void goToProgram7()
        {

            Console.WriteLine("Dear user, program 7 will be a simple train program. " +
                "\nYou will input the number of cabins that the train has." +
                "\nThen you will input the number of passengers for each cabin.");

            Console.WriteLine("How many cabins does the train have?");

            int numberCabins = Methods.getNumber();

            int[] passengers = new int[numberCabins];
            int totalPassengers = 0;

            for (int i = 0; i < passengers.Length; i++)
            {
                Console.WriteLine("How many passengers are there in the " + (i + 1) + " cabin?");
                passengers[i] = Methods.getNumber();
                totalPassengers = totalPassengers + passengers[i];
            }

            Console.Write("This is how the train looks like: ");
            for (int i = 0; i < passengers.Length; i++)
            {
                Console.Write(passengers[i] + " ");
            }
            Console.WriteLine("\nThis is the total number of passengers: " + totalPassengers);


            Console.WriteLine("Dear user, we will refer you back to the initial screen." +
                "\nThank you for choosing number 7!");

            Methods.executionMethod();
            
        }

    }
}
