using Controller;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class frmFluxoDeCaixa : Form
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }
        VendaDAO vendaDao = new VendaDAO();
        string DataUm, DataDois,tipoPagamento;
        DataTable tabela = null;
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Minimizar O Formulario: " + Erro, "Erro");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja Fechar Esse Formulario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                this.Close();
            }
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmFluxoDeCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = btn_PesquisarPorIntervalo;
                //dgv_k_Produtos.DataSource = vendaDao.SelectFullVenda();
                cbb_tipoVendaPagamento.DisplayMember = "Metodo";
                cbb_tipoVendaPagamento.DataSource = MetodoDePagamento.RetornaMetodoDePagamento();
            }
            catch (Exception Erro)
            {
                Message("Não Foi Possível Carregar A Venda: " + Erro.Message, "Aviso");
            }
        }

        private void btn_PesquisarPorIntervalo_Click(object sender, EventArgs e)
        {
            //if (cbb_tipoVendaPagamento.Text.Equals("Todos"))
            //{

            //if (!cbb_tipoVendaPagamento.Text.Equals("Todos"))
           // {
                try
                {
                    LimparLabel();    
                    lbl_PesquisaTotal.Values.ExtraText = "00.00";
                    DataUm = dtp_K_data1.Value.ToShortDateString();
                    DataDois = dtp_k_2.Value.ToShortDateString();
                    tipoPagamento = cbb_tipoVendaPagamento.Text;
                    
                    tabela = null;
                    tabela = vendaDao.SelectVendaEntreDatas(DataUm, DataDois, tipoPagamento);

                    CarregaTabela(tabela);
                }
                catch (Exception Erro)
                {
                    Message("Não Foi Possível Carregar As Vendas: " + Erro.Message, "Erro");
                }
            //}
            //else
            //{
            //    btn_K_PesquisarPorDia_Click(e, e);
            //}
            ////}
            ////else if (cbb_tipoVendaPagamento.Text.Equals("Dinheiro"))
            ////{
            ////    try
            ////    {

            ////    }
            ////    catch (Exception Erro)
            ////    {
            ////        Message("Não Foi Possível Carregar As Vendas: " + Erro.Message, "Erro");
            ////    }   
            ////}
            ////else if (cbb_tipoVendaPagamento.Text.Equals("Cartão"))
            ////{
            ////    try
            ////    {

            ////    }
            ////    catch (Exception Erro)
            ////    {
            ////        Message("Não Foi Possível Carregar As Vendas: " + Erro.Message, "Erro");
            ////    }
            ////}
            ////else
            ////{
            ////    try
            ////    {

            ////    }
            ////    catch (Exception Erro)
            ////    {
            ////        Message("Não Foi Possível Carregar As Vendas: " + Erro.Message, "Erro");
            ////    }
            ////}
        }

        private void LimparLabel()
        {
            lbl_PesquisaTotal.Values.ExtraText = "00.00";
            lbl_totalLucro.Values.ExtraText   ="00.00";
        }

        private void CarregaTabela(DataTable tabela)
        {
            try
            {
                if (tabela != null)
                {
                    dgv_k_Produtos.DataSource = tabela;
                    if (tabela.Rows.Count > 0)
                    {
                        double totalLucro = 0, totalVenda = 0;
                        foreach (DataRow Linha in tabela.Rows)
                        {
                            totalLucro += Convert.ToDouble(Linha["LUCRO BRUTO TOTAL"]);
                            totalVenda += Convert.ToDouble(Linha["Total Vendido"]);

                        }
                        lbl_PesquisaTotal.Values.ExtraText = totalLucro.ToString("C");
                        lbl_totalLucro.Values.ExtraText     = totalVenda.ToString("C");
                    }
                }
                else
                {
                    Message("Não Foi Possível Carregar As Vendas: ", "Erro");

                }

            }
            catch (Exception Erro)
            {
                Message("Não Foi Possível Carregar As Vendas: " + Erro.Message, "Erro");
            }
        }

        private void btn_K_PesquisarPorDia_Click(object sender, EventArgs e)
        {
            CarregaPesquisa();
        }

        private void cbb_tipoVendaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CarregaPesquisa();
        }

        private void CarregaPesquisa()
        {
            try
            {
                LimparLabel(); 
                DataUm = dtp_k_pesquisaindividual.Value.ToShortDateString();
                tipoPagamento = cbb_tipoVendaPagamento.Text;
                tabela = null;
                tabela = vendaDao.SelectVendaPorData(DataUm, tipoPagamento);
                CarregaTabela(tabela);
            }
            catch (Exception Erro)
            {
                Message("Não Foi Possível Carregar As Vendas: " + Erro.Message, "Erro");
            }
        }
    }
}
