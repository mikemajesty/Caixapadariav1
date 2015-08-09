using Model;
using System;
using System.Data;

namespace Controller
{
    public class CategoriaDAO : Conection
    {
        public DataTable SelectcategoriaPorId(int ID)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@ID",ID);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectFullCategoriaPorID]");
            }
            catch (Exception Erro)
            {                
                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectCategoriaFull()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectFullCategoria]");
          
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
        public int selectCategoriaNomePorId(string nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", nome);
                DataRow Linha = ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectNomeCategoriaPorID]").Rows[0];
                if (Linha != null)
                {
                    return Convert.ToInt32(Linha["ID"]);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
        public bool InsertCategoria(Categoria Categoria)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", Categoria.Nome);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspInsertCategoria]")) != null)
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
        public bool DeleteCategoria(int ID)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id",ID);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspDeleteCategoria]")) != null)
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
        public bool UpdateCategoria(Categoria Categoria)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id",Categoria.Id);
                AdicionaParametro("@Nome",Categoria.Nome);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspAlterarCategoria]")) != null)
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
        public DataTable selectCategoriaFullPorNome(string categoria)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome",categoria);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectFullCategoriaPorNome]");
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
       
       
    }
}
