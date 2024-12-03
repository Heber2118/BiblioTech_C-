using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTech.Control;
using BiblioTech.Models;
using Dao_Usuarios.Dao;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            string email = txt_RA.Text;
            string senha = txt_Senha.Text;

            // Instanciando a classe de controle
            Ctrl_ADM ctrl_ADM = new Ctrl_ADM();

            // Chamando o método de login na camada de controle
            if (ctrl_ADM.RealizarLogin(email, senha))
            {
                Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
                frm_Dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Id_Click(object sender, EventArgs e)
        {

        }
    }
}
