using System;
using Model;
using System.Data;

namespace Controller
{
    public class ProdutoDAO : Conection
    {
        public bool SelectProdutoPorId(int ID, string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", ID);
                AdicionaParametro("@Peso", Peso);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSelectProdutoPorId") != null)
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

                throw new Exception(Erro.Message); ;
            }
        }
        public bool SelectProdutoPorCodigo(string Codigo, string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Codigo", Codigo);
                AdicionaParametro("@Peso", Peso);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspSelectProdutoPorCodigo") != null)
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
 
        public DataTable selectProdutoComIdECodigo(Produto produto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id",produto.Id);
                AdicionaParametro("@Codigo",produto.Codigo);
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectProdutoPorCodigoEPorId");

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public bool InsertProduto(Produto produto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@codigo", produto.Codigo);
                AdicionaParametro("@nome", produto.Nome);
                AdicionaParametro("@categoria", produto.Categoria);
                AdicionaParametro("@precocompra", produto.PrecoCompra);
                AdicionaParametro("@precovenda", produto.PrecoVenda);
                AdicionaParametro("@descricao", produto.Descricao);
                AdicionaParametro("@quantidade", produto.Quantidade);
                AdicionaParametro("@QtdMinimo", produto.QtdMinima);
                AdicionaParametro("@QtdMaximo", produto.QtdMaxima);
                AdicionaParametro("@Porcentagem",produto.Porcentagem);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspInsertProduto]")) != null)
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
        public DataTable selectProdutoSomadoSemComandaPorId(int Quantidade,int IdProduto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@quantidade",Quantidade);
                AdicionaParametro("@IdProduto", IdProduto);
                 return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelecionaVendaForaDaComandaPorId]");

                
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable selectProdutoSomadoSemComandaPorCodigo(int Quantidade,string CodigoProd)
        {
            try 
	       {
               LimparParametros();
               AdicionaParametro("@quantidade", Quantidade);
               AdicionaParametro("@codigoProduto", CodigoProd);
	       	   return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelecionaVendaForaDaComandaPorCodigo");

	       }
	       catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable selectFullProdutoPorCodigoComEstoque()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoFullComEstoque]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
          public DataTable selectValorDaComandaPorPreco(string CodigoComanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@CodigoComanda", CodigoComanda);
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectValorDaVendaComComandaAtivaPorPreco");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        
        public DataTable selectValorDaComanda(string CodigoComanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@CodigoComanda", CodigoComanda);
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectValorDaVendaComComandaAtiva");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable selectFullProdutoPorIDComEstoque(Int64 ID,string Peso)
        {
            try
            {
             
                LimparParametros();
                AdicionaParametro("@ID", ID);
                AdicionaParametro("@Peso",Peso);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoPorID]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool UpdateProduto(Produto produto)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@codigo", produto.Codigo);
                AdicionaParametro("@nome", produto.Nome);
                AdicionaParametro("@categoria", produto.Categoria);
                AdicionaParametro("@precocompra", produto.PrecoCompra);
                AdicionaParametro("@precovenda", produto.PrecoVenda);
                AdicionaParametro("@Porcentagem",produto.Porcentagem);
                AdicionaParametro("@Quantidade", produto.Quantidade);
                AdicionaParametro("@descricao", produto.Descricao);
                AdicionaParametro("@QtdMax", produto.QtdMaxima);
                AdicionaParametro("@QtdMin",produto.QtdMinima);
                AdicionaParametro("@ID", produto.Id);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspAlterarProduto]")) != null)
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
        public bool DeleteProduto(int ID)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", ID);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspDeleteProduto]")) != null)
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
        public DataTable selectProdutoPorNome(string Nome)
        {
            try
            {
                //_aspSelectProutoFullComPeso||[dbo].[_aspSelectProdutoPorNome]
                LimparParametros();
                AdicionaParametro("@Nome", Nome);
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectProdutoPorNome");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

        public DataTable selectFullProduto()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectFullProdutoSemParametro]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

        public DataTable selectFullProdutoPorCodigo(string Codigo,string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Codigo", Codigo);
                AdicionaParametro("Peso", Peso);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoPorCodigo]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable selectFullProdutoPorNome(string Nome,string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", Nome);
                AdicionaParametro("@Peso", Peso);               
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectProdutoPorNome]");
                

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }

        }
        public DataTable selectFullProdutoPorNomeDaCategoria(string Categoria,string Peso)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Categoria", Categoria);
                AdicionaParametro("@Peso", Peso);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectFullProdutoComNomeDaCategoria]");

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }

        }

        public DataTable selectFullProdutoPorPeso()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectFullProdutoSemParametroPorPeso");

              
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
    }
}
