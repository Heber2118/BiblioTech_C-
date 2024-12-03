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
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_CadAluno frm_CadAluno = new Frm_CadAluno();
            this.Close();
            frm_CadAluno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_CadLivro frm_CadLivro = new Frm_CadLivro();
            frm_CadLivro.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_GrnAluno frm_GrnAluno = new Frm_GrnAluno();
            this.Close();
            frm_GrnAluno.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Frm_GrnLivro frm_GrnLivro = new Frm_GrnLivro();
            frm_GrnLivro.Show();
            this.Close();
        }
    }
}
