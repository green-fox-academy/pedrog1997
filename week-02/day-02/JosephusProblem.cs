using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people will be in the Jsephus Problem?");
            int numPeople = int.Parse(Console.ReadLine());
            var listPeople = new List<int>();
            for (int i = 0; i < numPeople; i++)
            {
                listPeople.Add(i);
            }

            while (listPeople.Count > 1)
            {
                if (listPeople.Count % 2 == 0)
                {
                    for (int i = 0; i < numPeople/2; i++)
                    {
                        listPeople.RemoveAt(i + 1);
                        if (i + 1 >= listPeople.Count)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < numPeople/2; i++)
                    {
                        listPeople.RemoveAt(i+1);
                        if (i+1 >= listPeople.Count)
                        {
                            break;
                        }
                    }
                    listPeople.RemoveAt(0);
                }
                numPeople = listPeople.Count;
            }
            Console.WriteLine(Convert.ToString(listPeople[0] + 1));
            Console.Read();
        }
    }
}