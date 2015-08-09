using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class KeyGenDAO : Conection
    {
        public bool DeleteDatas()
        {
            try
            {
                LimparParametros();
                if (ExecutaComando(CommandType.StoredProcedure, "_aspDeletarDatas") != null)
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
        public int selectQuantidadeData()
        {
            try
            {
                //
                LimparParametros();
                int Quantidade = Convert.ToInt32(ExecutaConsulta(CommandType.StoredProcedure, "_aspPegaQuantidadeDeRegistros").Rows[0]["Quantidade"]);
                return Quantidade;
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
        public bool InsertData()
        {
            try
            {
                LimparParametros();
                if (ExecutaComando(CommandType.StoredProcedure, "_aspInsertDataDiferente") != null)
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
        public string SelectDiasTrail()
        {
            try
            {
                LimparParametros();
                string dias = ExecutaConsulta(CommandType.StoredProcedure, "_aspPegarDiasValidos").Rows[0]["Data"].ToString();
                return dias;
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.Message);
            }
        }
    }
}
