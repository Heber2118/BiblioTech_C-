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
    public partial class Frm_EditarLivro : Form
    {
        private Livro livro;

        public Frm_EditarLivro(Livro livro)
        {
            InitializeComponent();
            this.livro = livro;

            // Preenche os campos com os dados do livro
            txt_NovoTitulo.Text = livro.Titulo;
            txt_NovoAutor.Text = livro.Autor;
            txt_Gênero.Text = livro.Genero;
            nmr_Quantidade.Text = livro.Estoque.ToString();
        }

        
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EditCad_Click(object sender, EventArgs e)
        {
            // Criação do objeto Livro com os dados editados do formulário
            Livro livro = new Livro(
                txt_NovoTitulo.Text,
                txt_NovoAutor.Text,
                txt_Gênero.Text,
                int.Parse(nmr_Quantidade.Text)
            );

            // Instanciando o controlador Ctrl_Livro
            Ctrl_Livro ctrl_Livro = new Ctrl_Livro();

            // Chama o método AtualizarLivro do controlador para atualizar o livro
            try
            {
                ctrl_Livro.AtualizarLivro(livro); // Apenas chama o método sem esperar retorno
                MessageBox.Show("Livro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar livro: " + ex.Message);
            }

            // Fecha o formulário
            this.Close();
        }


    }
}
