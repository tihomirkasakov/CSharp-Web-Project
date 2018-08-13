using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IMMDB.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}