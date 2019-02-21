using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            int length = array.Length;

            string temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
