using BiblioTech.Control;
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

namespace WindowsFormsApp1
{
    public partial class Frm_EditarAluno : Form
    {
        private Aluno aluno;

        public Frm_EditarAluno(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;

            // Preenche os campos com os dados do aluno
            txt_NomeAluno.Text = aluno.Nome;
            txt_EmailAluno.Text = aluno.Email;
            txt_Curso.Text = aluno.Curso;
            txt_SenhaAluno.Text = aluno.Senha;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Atualiza os dados do aluno com os novos valores
            aluno.Nome = txt_NomeAluno.Text;
            aluno.Email = txt_EmailAluno.Text;
            aluno.Curso = txt_Curso.Text;
            aluno.Senha = txt_SenhaAluno.Text;

            // Chama o método para salvar as alterações no banco
            Dao_Aluno dao_Aluno = new Dao_Aluno();
            dao_Aluno.AtualizarAluno(aluno);

            // Fecha o formulário
            this.Close();
        }


        private void Frm_EditarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btn_EditCad_Click(object sender, EventArgs e)
        {
            // Verificar se o aluno existe e atualizar suas informações
            if (aluno != null)
            {
                aluno.Nome = txt_NomeAluno.Text;
                aluno.Email = txt_EmailAluno.Text;
                aluno.Curso = txt_Curso.Text;
                aluno.Senha = txt_SenhaAluno.Text;

                // Instanciando o controlador de aluno
                Ctrl_Aluno ctrl_Aluno = new Ctrl_Aluno();

                try
                {
                    // Chama o método para atualizar as informações do aluno
                    bool atualizado = ctrl_Aluno.AtualizarAluno(aluno);

                    if (atualizado)
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso!"); // Feedback positivo ao usuário
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar o cadastro."); // Caso a atualização falhe
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar cadastro: " + ex.Message); // Caso ocorra um erro
                }

                // Fecha o formulário de edição
                this.Close();
            }
            else
            {
                MessageBox.Show("Aluno não encontrado. Não foi possível realizar a atualização.");
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário de edição
            this.Close();
        }

    }
}
