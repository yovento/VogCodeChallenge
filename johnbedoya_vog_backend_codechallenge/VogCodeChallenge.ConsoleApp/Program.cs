using System;
using System.Collections.Generic;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = QuestionClass.NamesList;

            PrintUsingEnumerator(namesList);
            PrintUsingWhile(namesList);
        }

        private static void PrintSeparator()
        {
            Console.WriteLine("_____________________________________");
        }

        private static void PrintUsingWhile(List<string> namesList)
        {
            PrintSeparator();
            Console.WriteLine("Printed using while loop");
            PrintSeparator();

            var counter = 0;

            while (counter < namesList.Count)
            {
                Console.WriteLine(namesList[counter]);
                counter++;
            }
        }

        private static void PrintUsingEnumerator(List<string> namesList)
        {
            PrintSeparator();
            Console.WriteLine("Printed using enumerator");
            PrintSeparator();

            var enumerator = namesList.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current.ToString());
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }
    }
}
