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
            Console.Write("Write the number of words you want to enter: ");
            int numberOfWords = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            System.Collections.SortedList sList = new System.Collections.SortedList();

            for (int i = 0; i < numberOfWords; i++)
            {
                Console.WriteLine("Word number: {0}",i +1);
                Console.Write("Enter the word: ");
                string word = Console.ReadLine();

                Console.Write("Enter the meaning of the {0}:", word);
                string meaningWord = Console.ReadLine();

                sList.Add(word, meaningWord) ;
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
