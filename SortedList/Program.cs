using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numberOfWords;
            bool isValidInput = false;

            //Checks if the user input is a number.
            do
            {
                Console.Write("Write the number of words you want to enter: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numberOfWords))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input! Please enter a valid integer number.");
                }

            } while (!isValidInput);


            Console.Clear();

            System.Collections.SortedList sList = new System.Collections.SortedList();

            for (int i = 0; i < numberOfWords; i++)
            {
                Console.WriteLine("Word number: {0}", i + 1);
                Console.Write("Enter the word: ");
                string word = Console.ReadLine();

                //If a word is repeated as a key, a new word will be requested.
                if (sList.ContainsKey(word))
                {
                    i--;
                    Console.WriteLine("This word has already been entered!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }


                Console.Write("Enter the meaning of the {0}:", word);
                string meaningWord = Console.ReadLine();

                sList.Add(word, meaningWord);
                Console.Clear();
            }

            foreach (var VARIABLE in sList.Keys)
            {
                Console.WriteLine("{0}: {1}", VARIABLE, sList[VARIABLE]);
            }
            Console.ReadKey();
        }
    }
}
