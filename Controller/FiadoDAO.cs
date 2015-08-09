using Model;
using System;
using System.Data;

namespace Controller
{
    public class FiadoDAO: Conection
    {
        public DataTable SelectFiado()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.Text,"SELECT * FROM FIADO");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool InsertFiado()
        {
            try
            {
                LimparParametros();

                AdicionaParametro("@IDCLIENTE", Fiado.IdCliente);
                AdicionaParametro("@IDFUNCIONARIO", Fiado.IdFuncionario);
                AdicionaParametro("@VALOR", Fiado.Valor);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspInsertFiado") != null)
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
        public bool alterarFiado(int IDCLIENTE, double Valor)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@IDCLIENTE", IDCLIENTE);
                AdicionaParametro("@VALORPAGO", Valor);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspAlterarFiado") != null)
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
