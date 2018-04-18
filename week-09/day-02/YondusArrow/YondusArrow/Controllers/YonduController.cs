using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YondusArrow.Models;

namespace YondusArrow.Controllers
{
    public class YonduController : Controller
    {
        [HttpGet("/yondu")]
        public IActionResult Yondu([FromQuery]int? distance, [FromQuery]int? time)
        {
            if (distance == null || time == null)
            {
                var error = new ErrorMessage
                {
                    Error = "Please provide the complete data!"
                };
                return BadRequest(error);
            }
            else
            {
                var arrowSpeed = new ArrowSpeed
                {
                    Distance = distance,
                    Time = time
                };
                return Json(arrowSpeed);
                //return new JsonResult(arrowSpeed);
            }
        }
    }
}