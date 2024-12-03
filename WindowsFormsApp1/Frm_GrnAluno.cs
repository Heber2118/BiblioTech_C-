using BiblioTech.Control;
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
using WindowsFormsApp1.Dao;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Frm_GrnAluno : Form
    {
        public Frm_GrnAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string ra = txt_pesquisar.Text; // Supondo que txt_pesquisar seja o campo de texto onde o usuário insere o RA

            // Instanciando o controlador de aluno
            Ctrl_Aluno ctrl_Aluno = new Ctrl_Aluno();

            try
            {
                // Busca o aluno através do controlador
                Aluno aluno = ctrl_Aluno.BuscarAluno(ra);

                if (aluno != null)
                {
                    // Exibe os dados do aluno como uma string formatada
                    string resultado = $"RA: {aluno.RA}\nNome: {aluno.Nome}\nEmail: {aluno.Email}\nCurso: {aluno.Curso}";
                    lbl_Result.Text = resultado; // Exibe o resultado na label
                }
                else
                {
                    lbl_Result.Text = "Aluno não encontrado."; // Caso o aluno não seja encontrado
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra uma exceção durante a busca
                lbl_Result.Text = "Erro ao realizar a busca: " + ex.Message;
            }
        }


        private void button_voltar_Click(object sender, EventArgs e)
        {
            Frm_Dashboard frm_dashboard = new Frm_Dashboard();
            frm_dashboard.Show();
            this.Close();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            string ra = txt_pesquisar.Text; // Campo de texto onde o usuário insere o RA do aluno que deseja excluir

            if (string.IsNullOrWhiteSpace(ra))
            {
                MessageBox.Show("Por favor, insira o RA do aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja excluir este aluno?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Dao_Aluno dao_Aluno = new Dao_Aluno(); // Criação da instância de Dao_Aluno
                    bool sucesso = dao_Aluno.DeletaAluno(ra); // Chama o método DeletaAluno

                    if (sucesso)
                    {
                        MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir aluno. Verifique se o RA está correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir o aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_AtualizarCadastro_Click(object sender, EventArgs e)
        {
            string ra = txt_pesquisar.Text;

            Dao_Aluno dao_Aluno = new Dao_Aluno();
            Aluno aluno = dao_Aluno.BuscaAluno(ra); // Busca o aluno

            if (aluno != null)
            {
                // Abre o formulário de edição
                Frm_EditarAluno frmEditar = new Frm_EditarAluno(aluno);
                frmEditar.ShowDialog();

                // Após a edição, você pode atualizar a label de resultado, caso necessário
                lbl_Result.Text = $"RA: {aluno.RA}\nNome: {aluno.Nome}\nEmail: {aluno.Email}\nCurso: {aluno.Curso}";
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
            }
        }
    }
}
