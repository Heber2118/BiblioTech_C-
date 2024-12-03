using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Mozilla;

namespace WindowsFormsApp1.Model
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Estoque { get; set; }


        public Livro(string titulo, string autor, string genero, int estoque)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Estoque = estoque;
        }

        public Livro() { }
    }
}

