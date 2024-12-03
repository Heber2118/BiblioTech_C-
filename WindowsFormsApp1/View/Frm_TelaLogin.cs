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
    public partial class Frm_TelaLogin : Form
    {
        public Frm_TelaLogin()
        {
            InitializeComponent();
        }

        private void Frm_TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();
            this.Close();
            frm_TelaInicial.Show();            
        }

        private void txt_RA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txt_RA.Text;
            string senha = txt_Senha.Text;

            Dao_Usuario dao = new Dao_Usuario();
            dao.FazLogin(id, senha);
        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
