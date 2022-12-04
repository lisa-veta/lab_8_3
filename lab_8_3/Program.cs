using System;
using System.Collections.Immutable;

namespace lab8_3
{
    class Programm
    {
        static void Main()
        {
            string[] array = { "code", "doce", "ecod", "framer", "frame" };
            List<string> list = new List<string>();

            foreach (string item in array)
                list.Add(item);

            for(int i =0; i < array.Length; i++)
            {
                char[] arr1 = array[i].ToCharArray();
                string str = "";
                for(int j = i+1; j < array.Length; j++)
                {
                    char[] arr2 = array[j].ToCharArray();
                    if (EquivalenceCheck(arr1, arr2))
                        list.Remove(array[j]);
                }
            }
            
        }
        static bool EquivalenceCheck(char[] arr1, char[] arr2)
        {
            bool fl = false;

        }
    }
}