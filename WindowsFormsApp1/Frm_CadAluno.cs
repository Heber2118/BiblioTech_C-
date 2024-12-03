using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dao;
using WindowsFormsApp1.Model;
using WindowsFormsApp1;
using BiblioTech.Control;

namespace WindowsFormsApp1
{
    public partial class Frm_CadAluno : Form
    {
        public Frm_CadAluno()
        {
            InitializeComponent();
        }

        private void lbl_Ra_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Dashboard frm_GerenciarAluno = new Frm_Dashboard();
            frm_GerenciarAluno.Show();
            this.Close();

        }

        private void btn_CadAluno_Click(object sender, EventArgs e)
        {
            string ra = txt_Ra.Text;
            string nome = txt_NomeAluno.Text;
            string email = txt_Email.Text;
            string senha = txt_Senha.Text;
            string curso = txt_Curso.Text;

            // Instanciando a classe de controle
            Ctrl_Aluno ctrl_Aluno = new Ctrl_Aluno();

            // Chamando o método de cadastro na camada de controle
            if (ctrl_Aluno.CriarAluno(ra, nome, email, senha, curso))
            {
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar aluno.");
            }
        }


        private void txt_Ra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
