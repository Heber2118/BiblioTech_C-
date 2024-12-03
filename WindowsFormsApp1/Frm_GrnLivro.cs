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
using WindowsFormsApp1.Control;
using WindowsFormsApp1.Dao;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Frm_GrnLivro : Form
    {
        public Frm_GrnLivro()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string titulo = txt_pesquisar.Text; // Campo de texto onde o título é inserido.

            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("Por favor, insira um título para pesquisar.");
                return;
            }

            // Instanciando o controlador Ctrl_Livro
            Ctrl_Livro ctrl_Livro = new Ctrl_Livro();
            Livro livro = ctrl_Livro.BuscaLivro(titulo); // Chama o método BuscarLivro do controlador

            if (livro != null)
            {
                // Formata as informações do livro em uma string para exibição
                string resultado = $"IdLivro: {livro.IdLivro}\nTitulo: {livro.Titulo}\nAutor: {livro.Autor}\nGenero: {livro.Genero}\nEstoque: {livro.Estoque}";

                // Exibe o resultado formatado no lbl_Result
                lbl_Result.Text = resultado;
            }
            else
            {
                MessageBox.Show("Livro não encontrado.");
            }
        }


        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_pesquisar.Text))
            {
                MessageBox.Show("Por favor, insira o ID do livro.");
                return;
            }

            // Obtém o ID do livro como string
            string idLivro = txt_pesquisar.Text;

            // Instanciando o controlador Ctrl_Livro
            Ctrl_Livro ctrl_Livro = new Ctrl_Livro();

            // Chama o método DeletaLivro para excluir o livro pelo ID
            ctrl_Livro.DeletaLivro(idLivro);

            // Limpa o campo de pesquisa após a exclusão
            txt_pesquisar.Clear();
        }


        private void button_voltar_Click(object sender, EventArgs e)
        {
            Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
            frm_Dashboard.Show();
            this.Close();
        }

        private void btn_AtualizarCadastro_Click(object sender, EventArgs e)
        {
            string titulo = txt_pesquisar.Text;

            Dao_Livro dao_Livro = new Dao_Livro();
            Livro livro = dao_Livro.BuscaLivro(titulo); // Busca o aluno

            if (livro != null)
            {
                // Abre o formulário de edição
                Frm_EditarLivro frm_EditarLivro = new Frm_EditarLivro(livro);
                frm_EditarLivro.ShowDialog();

                // Após a edição, você pode atualizar a label de resultado, caso necessário
                lbl_Result.Text = $"IdLivro: {livro.IdLivro}\nTitulo: {livro.Titulo}\nAutor: {livro.Autor}\nGenero: {livro.Genero}\nEstoque: {livro.Estoque}";
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
            }
        }
    }
}


