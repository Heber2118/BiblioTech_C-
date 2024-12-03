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
    public partial class Frm_TelaInicial : Form
    {
        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {          
            Frm_TelaLogin frm_TelaLogin = new Frm_TelaLogin();
            frm_TelaLogin.Show();
            this.Hide();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_TelaCadastro frm_TelaCadastro = new Frm_TelaCadastro();
            frm_TelaCadastro.Show();
            this.Hide();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
