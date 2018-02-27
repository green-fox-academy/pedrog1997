using System;
using System.IO;
using System.Linq;

namespace _08_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in UniqueIPAdresses("log.txt"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The GET/POST ratio is " + GetPostRatio("log.txt"));

            Console.Read();
        }

        static string[] UniqueIPAdresses(string fileName)
        {
            string[] arrayLogs = File.ReadAllLines(fileName);
            string[] ipAdresses = new string[arrayLogs.Length];

            for (int i = 0; i < ipAdresses.Length; i++)
            {
                ipAdresses[i] = arrayLogs[i].Substring(27, 11);
            }

            string[] uniqueIpAdresses = ipAdresses.Distinct().ToArray();
            return uniqueIpAdresses;
        }

        static double GetPostRatio(string fileName)
        {
            string[] arrayLogs = File.ReadAllLines(fileName);
            string[] methodsGetPost = new string[arrayLogs.Length];

            for (int i = 0; i < methodsGetPost.Length; i++)
            {
                methodsGetPost[i] = arrayLogs[i].Substring(41, 4);
            }

            double numberOfGets = 0;
            double numberOfPosts = 0;

            for (int i = 0; i < methodsGetPost.Length; i++)
            {
                if (methodsGetPost[i] == "GET ")
                {
                    numberOfGets += 1;
                }
                else
                {
                    numberOfPosts += 1;
                }
            }

            double ratio = numberOfGets / numberOfPosts;
            return ratio;
        }
    }
}
