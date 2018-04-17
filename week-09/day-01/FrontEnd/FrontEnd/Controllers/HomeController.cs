using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;
using FrontEnd.Models.Arrayhandler;

namespace FrontEnd.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("/")]    
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
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


    }
}