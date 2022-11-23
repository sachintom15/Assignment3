using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class qstn3numofspace
    {
        public static void Main(string[] args)
        {
            string word = "hello guys how are you";
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    count++;
                }

            }

            Console.WriteLine("String is :" + word);
            Console.Write("No.of spaces = " + count);
            Console.ReadLine();
        }
    }
}
