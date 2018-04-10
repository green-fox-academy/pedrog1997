using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListToDos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        [Route("list")]
        public IActionResult List()
        {
            return View("List");
        }
    }
}