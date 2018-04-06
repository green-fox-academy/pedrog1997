using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_AnagramChecker.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_AnagramChecker.Controllers
{
    [Route("/Anagram")]
    public class AnagramController : Controller
    {
        private IAnagram _anagramChecker;

        public AnagramController(IAnagram anagramChecker)
        {
            _anagramChecker = anagramChecker;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("check")]
        public IActionResult CheckAnagram(string word1, string word2)
        {
            _anagramChecker.Word1 = word1;
            _anagramChecker.Word2 = word2;
            return RedirectToAction("solution");
        }

        [HttpGet("solution")]
        public IActionResult Solution()
        {
            return View(_anagramChecker);
        }
    }
}