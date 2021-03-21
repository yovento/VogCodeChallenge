using System;
using System.Collections.Generic;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = QuestionClass.NamesList;

            Console.WriteLine("Step_7");

            PrintSeparator();
            PrintUsingEnumerator(namesList);
            PrintUsingWhile(namesList);

            PrintSeparator();
            Console.WriteLine("Step_8");
            PrintSeparator();

            Console.WriteLine(TESTModule(1));
            Console.WriteLine(TESTModule(2));
            Console.WriteLine(TESTModule(3));
            Console.WriteLine(TESTModule(4));
            Console.WriteLine(TESTModule(5));
            Console.WriteLine(TESTModule(1.0f));
            Console.WriteLine(TESTModule(2.0f));
            Console.WriteLine(TESTModule("hello world"));
            Console.WriteLine(TESTModule(new List<string>()));

            try
            {
                Console.WriteLine(TESTModule(0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        #region Step_7
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
        #endregion

        #region Step_8
        private static object TESTModule(object value)
        {
            switch (value)
            {
                case int n when (n > 4):
                    return n * 3;
                case int n when (n < 1):
                    throw new ArgumentOutOfRangeException("Value can't be less than 1");
                case string s:
                    return s.ToUpper();
                case int n when (n >= 1 && n <= 4):
                    return n * 2;
                case float n when (n >= 1.0f && n <= 2.0f):
                    return 3.0f;
                default:
                    return value;
            }
        }
        #endregion
    }
}
