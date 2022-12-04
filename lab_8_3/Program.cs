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
                char[] arr1 = array[i].ToCharArray();
                for(int j = i+1; j < array.Length; j++)
                {
                    char[] arr2 = array[j].ToCharArray();
                    if (EquivalenceCheck(arr1, arr2))
                        list.Remove(array[j]);
                }
            }
            
            Console.Write($"\nArray after: {String.Join(" ", list)}");
        }
        static bool EquivalenceCheck(char[] arr1, char[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            char[] arr = new char[arr1.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                        arr[i] = arr2[j];
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr1[i])
                    continue;
                else
                    return false;
            }
            return true;
            ///return string.Concat(s).Equals(string.Concat(m));
        }
    }
}