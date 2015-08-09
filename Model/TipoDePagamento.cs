using System;
using System.Data;

namespace Model
{
    public class TipoDePagamento
    {
        public static DataTable tipoDePagamento()
        {
            try
            {
                DataTable tabela = new DataTable("Tipo"); ;

                DataColumn Coluna;
                Coluna = new DataColumn();
                Coluna.DataType = typeof(string);
                Coluna.ColumnName = "Codigo";
                tabela.Columns.Add(Coluna);
                
                DataRow linha = null;
                

                linha = tabela.NewRow();
                linha["Codigo"] = "ID";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Codigo"] = "Código";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Codigo"] = "Nome";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Codigo"] = "Categoria";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                return tabela;
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }
        }

        //foreach (DataRow Linha in rowCollection)
        //{
        //    tabela.NewRow();
        //    tabela.Rows.Add(Linha);
        //}
        //gera o n£mero GUID
        //linha["Codigo"] = Guid.NewGuid().ToString();
               
    }
}
