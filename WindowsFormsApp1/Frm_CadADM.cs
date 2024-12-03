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
    public partial class Frm_CadADM : Form
    {
        public Frm_CadADM()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();
            this.Close();
            frm_TelaInicial.Show();
        }

        private void btn_CadADM_Click(object sender, EventArgs e)
        {
            // Criação do objeto Adm com base nos dados fornecidos pelo usuário na interface
            Adm adm = new Adm(
                txt_nomeADM.Text,
                txt_emailADM.Text,
                txt_senhaADM.Text,
                txt_cargo.Text
            );

            // Instância da camada Control
            Ctrl_ADM ctrl_ADM = new Ctrl_ADM();

            // Chamando o método de cadastro na camada Control
            if (ctrl_ADM.CriarUsuario(adm.Nome, adm.Email, adm.Senha, adm.Cargo)) // Alterei para CriarUsuario
            {
                MessageBox.Show("Cadastro realizado com sucesso!");

                // Limpar os campos após o cadastro bem-sucedido
                txt_nomeADM.Clear();
                txt_emailADM.Clear();
                txt_senhaADM.Clear();
                txt_cargo.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o usuário. Tente novamente.");
            }
        }

    }
}
