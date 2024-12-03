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
    public partial class Frm_CadLivro : Form
    {
        public Frm_CadLivro()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
            this.Close();
            frm_Dashboard.Show();
        }

        private void btn_CadLivro_Click(object sender, EventArgs e)
        {
            // Criação do objeto Livro com os dados do formulário
            Livro livro = new Livro(
                txt_Título.Text,
                txt_Autor.Text,
                txt_Genero.Text,
                (int)nmr_Quantidade.Value
            );

            // Instanciando o controlador Ctrl_Livro
            Ctrl_Livro ctrl_Livro = new Ctrl_Livro();

            // Chama o método CriaLivro do controlador para cadastrar o livro
            ctrl_Livro.CriaLivro(livro.Titulo, livro.Autor, livro.Genero, livro.Estoque);

            // Limpeza dos campos após o cadastro bem-sucedido
            txt_Título.Clear();
            txt_Autor.Clear();
            txt_Genero.Clear();
            nmr_Quantidade.Value = 0;
        }

    }
}
