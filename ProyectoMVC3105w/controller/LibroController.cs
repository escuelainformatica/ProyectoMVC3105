using Microsoft.AspNetCore.Mvc;
using ProyectoMVC3105w.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC3105w.controller
{
    public class LibroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listar()
        {
            List<string> libros=new List<string> {"Libro1","Libro2","Libro3"};
            libros.Add("Libro4");

            ViewBag.libros=libros;


            return View();
        }
        public IActionResult Mostrar()
        {
            ViewBag.libro="Harry Potter";
            ViewData["libro"]="Harry Potter";

            return View();
        }
        public IActionResult MostrarModelo()
        {
            Libro libro=new Libro("Harry Potter","Autor");
            ViewBag.libro=libro;

            return View();
        }

    }
}
