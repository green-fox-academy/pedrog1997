using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            Console.WriteLine(Unique(new int[] { 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`
            Console.Read();
        }
        static string Unique(int[] array)
        {
            var positionToEliminate = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        positionToEliminate.Add(j);
                    }
                }
            }
            int k = 0;
            int[] printArray = new int[array.Length - positionToEliminate.Count];
            for (int i = 0; i < array.Length; i++)
            {
                if (positionToEliminate.Contains(i))
                {

                }
                else
                {
                    printArray[k] = array[i];
                    k++;
                }
            }
            string valueReturn = "";
            for (int i = 0; i < printArray.Length; i++)
            {
                valueReturn += printArray[i] + ", ";
            }
            valueReturn = valueReturn.Remove(valueReturn.Length - 2);
            valueReturn += ".";
            return valueReturn;
        } 
    }
}