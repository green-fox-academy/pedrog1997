using DI_AnagramChecker.Services;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DI_AnagramChecker.Models
{
    public class AnagramChecker : IAnagram
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public bool IsAnagram()
        {
            IOrderedEnumerable<char> in1 = Word1.ToLower().ToCharArray().OrderBy(c => c);
            string st1 = string.Join("", in1);
            IOrderedEnumerable<char> in2 = Word2.ToLower().ToCharArray().OrderBy(c => c);
            string st2 = string.Join("", in2);
            return st1.Equals(st2);
        }
    }
}
