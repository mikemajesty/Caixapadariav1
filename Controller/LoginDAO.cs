using Model;
using System;
using System.Data;

namespace Controller
{
    public class LoginDAO:Conection
    {
        public Login SelectILinhaPorNome(string Nome)
        {
            try
            {
                Login log = new Login();
                LimparParametros();
                AdicionaParametro("@Nome",Nome);
                DataRow Linha = ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectLoginPorNome]").Rows[0];
                if (Linha != null)
                {
                    log.Id = Convert.ToInt32(Linha["ID"]);
                    log.Nome = Linha["Nome"].ToString();
                    log.Permissao = Linha["Permicao"].ToString();
                    log.Senha = Linha["Senha"].ToString();
                }
                return log;
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool UpdateUsuario(Login login)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", login.Id);
                AdicionaParametro("@Nome", login.Nome);
                AdicionaParametro("@Senha", login.Senha);
                AdicionaParametro("@Permissao",login.Permissao.ToUpper());
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspALterarUsuario]") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool DeleteLogin(int Id)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", Id);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspDeleteUsuario") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectLogin()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectFullUsuario");
               

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool InsertLogin(Login login)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", login.Nome);
                AdicionaParametro("@Senha", login.Senha);
                AdicionaParametro("@Permicao", login.Permissao.ToUpper());
                if ( ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspInsertLogin]") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {
                
                throw new  Exception(Erro.Message);
            }
        }
        public bool SelectLogin(Login login)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", login.Nome);
                AdicionaParametro("@Senha", login.Senha);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSelectLogin") != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectPermissaoPorUsuario(string Nome)
        {
            try
            {
               
               LimparParametros();
               AdicionaParametro("@Nome", Nome);               
               return ExecutaConsulta(CommandType.StoredProcedure,"_aspSelectPermissaoPorUsuario");
               
               
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
    }
}
