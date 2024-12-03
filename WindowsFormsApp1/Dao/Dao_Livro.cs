using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Dao
{
    internal class Dao_Livro
    {
        private string conexaoString = "Server=localhost;Database=bibliotech_api;User=root;Password=MySQL1234;Pooling=true;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(conexaoString);
        }

        public bool CriaLivro(string titulo, string autor, string genero, int estoque)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO livro (Titulo, Autor, Genero, Estoque) VALUES (@Titulo, @Autor, @Genero, @Estoque)";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@Titulo", titulo);
                    comando.Parameters.AddWithValue("@Autor", autor);
                    comando.Parameters.AddWithValue("@Genero", genero);
                    comando.Parameters.AddWithValue("@Estoque", estoque);                   

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Livro cadastrado com sucesso!");
                        return true; // Indica que o cadastro foi bem-sucedido
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
                        return false; // Indica que houve um erro
                    }
                }
            }
        }

        public bool DeletaLivro(string idLivro)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "DELETE FROM Livro WHERE IdLivro = @IdLivro"; // A query já está correta

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    // Corrigido para passar o parâmetro corretamente
                    comando.Parameters.AddWithValue("@IdLivro", idLivro); // Usando @IdLivro com o parâmetro correto

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Livro deletado com sucesso!");
                        return true; // Retorna true quando o livro for deletado com sucesso
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar livro: " + ex.Message);
                        return false; // Retorna false em caso de erro
                    }
                }
            }
        }

        public Livro BuscaLivro(string titulo)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Livro WHERE Titulo = @Titulo";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@Titulo", titulo);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Recupera os dados do livro
                                int idLivro = reader.GetInt32("IdLivro");
                                string tituloLivro = reader.GetString("Titulo");
                                string autor = reader.GetString("Autor");
                                string genero = reader.GetString("Genero");
                                int estoque = reader.GetInt32("Estoque");

                                // Retorna o objeto Livro
                                return new Livro(titulo, autor, genero, estoque);
                            }
                            else
                            {
                                return null; // Livro não encontrado
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao buscar livro: " + ex.Message);
                    }
                }
            }
        }

        public void AtualizarLivro(Livro livro)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "UPDATE Livro SET Titulo = @Titulo, Autor = @Autor, Genero = @Genero, Estoque = @Estoque WHERE Titulo = @Titulo";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@IdLivro", livro.IdLivro);
                    comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                    comando.Parameters.AddWithValue("@Autor", livro.Autor);
                    comando.Parameters.AddWithValue("@Genero", livro.Genero);
                    comando.Parameters.AddWithValue("@Estoque", livro.Estoque);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao atualizar livro: " + ex.Message);
                    }
                }
            }
        }

    }
}
