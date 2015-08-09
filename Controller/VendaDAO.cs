using Model;
using System;
using System.Data;

namespace Controller
{
    public class VendaDAO : Conection
    {
        public int SelectIdUsuarioPorNome(string Nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome",Nome);
                int Id = Convert.ToInt32(ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectIdUsuarioPorNome").Rows[0]["ID"]);
                return Id;
               // "_aspSelectIdUsuarioPorNome"
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool InsertVendas(Venda Venda)
        {
            try
            {
                LimparParametros();
              
                AdicionaParametro("@LucroTotal", Venda.LucroTotal);
                AdicionaParametro("@VENDATOTAL", Venda.VendaTotal);
                AdicionaParametro("@Data", Venda.Data);
                AdicionaParametro("@Idusuario", Venda.IdUsuario);
                AdicionaParametro("@IdPagamento", Venda.IdTipoPagamento);

                if ((ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspInsertVenda]")) != null)
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
        public DataTable SelectFullVenda()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectVenda]");
                
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectVendaEntreDatas(string DataUm,string DataDois,string Tipo)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@dataUm",DataUm);
                AdicionaParametro("@dataDois", DataDois);
                AdicionaParametro("@Tipo", Tipo);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectVendaEntreData]");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }

        }
        public DataTable SelectIDTipoPagementoPorNome(string Nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome",Nome);
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectIDTipoPagamentoPorNome");
            
               
            }
              catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }

        }
        public bool InsertTipoDePagamento()
        {
            try
            {
                if ((ExecutaComando(CommandType.StoredProcedure, "_aspInsertTipoPagamentoFormVenda")) != null)
                {

                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public DataTable SelectTipoPagamento()
        {
            try
            {
                
                LimparParametros();
                this.InsertTipoDePagamento();
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectFullTipoPagamento]");
              
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }

        }
        public DataTable SelectVendaPorData(string DataUm,string tipo)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@dataUm", DataUm);
                AdicionaParametro("@tipo",tipo);
                return ExecutaConsulta(CommandType.StoredProcedure, "[dbo].[_aspSelectVendaPorData]");
                
            }
            catch (Exception Erro)
            {
                
                throw new Exception(Erro.Message);
            }

        }
        public bool DeleteCaixa()
        {
            try
            {
                LimparParametros();
                if ((ExecutaComando(CommandType.StoredProcedure, "_aspFecharCaixa")) != null)
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
        public bool UpdateValorCaixa(decimal Valor, string Operecao,int IdUsuario)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Valor", Valor);
                AdicionaParametro("@IdUsuario", IdUsuario);
                AdicionaParametro("@Operacao", Operecao);
                if ((ExecutaComando(CommandType.StoredProcedure, "_aspAlterarCaixa")) != null)
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
        public double SelectValorCaixaCompleto()
        {
            try
            {
                LimparParametros();
                double Valor = Convert.ToDouble(ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectCaixa").Rows[0]["Valor"]);
                return Valor;   
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectValorCaixa()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectCaixa");
               
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool InsertCaixa(double valor,int IdUsuario )
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Caixa", valor);
                AdicionaParametro("@IdUsuario", IdUsuario);

                if ((ExecutaComando(CommandType.StoredProcedure, "_aspInsertCaixa")) != null)
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
