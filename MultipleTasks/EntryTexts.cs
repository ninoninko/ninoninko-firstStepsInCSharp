using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTasks
{
    /// <summary>
    /// The following class contains a total of 5
    /// methods. Each method contains the description
    /// of each of the 5 tasks
    /// </summary>
    internal class EntryTexts
    {
        public static void description6()
        {
            Console.WriteLine("Dear user, in the following program you are" +
                "\nasked to input two arrays of type in and the" +
                "\nprogram will tell you if they are one of the same thing.");
        }

        public static void description7()
        {

            Console.WriteLine("Dear user, program 7 will be a simple train program. " +
                "\nYou will input the number of cabins that the train has." +
                "\nThen you will input the number of passengers for each cabin.");

            Console.WriteLine("How many cabins does the train have?");
        }

        public static void description8()
        {
            Console.WriteLine("Dear user, in the following program we will be making a wheel." +
                "\nFor that matter we will ask you to input a string and the number of times" +
                "\nthat you will want it to be rotated." +
                "\n\nHow many time is the array going to be rotated");
        }

        public static void description9()
        {
            Console.WriteLine("Dear user, this will be a more interesting program." +
               "\nYou are asked to input an array of numbers and the program" +
               "\nwill return the index of the element the sums of the elements " +
               "\non its left and its right are equal." +
               "\n");
        }

        public static void description10()
        {
            Console.WriteLine("Dear user, in the following program you are asked" +
               "\nto input an array and the program will print the leftmost " +
               "\nlongest encounter of the same symbols. The arrays must be" +
               "\nstoring ONLY integer values");
        }
    }
}
