using Model;
using System;
using System.Data;

namespace Controller
{
    public class ClienteDAO : Conection
    {
        public bool InsertCliente(Cliente Cliente)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", Cliente.Nome);
                AdicionaParametro("@cpf", Cliente.CPF);
                AdicionaParametro("@Telefone", Cliente.Celular);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspInsertCliente") != null)
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
        // public string SelectNomePorCpf
        public int SelectIdPorNome(string Nome)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Nome", Nome);
                int Id = Convert.ToInt32(ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectIdPorNome").Rows[0]["ID"]);
                return Id;

            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public string SelectCpfPorId(int Id)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", Id);
                string ID = ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectCpfPorId").Rows[0]["CPF"].ToString();
                return ID;
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable SelectName()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectNomeFiado");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

        public bool UpdateCliente(Cliente cliente)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", cliente.IdCliente);
                AdicionaParametro("@nOME", cliente.Nome);
                AdicionaParametro("@Celular", cliente.Celular);
                AdicionaParametro("@CPF", cliente.CPF);
                if (ExecutaComando(CommandType.StoredProcedure, "_aspAlterarCliente") != null)
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
        public Cliente SelectForId(int Id)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@Id", Id);
                DataRow Linha = ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectClientePorId").Rows[0];
                if (Linha != null)
                {
                    Cliente cliente = new Cliente
                    {
                        Nome = Linha["Nome"].ToString(),
                        IdCliente = Convert.ToInt32(Linha["ID"]),
                        CPF = Linha["CPF"].ToString(),
                        Celular = Linha["Celular"].ToString()

                    };
                    return cliente;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

        public DataTable selectClienteSemValor()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectClienteSemValor");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public DataTable selectClienteComValor()
        {
            try
            {
                LimparParametros();
                return ExecutaConsulta(CommandType.StoredProcedure, "_aspSelectCliente");
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }
        public bool DeleteCliente(Cliente cliente)
        {
            try
            {
                LimparParametros();
                AdicionaParametro("@id", cliente.IdCliente);
                if (ExecutaComando(CommandType.StoredProcedure, "[dbo].[_aspDeleteCliente]") != null)
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
