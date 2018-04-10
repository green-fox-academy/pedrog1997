using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListToDos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ListToDos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private Repository _repository;

        public TodoController(Repository repository)
        {
            _repository = repository;
        }

        [Route("list")]
        public IActionResult List()
        {
            return View("List");
        }
    }
}