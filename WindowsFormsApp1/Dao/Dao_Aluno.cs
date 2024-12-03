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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Dao
{
    internal class Dao_Aluno
    {
        private string conexaoString = "Server=localhost;Database=bibliotech_api;User=root;Password=MySQL1234;Pooling=true;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(conexaoString);
        }

        public bool CriaAluno(string ra, string nome, string email, string senha, string curso)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO alunos (RA, Nome, Email, Senha, Curso) VALUES (@RA, @Nome, @Email, @Senha, @Cargo)";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@RA", ra);
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Senha", senha);
                    comando.Parameters.AddWithValue("@Cargo", curso);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool DeletaAluno(string ra)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "DELETE FROM Alunos WHERE RA = @RA";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("RA", ra);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário deletado com sucesso!");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar usuário: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Aluno BuscaAluno(string ra)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Alunos WHERE RA = @RA";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@RA", ra);

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string raAluno = reader.GetString("RA");
                                string nome = reader.GetString("Nome");
                                string email = reader.GetString("Email");
                                string curso = reader.GetString("Curso");

                                return new Aluno(raAluno, nome, email, null, curso);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao buscar aluno: " + ex.Message);
                    }
                }
            }
        }
        public void AtualizarAluno(Aluno aluno)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "UPDATE Alunos SET Nome = @Nome, Email = @Email, Curso = @Curso, Senha = @Senha WHERE RA = @RA";

                using (MySqlCommand comando = new MySqlCommand(query, connection))
                {
                    comando.Parameters.AddWithValue("@RA", aluno.RA);
                    comando.Parameters.AddWithValue("@Nome", aluno.Nome);
                    comando.Parameters.AddWithValue("@Email", aluno.Email);
                    comando.Parameters.AddWithValue("@Curso", aluno.Curso);
                    comando.Parameters.AddWithValue("Senha", aluno.Senha);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao atualizar cadastro: " + ex.Message);
                    }
                }
            }
        }


    }
}