using System;
using System.Data;

namespace Model
{
    public class MetodoDePagamento
    {
        public static DataTable RetornaMetodoDePagamento()
        {

            try
            {
                DataTable tabela = new DataTable("Metodo"); ;

                DataColumn Coluna;
                Coluna = new DataColumn();
                Coluna.DataType = typeof(string);
                Coluna.ColumnName = "Metodo";
                tabela.Columns.Add(Coluna);

                DataRow linha = null;


                linha = tabela.NewRow();
                linha["Metodo"] = "Todos";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Metodo"] = "Dinheiro";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Metodo"] = "Cartão";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Metodo"] = "Fiado";
                tabela.Rows.Add(linha);
             
                return tabela;
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }

        }

    }
}
