using System;
using System.Data;

namespace Model
{
   public class CarregaTipoPermicao
    {
       public static DataTable SelectTipoPermicao()
       {
           try{


               DataTable tabela = new DataTable("Permissao"); ;

                DataColumn Coluna;
                Coluna = new DataColumn();
                Coluna.DataType = typeof(string);
                Coluna.ColumnName = "Permissao";
                tabela.Columns.Add(Coluna);

                DataRow linha = null;


                linha = tabela.NewRow();
                linha["Permissao"] = "Admin";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Permissao"] = "Restrito";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Permissao"] = "Caixa";
                tabela.Rows.Add(linha);
                linha = tabela.NewRow();
                linha["Permissao"] = "Intermediario";
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
