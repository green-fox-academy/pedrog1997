using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;
using FrontEnd.Models.Arrayhandler;
using FrontEnd.Models.LogEntries;
using FrontEnd.Database;
using FrontEnd.Models.Sith;

namespace FrontEnd.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private LogContext logDb;

        public HomeController(LogContext logDb)
        {
            this.logDb = logDb;
        }

        [Route("/")]    
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
            var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/doubling",
                Data = $"input={input}"
            };
            logDb.Logs.Add(log);
            logDb.SaveChanges();

            if (input == null)
            {
                var error = new ErrorDoubling()
                {
                    Error = "Please provide an input!"
                };
                return Json(error);
            }
            else
            {
                Models.Double doubling = new Models.Double
                {
                    Received = input,
                    Result = input * 2
                };
                return Json(doubling);
            }
        }

        [HttpGet("/Greeter")]
        public IActionResult Greeter([FromQuery]string name, [FromQuery]string title)
        {
            var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/Greeter",
                Data = $"name={name}&title={title}"
            };
            logDb.Logs.Add(log);
            logDb.SaveChanges();

            if (name == null)
            {
                var error = new ErrorDoubling
                {
                    Error = "Please provide a name!"
                };
                return Json(error);
            }
            else if (title == null)
            {
                var error = new ErrorDoubling
                {
                    Error = "Please provide a title!"
                };
                return Json(error);
            }
            else
            {
                var greeter = new Greeter
                {
                    Welcome_message = $"Oh, hi there {name}, my dear {title}!"
                };
                return Json(greeter);
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = $"/appenda/{appendable}",
                Data = $"appendable={appendable}"
            };
            logDb.Logs.Add(log);
            logDb.SaveChanges();

            if (appendable == null)
            {
                return NotFound();
            }
            else
            {
                var append = new Append
                {
                    Appended = appendable + "a"
                };
                return Json(append);
            }
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]DoUntilBody body)
        {
            var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = $"/dountil/{what}",
                Data = $"what={what}&until={body.Until}"
            };
            logDb.Logs.Add(log);
            logDb.SaveChanges();

            if (what == "sum" && body.Until != null)
            {
                int result = 0;
                for (int i = 0; i <= body.Until; i++)
                {
                    result += i;
                }
                var dountil = new DoUntilResult
                {
                    Result = result
                };
                return Json(dountil);
            }
            else if (what == "factor" && body.Until != null)
            {
                int result = 1;
                for (int i = 1; i <= body.Until; i++)
                {
                    result *= i;
                }
                var dountil = new DoUntilResult
                {
                    Result = result
                };
                return Json(dountil);
            }
            else
            {
                var error = new ErrorDoubling
                {
                    Error = "Please provide a number!"
                };
                return Json(error);     
            }
        }

        [HttpPost("/arrays")]
        public IActionResult Array([FromBody]Arrays array)
        {
            var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/arrays",
                Data = $"input={array.ToString()}"
            };
            logDb.Logs.Add(log);
            logDb.SaveChanges();

            if (array.Numbers == null)
            {
                return Json(new ErrorDoubling { Error = "Please provide what to do with the numbers!" });
            }
            if (array.What == "sum")
            {
                int result = 0;
                for (int i = 0; i < array.Numbers.Count(); i++)
                {
                    result += array.Numbers[i];
                }
                return Json(new { Result = result });
            }
            else if (array.What == "multiply")
            {
                int result = 1;
                for (int i = 0; i < array.Numbers.Count(); i++)
                {
                    result *= array.Numbers[i];
                }
                return Json(new { Result = result });
            }
            else if (array.What == "double")
            {
                int[] result = new int[array.Numbers.Count()];
                for (int i = 0; i < array.Numbers.Count(); i++)
                {
                    result[i] = array.Numbers[i] * 2;
                }
                var arrayResponse = new ArrayResponse
                {
                    Result = result
                };
                return Json(arrayResponse);
            }
            return BadRequest();
            }

        [HttpGet("/log")]
        public IActionResult Log()
        {
            var response = new LogResponse
            {
                Logs = logDb.Logs.ToList(),
                EntryCount = logDb.Logs.ToList().Count()
            };
            return Json(response);
        }

        [HttpPost("/sith")]
        public IActionResult Sith([FromBody]SithRequest request)
        {
            var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/sith",
                Data = $"text={request}"
            };
            logDb.Logs.Add(log);
            logDb.SaveChanges();

            //string[] sentences = request.Text.Split('.');
            //string[][] words = new string[sentences.Length][];

            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    words[i] = sentences[i].Split(' ');
            //}

            //string[][] yodaWords = new string[sentences.Length][];

            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    for (int j = 0; j < words[i].Length; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            yodaWords[i][j] = (j + 1 >= words[i].Length) ? words[i][j] : words[i][j + 1];
            //        }
            //        else
            //        {
            //            yodaWords[i][j] = words[i][j - 1];
            //        }
            //    }
            //}

            //string[] yodaWordsJoined = new string[sentences.Length];
            //for (int i = 0; i < yodaWordsJoined.Length; i++)
            //{
            //    yodaWordsJoined[i] = string.Join(' ', yodaWords[i]);
            //}

            //var response = new SithResponse
            //{
            //    Sith_text = string.Join('.', yodaWordsJoined)
            //};

            string[] words = request.Text.Split(' ');
            string[] yodaWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yodaWords[i] = (i + 1 >= words.Length) ? words[i] : words[i + 1];
                }
                else
                {
                    yodaWords[i] = words[i - 1];
                }
            }

            var response = new SithResponse
            {
                Sith_text = string.Join(' ', yodaWords)
            };

            return Json(response);
        }
    }
}