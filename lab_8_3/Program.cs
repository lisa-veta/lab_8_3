using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace lab8_3
{
    class Programm
    {
        static void Main()
        {
            string[] array = { "code", "doce", "ecod", "framer", "frame", "frmae" };
            List<string> list = new List<string>();

            Console.Write("Array before: ");

            foreach (string item in array)
            {
                list.Add(item);
                Console.Write($"{item} ");
            }

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (EquivalenceCheck(array[i], array[j]))
                        list.Remove(array[j]);
                }
            }
            
            Console.Write($"\nArray after: {String.Join(" ", list)}");
        }

        static bool EquivalenceCheck(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
                return false;

            char[] arrFirst = firstWord.ToCharArray();
            char[] arrSecond = secondWord.ToCharArray();

            char[] newWord = new char[arrFirst.Length];
            for (int i = 0; i < arrFirst.Length; i++)
            {
                for (int j = 0; j < arrSecond.Length; j++)
                {
                    if (arrFirst[i] == arrSecond[j])
                        newWord[i] = arrSecond[j];
                }
            }

            for (int i = 0; i < newWord.Length; i++)
            {
                if (newWord[i] == arrFirst[i])
                    continue;
                else
                    return false;
            }
            return true;

            //Позже я поняла что можно сделать проще используя встроенные функции:
            //char[] arrFirst = firstWord.ToCharArray();
            //char[] arrSecond = secondWord.ToCharArray();

            //Array.Sort(arrFirst);
            //Array.Sort(arrSecond);
            //return arrSecond.SequenceEqual(arrFirst);
        }
    }
}