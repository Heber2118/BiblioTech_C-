using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Curso { get; set; }

    
    public Aluno(string ra, string nome, string email, string senha, string curso)
        {
            RA = ra;
            Nome = nome;
            Email = email;
            Senha = senha;
            Curso = curso;
        }

     }
}

