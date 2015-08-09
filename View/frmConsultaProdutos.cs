using System;
using System.Data;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class frmConsultaProdutos : Form
    {
        public frmConsultaProdutos()
        {
            InitializeComponent();
        }
        ProdutoDAO produtoDao = new ProdutoDAO();
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
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja Fechar Esse Formulario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                this.Close();
            }
        }
        //---------------------------------------------------------------------
        private void frmConsultaProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txt_PesquisaProduto;
                cbb_TipoDePesquisa.DisplayMember = "Codigo";
                cbb_TipoDePesquisa.DataSource = TipoDePagamento.tipoDePagamento();
                CarregarGrid();
                if (cbb_TipoDePesquisa.Text.Equals("ID"))
                {
                    txt_PesquisaProduto.MaxLength = 10;
                    MudarLabelDeTipoDePesquisa("Digite Um ID Do Produto");

                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O ConboBox De Tipo De Pesquisa: " + Erro, "Erro");
            }
        }

        private void CarregarGrid()
        {
            try
            {
                dgv_k_Produtos.DataSource = produtoDao.selectFullProduto();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Os Dados No Formulario: " + Erro, "Erro");
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabela = null;

                if (ckb_PorPeso.Checked == false)
                {
                    if (txt_PesquisaProduto.Text.Length > 0)
                    {

                        if (cbb_TipoDePesquisa.Text.Equals("ID"))
                        {
                            Int64 valorParaTeste = Convert.ToInt64(txt_PesquisaProduto.Text);
                            if (valorParaTeste > 2147483647)
                            {
                                Message("Valor Muito Grande Para Um ID, Verifique Se O Valor Esta Correto", "Aviso");
                                LimparTxt();
                                return;
                            }
                            else
                            {
                                
                                tabela = produtoDao.selectFullProdutoPorIDComEstoque(Convert.ToInt32(txt_PesquisaProduto.Text),"Nao");

                                validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Esse ID: " + txt_PesquisaProduto.Text, tabela);
                             
                                return;
                            }

                        }

                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        if (cbb_TipoDePesquisa.Text.Equals("Código"))
                        {
                            tabela = produtoDao.selectFullProdutoPorCodigo(txt_PesquisaProduto.Text,"Nao");

                            validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Esse Código: " + txt_PesquisaProduto.Text, tabela);
                            return;
                        }
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        if (cbb_TipoDePesquisa.Text.Equals("Nome"))
                        {
                            tabela = produtoDao.selectFullProdutoPorNome(txt_PesquisaProduto.Text,"Nao");

                            validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Esse Nome: " + txt_PesquisaProduto.Text, tabela);
                            return;
                        }
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        //----
                        if (cbb_TipoDePesquisa.Text.Equals("Categoria"))
                        {
                            tabela = produtoDao.selectFullProdutoPorNomeDaCategoria(txt_PesquisaProduto.Text,"Nao");

                            validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Essa Categoria: " + txt_PesquisaProduto.Text, tabela);
                            return;
                        }
                    }
                    else
                    {
                        Message("Antes De Pesquisar Digite O Valor Correspondente A Pesquisa", "Aviso");
                    }
                }
                else
                {
                    ckb_PorPeso.Checked = false; 

                    if (txt_PesquisaProduto.Text.Length > 0)
                    {

                        if (cbb_TipoDePesquisa.Text.Equals("ID"))
                        {
                            Int64 valorParaTeste = Convert.ToInt64(txt_PesquisaProduto.Text);
                            if (valorParaTeste > 2147483647)
                            {
                                Message("Valor Muito Grande Para Um ID, Verifique Se O Valor Esta Correto", "Aviso");
                                LimparTxt();
                                return;
                            }
                            else
                            {
                                tabela = produtoDao.selectFullProdutoPorIDComEstoque(Convert.ToInt32(txt_PesquisaProduto.Text),"Sim");

                                validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Esse ID: " + txt_PesquisaProduto.Text, tabela);
                                return;
                            }

                        }

                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        if (cbb_TipoDePesquisa.Text.Equals("Código"))
                        {
                            tabela = produtoDao.selectFullProdutoPorCodigo(txt_PesquisaProduto.Text,"Sim");

                            validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Esse Código: " + txt_PesquisaProduto.Text, tabela);
                            return;
                        }
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        if (cbb_TipoDePesquisa.Text.Equals("Nome"))
                        {
                           
                            tabela = produtoDao.selectFullProdutoPorNome(txt_PesquisaProduto.Text,"Sim");

                            validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Esse Nome: " + txt_PesquisaProduto.Text, tabela);
                            return;
                        }
                        //---------------------------------------------------------------------------
                        //---------------------------------------------------------------------------
                        //----
                        if (cbb_TipoDePesquisa.Text.Equals("Categoria"))
                        {
                            tabela = produtoDao.selectFullProdutoPorNomeDaCategoria(txt_PesquisaProduto.Text,"Sim");

                            validacaoDePesquisa("Não Foi Possível Encontrar Um Produto Com Essa Categoria: " + txt_PesquisaProduto.Text, tabela);
                            return;
                        }
                    }
                    else
                    {
                        Message("Antes De Pesquisar Digite O Valor Correspondente A Pesquisa", "Aviso");
                    }
                }
               
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Os Produtos Selecionados Na Pesquisa: " + Erro, "Erro");
            }
            
        }

        private void validacaoDePesquisa(string Valor, DataTable tabela)
        {
            
                if (tabela.Rows.Count > 0)
                {
                    dgv_k_Produtos.DataSource = tabela;

                }
                else
                {
                    Message(Valor, "Aviso");
                    LimparTxt();

                }
           
           
        }

        private void LimparTxt()
        {
            txt_PesquisaProduto.Text = string.Empty;
        }

        private void txt_PesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            if (txt_PesquisaProduto.Text.Length == 0)
            {
                CarregarGrid();
            }
        }

        private void cbb_TipoDePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparTxt();

            if (cbb_TipoDePesquisa.Text.Equals("Código"))
            {
                txt_PesquisaProduto.MaxLength = 100;
                MudarLabelDeTipoDePesquisa("Digite Um Código Do Produto");
                FocoNoTxt();
                // SomeBtnPesquisar();
            }
            if (cbb_TipoDePesquisa.Text.Equals("Nome"))
            {
                txt_PesquisaProduto.MaxLength = 50;
                MudarLabelDeTipoDePesquisa("Digite O Nome Do Produto");
                FocoNoTxt();
                //ApareceBtnPesquisar();
            }
            if (cbb_TipoDePesquisa.Text.Equals("ID"))
            {
                txt_PesquisaProduto.MaxLength = 10;
                MudarLabelDeTipoDePesquisa("Digite Um ID Do Produto");
                FocoNoTxt();
                // ApareceBtnPesquisar();
            }
            if (cbb_TipoDePesquisa.Text.Equals("Categoria"))
            {
                txt_PesquisaProduto.MaxLength = 50;
                MudarLabelDeTipoDePesquisa("Digite Uma Categoria Do Produto");
                FocoNoTxt();
                //ApareceBtnPesquisar();
            }

        }

        private void FocoNoTxt()
        {
            this.ActiveControl = txt_PesquisaProduto;
        }

        private void ApareceBtnPesquisar()
        {
            btn_Pesquisar.Visible = true;
        }

        private void SomeBtnPesquisar()
        {
            btn_Pesquisar.Visible = false;
        }

        private void MudarLabelDeTipoDePesquisa(string txt)
        {
            lbl_TipoDaPesquisa.Text = txt;
        }

        private void txt_PesquisaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbb_TipoDePesquisa.Text == "ID")
            {

                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;

                }

            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btn_Pesquisar_Click(e, e);
                ckb_PorPeso.Checked = false;
                //    try
                //    {


                //        DataTable tabela = produtoDao.selectFullProdutoPorIDComEstoque(Convert.ToInt64(txt_PesquisaProduto.Text));
                //        dgv_k_Produtos.DataSource = tabela;
                //    }
                //    catch (Exception Erro)
                //    {

                //        Message("Não Foi Possível Encontrar Um Produto: "+Erro.Message,"Erro");
            }

        }

        private void ckb_PorPeso_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txt_PesquisaProduto;
        }

        private void btnCarregarPorUnidade_Click(object sender, EventArgs e)
        {
            try
            {
               DataTable tabela = produtoDao.selectFullProduto();
               dgv_k_Produtos.DataSource = tabela;
            }
            catch (Exception Ero)
            {

                Message("Não Foi Possivel Carregar Os Itens: "+Ero.Message,"Erro");
            }
        }

        private void btnCarregarPorPeso_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabela = produtoDao.selectFullProdutoPorPeso();
                dgv_k_Produtos.DataSource = tabela;
            }
            catch (Exception Ero)
            {
                Message("Não Foi Possivel Carregar Os Itens: " + Ero.Message, "Erro");
            }
        }

    }


}

