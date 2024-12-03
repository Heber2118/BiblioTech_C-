using BiblioTech.Control;
using BiblioTech.Models;
using Dao_Usuarios.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech.Models
{
    public class Adm
    {
        public int IdADM { get; private set; }
        public string Nome { get; set; }
        public string Email {  get; set; }
        public string Senha { get; set; }
        public string Cargo {  get; set; }

        public Adm(string nome, string email, string senha, string cargo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cargo = cargo;
        }
    }
}
