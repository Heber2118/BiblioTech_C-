using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models; // Importar o namespace das Models, se necessário
using Dao_Usuarios.Dao; // Importar o namespace do DAO

namespace BiblioTech.Control
{
    public class Ctrl_ADM
    {
        private readonly Dao_ADM daoADM;

        // Corrigir o nome para Ctrl_ADM (como está sendo chamado no código)
        public Ctrl_ADM()
        {
            daoADM = new Dao_ADM();
        }

        // Método de cadastro
        public bool CriarUsuario(string nome, string email, string senha, string cargo)
        {
            try
            {
                return daoADM.CriaUsuario(nome, email, senha, cargo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de controle ao criar usuário.", ex);
            }
        }

        public bool RealizarLogin(string email, string senha)
        {
            try
            {
                return daoADM.FazLogin(email, senha);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de controle ao realizar login.", ex);
            }
        }
    }
}