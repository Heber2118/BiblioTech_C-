using System.Windows.Forms;
using System;
using WindowsFormsApp1.Dao;

public class LivroController
{
    private Dao_Livro daoLivro;

    public LivroController()
    {
        daoLivro = new Dao_Livro();
    }

    public string BuscarLivroPorTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
        {
            return "Título inválido. Por favor, insira um título.";
        }

        try
        {
            return daoLivro.BuscaLivro(titulo); // Interage com a DAO e retorna os resultados.
        }
        catch (Exception ex)
        {
            return $"Erro ao buscar livro: {ex.Message}";
        }
    }

    public bool DeletarLivroPorId(string idLivro)
    {
        if (string.IsNullOrWhiteSpace(idLivro))
        {
            MessageBox.Show("ID inválido. Por favor, insira um ID válido.");
            return false;
        }

        try
        {
            return daoLivro.DeletaLivro(idLivro); // Interage com a DAO e retorna o sucesso ou falha.
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao deletar livro: {ex.Message}");
            return false;
        }
    }
}
