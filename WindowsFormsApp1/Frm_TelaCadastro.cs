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

namespace WindowsFormsApp1
{
    public partial class Frm_TelaCadastro : Form
    {
        public Frm_TelaCadastro()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();
            frm_TelaInicial.Show();
            this.Close();
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_Nome.Text;
            string email = txt_Email.Text;
            string senha = txt_Senha.Text;
            string cargo = txt_Id.Text;            

            Dao_ADM daoUsuario = new Dao_ADM();
            int id = 0; 

            daoUsuario.CriaUsuario(nome, email, senha, cargo);

            txt_Nome.Clear();
            txt_Email.Clear();
            txt_Senha.Clear();
            txt_Id.Clear();

        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Nome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Senha_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
