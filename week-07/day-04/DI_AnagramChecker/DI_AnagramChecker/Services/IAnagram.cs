using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_AnagramChecker.Services
{
    public interface IAnagram
    {
        string Word1 { get; set; }
        string Word2 { get; set; }

        bool IsAnagram();
    }
}
