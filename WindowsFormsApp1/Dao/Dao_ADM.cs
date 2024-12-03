using BiblioTech.Control;
using BiblioTech.Models;
using Dao_Usuarios.Dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dao_Usuarios.Dao
{
    internal class Dao_ADM
    {
        private string conexaoString = "Server=localhost;Database=bibliotech_api;User=root;Password=MySQL1234;Pooling=true;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(conexaoString);
        }


        public bool CriaUsuario(string nome, string email, string senha, string cargo)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO ADM (Nome, Email, Senha, Cargo) VALUES (@Nome, @Email, @Senha, @Cargo)";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Senha", senha);
                    comando.Parameters.AddWithValue("@Cargo", cargo);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        return true; // Indica que o cadastro foi bem-sucedido
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                        return false; // Indica que houve um erro
                    }
                }
            }
        }

        public bool FazLogin(string email, string senha)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string queryUsuario = "SELECT * FROM ADM WHERE Email = @Email AND Senha = @Senha";

                using (MySqlCommand comando = new MySqlCommand(queryUsuario, connection))
                {
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        connection.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            return reader.Read(); // Retorna true se encontrar o registro
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar realizar login: " + ex.Message);
                        return false; // Erro na consulta ou conexão
                    }
                }
            }
        }
    }
}
