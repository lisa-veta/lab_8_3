using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace lab8_3
{
    class Programm
    {
        static void Main()
        {
            string[] array = { "code", "doce", "ecod", "framer", "frame" };
            List<string> list = new List<string>();

            Console.Write("Array before: ");

            foreach (string item in array)
            {
                list.Add(item);
                Console.Write($"{item} ");
            }

            for(int i =0; i < array.Length; i++)
            {
                char[] firstWord = array[i].ToCharArray();
                for(int j = i+1; j < array.Length; j++)
                {
                    char[] secondWord = array[j].ToCharArray();
                    if (EquivalenceCheck(firstWord, secondWord))
                        list.Remove(array[j]);
                }
            }
            
            Console.Write($"\nArray after: {String.Join(" ", list)}");
        }

        static bool EquivalenceCheck(char[] firstWord, char[] secondWord)
        {
            if (firstWord.Length != secondWord.Length)
                return false;

            char[] newWord = new char[firstWord.Length];
            for(int i = 0; i < firstWord.Length; i++)
            {
                for(int j = 0; j < secondWord.Length; j++)
                {
                    if (firstWord[i] == secondWord[j])
                        newWord[i] = secondWord[j];
                }
            }
            for(int i = 0; i < newWord.Length; i++)
            {
                if (newWord[i] == firstWord[i])
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}