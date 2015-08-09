using Model;
using System;
using System.Data;

namespace Controller
{
    public class ComandaDAO:Conection
    {
        public bool UpdateComanda(Comanda comanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@ID",comanda.Id);
                AdicionaParametro("@CODIGO", comanda.Codigo);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspAlterarComanda") != null)
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
        public DataTable SelectFull()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectComanda");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool DeleteComanda(Comanda comanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", comanda.Id);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspDeleteComanda") != null)
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
        public bool InsertComanda(Comanda comanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Codigo", comanda.Codigo);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspInsertComanda]") != null)
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
        public bool DeleteComandaComVendaAtiva(Comanda comanda)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@CodigoComanda", comanda.Codigo);
                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspDeletVendaPorComandaAtiva]")) != null)
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
    }
}
