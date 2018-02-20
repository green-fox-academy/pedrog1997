using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending

            //  Example:
            Console.WriteLine(Bubble(new int[] { 34, 12, 24, 9, 5 }));
            //  should print [5, 9, 12, 24, 34]
            Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]

            Console.Read();
        }

        static string Bubble(int[] array)
        {
            string orderedArray = string.Empty;
            int swap;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swap = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swap;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                orderedArray += array[i] + ", ";
            }
            orderedArray = orderedArray.Remove(orderedArray.Length - 2);
            return orderedArray;
        }

        static string AdvancedBubble(int[] array, bool orderChoose)
        {
            string orderedArray = string.Empty;
            int swap;

            if (orderChoose)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            swap = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = swap;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    orderedArray += array[i] + ", ";
                }
            }
            else
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            swap = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = swap;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    orderedArray += array[i] + ", ";
                }
            }
            orderedArray = orderedArray.Remove(orderedArray.Length - 2);
            return orderedArray;
        }
    }
}