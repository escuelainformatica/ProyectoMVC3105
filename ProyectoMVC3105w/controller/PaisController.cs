using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC3105w.controller
{
    public class PaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
