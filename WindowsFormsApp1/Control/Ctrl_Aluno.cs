using BiblioTech.Models;
using Dao_Usuarios.Dao;
using System;
using WindowsFormsApp1.Dao;
using WindowsFormsApp1.Model;

namespace BiblioTech.Control
{
    public class Ctrl_Aluno
    {
        private readonly Dao_Aluno daoAluno;

        public Ctrl_Aluno()
        {
            daoAluno = new Dao_Aluno();
        }

        /// <summary>
        /// Realiza o cadastro de um novo aluno.
        /// </summary>
        /// <param name="ra">RA do aluno</param>
        /// <param name="nome">Nome do aluno</param>
        /// <param name="email">Email do aluno</param>
        /// <param name="senha">Senha do aluno</param>
        /// <param name="curso">Curso do aluno</param>
        /// <returns>True se o cadastro for bem-sucedido; False caso contrário</returns>
        public bool CriarAluno(string ra, string nome, string email, string senha, string curso)
        {
            try
            {
                return daoAluno.CriaAluno(ra, nome, email, senha, curso);
            }
            catch (Exception ex)
            {
                // Aqui você pode adicionar logs ou tratar a exceção de forma mais detalhada
                throw new Exception("Erro na camada de controle ao criar aluno.", ex);
            }
        }

        /// <summary>
        /// Realiza a exclusão de um aluno.
        /// </summary>
        /// <param name="ra">RA do aluno</param>
        /// <returns>True se a exclusão for bem-sucedida; False caso contrário</returns>
        public bool DeletarAluno(string ra)
        {
            try
            {
                return daoAluno.DeletaAluno(ra);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de controle ao excluir aluno.", ex);
            }
        }

        /// <summary>
        /// Busca um aluno pelo RA.
        /// </summary>
        /// <param name="ra">RA do aluno</param>
        /// <returns>O objeto Aluno correspondente ou null se não encontrado</returns>
        public Aluno BuscarAluno(string ra)
        {
            try
            {
                return daoAluno.BuscaAluno(ra);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de controle ao buscar aluno.", ex);
            }
        }

        /// <summary>
        /// Atualiza os dados de um aluno.
        /// </summary>
        /// <param name="aluno">Objeto Aluno com os dados atualizados</param>
        /// <returns>True se a atualização for bem-sucedida; False caso contrário</returns>
        public bool AtualizarAluno(Aluno aluno)
        {
            try
            {
                daoAluno.AtualizarAluno(aluno);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de controle ao atualizar aluno.", ex);
            }
        }
    }
}
