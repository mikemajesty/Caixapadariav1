using Model;
using System;
using System.Data;

namespace Controller
{
    public class EstoqueDAO : Conection
    {
        public bool updateEstoqueComCodigo(Estoque estoque)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Codigo",estoque.Codigo);
                AdicionaParametro("@Quantidade",Estoque.Quantidade);
                AdicionaParametro("@Operacao", estoque.Operacao);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_spAlterarEstoque]")) != null)
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
       
        public bool updateEstoqueComId(Estoque estoque)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", estoque.Codigo);
                AdicionaParametro("@Quantidade", Estoque.Quantidade);
                AdicionaParametro("@Operacao", estoque.Operacao);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspAlteraEstoquePorID]")) != null)
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
        public bool ExlcuiEstoqueAposSalvar(ExcluirEstoque estoque)
        {
            try
            {

                LimparParametros();
                AdicionaParametro("@Quantidade", estoque.Quantidade);
                AdicionaParametro("@IdProduto", estoque.Id);
                if ((ExecutaComando(CommandType.StoredProcedure, "_aspExCluirEstoque")) != null)
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
        public DataTable SelectEstoqueNegativo()
        {
            try
            {

                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectValoresNegativosNoEstoque]");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

        //public DataTable SelectEstoqueEmOutraTabela()
        //{
        //    try
        //    {

        //        LimparParametros();
        //        return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectEstoqueEmOutraTabela]");
        //    }
        //    catch (Exception Erro)
        //    {

        //        throw new Exception(Erro.Message);
        //    }
        //}
         
        
    }
}
