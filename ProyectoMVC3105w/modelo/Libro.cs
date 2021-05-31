using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC3105w.modelo
{
    public class Libro
    {
        public string Titulo {set; get;}
        public string Autor {set; get;}

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Libro()
        {
        }
    }
}
