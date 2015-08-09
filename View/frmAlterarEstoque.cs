using Controller;
using Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class frmAlterarEstoque : Form
    {
        public frmAlterarEstoque()
        {
            InitializeComponent();
        }
        EstoqueDAO estoqueDao = new EstoqueDAO();
        ProdutoDAO produtoDao = new ProdutoDAO();
        private void frmAlterarEstoque_Load(object sender, EventArgs e)
        {
            DesabilitaBotoes();
            rdb_ComCodigoDeBarra.Checked = true;
            Produto produto = new Produto();
            this.ActiveControl = txt_CodigoDoProduto;
            CarregaUmNaQuantidade();

            try
            {
                //    if (rdb_ComCodigoDeBarra.Checked)
                //    {

                //    }
                //    else if (rdb_SemCodigoDeBarra.Checked)
                //    {
                //        JogaLinhaDoBancoParaALabelComOId();
                //    }


                CarregaGrid();

                dgv_Estoque.ClearSelection();


                //CarregaUmNaQuantidade();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Formulario: " + Erro.Message, "Erro");
            }


        }
        public void AlterarTamanhoDoGrid(int Tamanho, int Index)
        {
            try
            {
                //dgv_Estoque.Rows
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Formulario: " + Erro.Message, "Erro");
            }
        }
        private bool CarregaGrid()
        {
            try
            {


                if (produtoDao.selectFullProduto().Rows.Count > 0)
                {
                    Produto produto = new Produto();
                    produto.Id = -1;
                    produto.Codigo = "-1";

                    dgv_Estoque.DataSource = produtoDao.selectProdutoComIdECodigo(produto);
                    dgv_Estoque.ClearSelection();
                    return true;

                    //foreach (DataGridViewRow Linha in dgv_Estoque.Rows)
                    //{

                    //}

                    //foreach (DataRow Linha in produtoDao.selectProdutoComIdECodigo(produto).Rows)
                    //{
                    //    //Linha.DefaultCellStyle.BackColor.Equals(Color.Pink);
                    //    dgv_Estoque.Rows[Linha].DefaultCellStyle.BackColor = Color.Pink;
                    //}
                    //foreach (DataGridViewRow Linha in dgv_Estoque.Rows)
                    //{
                    //    if (Convert.ToInt32(produtoDao.selectProdutoComIdECodigo(produto).Rows[3]["Quantidade"]) <= 10)
                    //    {
                    //        Linha.DefaultCellStyle.BackColor = Color.Pink;

                    //    }
                    //}

                    //dgv_Estoque.ClearSelection();
                }
                else if (produtoDao.selectFullProduto() != null)
                {
                    Produto produto = new Produto();
                    produto.Id = -1;
                    produto.Codigo = "-1";

                    dgv_Estoque.DataSource = produtoDao.selectProdutoComIdECodigo(produto);

                    return true;
                }
                else
                {

                    return false;

                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Formulario: " + Erro.Message, "Erro");
                return false;
            }
        }
        private void btn_Retirar_Click(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text.Length > 0 && lbl_ValorRetiradoDoEstoque.Values.ExtraText != "??" && txt_CodigoDoProduto.Text.Length > 0)
            {


                try
                {
                    string RRight1, RError1, RRight2, RError2;
                    RRight1 = "Quantidade Retidade Com Sucesso";
                    RError1 = "Não Foi Possível Retirar A Quantidade Do Estoque, Verifique O Códido Do Produto, Ou Se Existe Quantidade Suficiente A Ser Retirada";
                    RRight2 = "Quantidade Retidade Com Sucesso";
                    RError2 = "Não Foi Possível Retirar A Quantidade Do Estoque, Verifique O Códido Do Produto, Ou Se Existe Quantidade Suficiente A Ser Retirada";
                    AtribuirRetiradaDoEatoque();
                    ConfirmarOperacao(RRight1, RError1, RRight2, RError2);
                    FocoNoTxtEUmNaQuantidade();
                    CarregaGrid();
                }
                catch (Exception Erro)
                {

                    Message("Erro Ao Retirar Produto Do Estoque: " + Erro.Message, "Erro");
                    limparTxt();
                    ZerarLabel();
                    txt_Quantidade.Text = "1";

                }
            }
            else
            {
                Message("Selecione O Produto Antes De Fazer Uma Operação", "Aviso");
                txt_CodigoDoProduto.Text = string.Empty;
                focoNoTxtDeCodigoDeBarra();

            }
        }

        private void focoNoTxtDeCodigoDeBarra()
        {
            this.ActiveControl = txt_CodigoDoProduto;
            dgv_Estoque.ClearSelection();
        }

        private bool JogaLinhaDoBancoParaALabelComOCodigo()
        {
            try
            {


                DataRow LinhaProduto = null;
                if (produtoDao.selectFullProdutoPorCodigo(txt_CodigoDoProduto.Text, "Nao").Rows.Count > 0)
                {
                    LinhaProduto = produtoDao.selectFullProdutoPorCodigo(txt_CodigoDoProduto.Text, "Nao").Rows[0];
                    AtribuirValoresParaALabel(LinhaProduto);
                    return true;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception Erro)
            {
                Message("Não Foi Possível Encontrar Um Produto Com Os Dados Fornecidos: " + Erro.Message, "Erro");
                ZerarLabel();
                limparTxt();
                CarregaUmNaQuantidade();
                return false;
                //CarregaGrid();

            }
        }

        private void AtribuirValoresParaALabel(DataRow LinhaProduto)
        {
            try
            {


                if (LinhaProduto["Nome"] != null)
                {
                    string Nome, Quantidade;
                    Nome = "Nome: " + LinhaProduto["Nome"].ToString();
                    Quantidade = " - Quantidade: " + LinhaProduto["Quantidade"].ToString();

                    lbl_ValorRetiradoDoEstoque.Values.ExtraText = Nome;
                    lbl_ValorRetiradoDoEstoque.Values.ExtraText += Quantidade;

                }
                else
                {
                    Message("Não Foi Possível Excluir Essa Quantidade Do Estoque, Verifique Se Existe Essa Quantidade A Ser Retirada", "Erro");

                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                ZerarLabel();
                limparTxt();
                CarregaUmNaQuantidade();
            }
        }

        private void limparTxt()
        {
            txt_Quantidade.Text = string.Empty;
            txt_CodigoDoProduto.Text = string.Empty;
        }

        private void AtribuirRetiradaDoEatoque()
        {
            lblParametroOperacao.Text = string.Empty;
            lblParametroOperacao.Text = "-";
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text.Length > 0 && lbl_ValorRetiradoDoEstoque.Values.ExtraText != "??" && txt_CodigoDoProduto.Text.Length > 0)
            {

                try
                {
                    string IRight1, IError1, IRight2, IError2;
                    IRight1 = "Estoque Incluido Com Sucesso";
                    IError1 = "Não Foi Possível Incluir No Estoque, Verifique Se Os Valores Estão Corretos";
                    IRight2 = "Quantidade Incluida Com Sucesso";
                    IError2 = "Não Foi Possível Incluir A Quantidade Do Estoque, Verifique O Códido Do Produto, Ou Se Existe Quantidade Suficiente A Ser Retirada";
                    AtribuiInclusaoDoEstoque();

                    ConfirmarOperacao(IRight1, IError1, IRight2, IError2);
                    CarregaGrid();
                    FocoNoTxtEUmNaQuantidade();

                }
                catch (Exception Erro)
                {

                    Message("Erro Ao Incluir Produto Do Estoque: " + Erro.Message, "Erro");
                    ZerarLabel();
                    limparTxt();

                }
            }
            else
            {
                Message("Selecione O Produto Antes De Fazer Uma Operação", "Aviso");
                txt_CodigoDoProduto.Text = string.Empty;
                focoNoTxtDeCodigoDeBarra();
            }
        }

        private void AtribuiInclusaoDoEstoque()
        {
            lblParametroOperacao.Text = string.Empty;
            lblParametroOperacao.Text = "+";
        }



        private void ConfirmarOperacao(string MessageRight, string MessageError, string Certinho, string Erradinho)
        {
            try
            {


                int Quantidade = Convert.ToInt32(txt_Quantidade.Text);
                string Codigo = txt_CodigoDoProduto.Text;

                Estoque estoque = new Estoque();
                Estoque.Quantidade = Quantidade;
                estoque.Operacao = lblParametroOperacao.Text;
                estoque.Codigo = txt_CodigoDoProduto.Text;

                if (rdb_ComCodigoDeBarra.Checked)
                {

                    if (estoqueDao.updateEstoqueComCodigo(estoque))
                    {
                        Message(Certinho, "Aviso");
                        ZerarLabel();
                        limparTxt();
                        FocoNoTxtEUmNaQuantidade();
                    }
                    else
                    {
                        Message(Erradinho, "Aviso");
                        limparTxt();
                        ZerarLabel();
                    }
                }
                else if (rdb_SemCodigoDeBarra.Checked)
                {

                    if (estoqueDao.updateEstoqueComId(estoque))
                    {
                        Message(MessageRight, "Aviso");
                        ZerarLabel();
                        limparTxt();
                    }
                    else
                    {
                        Message(MessageError, "Aviso");
                        limparTxt();
                        ZerarLabel();
                    }
                }


            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                limparTxt();
                ZerarLabel();
                CarregaUmNaQuantidade();
            }
        }

        private void FocoNoTxtEUmNaQuantidade()
        {
            this.ActiveControl = txt_CodigoDoProduto;
            txt_Quantidade.Text = "1";
        }

        private void ZerarLabel()
        {
            lbl_ValorRetiradoDoEstoque.Values.ExtraText = "??";
        }

        private void txt_CodigoDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (rdb_SemCodigoDeBarra.Checked)
                {
                    if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                    {
                        e.Handled = true;

                    }
                }
                if ((Keys)e.KeyChar == Keys.Enter)
                {




                    if (dgv_Estoque.Rows.Count > 0)
                    {
                        if (produtoDao.selectFullProduto().Rows.Count > 0)
                        {
                            if (rdb_ComCodigoDeBarra.Checked)
                            {

                                if (JogaLinhaDoBancoParaALabelComOCodigo())
                                {
                                    Produto produto = new Produto();

                                    produto.Id = 0;
                                    produto.Codigo = txt_CodigoDoProduto.Text;
                                    CarregaGridAoSelecionar(produto);
                                    if (dgv_Estoque.Rows.Count > 0)
                                    {
                                        //78923409
                                        if (!lbl_ValorRetiradoDoEstoque.Values.ExtraText.Equals("??"))
                                        {
                                            HabilitaBotoes();

                                        }
                                        else
                                        {
                                            Message("Selecione Um Produto", "Aviso");
                                            focoNoTxtDeCodigoDeBarra();
                                            DesabilitaBotoes();
                                        }


                                    }
                                    else
                                    {
                                        Message("Não Foi Encontrado Itens Com Esse Código De Barra", "Aviso");
                                        limparTxt();
                                        CarregaUmNaQuantidade();
                                        focoNoTxtDeCodigoDeBarra();
                                    }
                                    CarregaUmNaQuantidade();


                                    //txt_CodigoDoProduto.Text = string.Empty;
                                }
                                else
                                {
                                    Message("Não Foi Encontrado Itens Com Esse Codigo De Barra", "Aviso");
                                    limparTxt();
                                    CarregaUmNaQuantidade();
                                    focoNoTxtDeCodigoDeBarra();
                                    return;
                                }

                            }
                            else if (rdb_SemCodigoDeBarra.Checked)
                            {


                                if (JogaLinhaDoBancoParaALabelComOId())
                                {
                                    Produto produto = new Produto();
                                    produto.Id = Convert.ToInt32(txt_CodigoDoProduto.Text);
                                    produto.Codigo = "c";
                                    CarregaGridAoSelecionar(produto);
                                    if (dgv_Estoque.Rows.Count > 0)
                                    {
                                        if (!lbl_ValorRetiradoDoEstoque.Values.ExtraText.Equals("??"))
                                        {
                                            HabilitaBotoes();

                                        }
                                        else
                                        {
                                            Message("Selecione Um Produto", "Aviso");
                                            limparTxt();
                                            focoNoTxtDeCodigoDeBarra();
                                            DesabilitaBotoes();
                                        }


                                        CarregaUmNaQuantidade();
                                    }
                                    else
                                    {
                                        CarregaGrid();
                                    }

                                }
                                else
                                {
                                    Message("Não Foi Encontrado Itens Com Esse ID", "Aviso");
                                    limparTxt();
                                    CarregaUmNaQuantidade();
                                    focoNoTxtDeCodigoDeBarra();
                                    return;
                                }


                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        Message("Não Existe Produtos Cadastrados No Estoque Com Quantidade, Cadastre e Retorne", "Aviso");
                        focoNoTxtDeCodigoDeBarra();
                        limparTxt();
                        CarregaUmNaQuantidade();
                        CarregaGrid();
                        return;
                    }

                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                ZerarLabel();
                limparTxt();
                CarregaUmNaQuantidade();
            }
        }

        private void DesabilitaBotoes()
        {
            btn_Retirar.Enabled = false;
            btn_Incluir.Enabled = false;
        }

        private void HabilitaBotoes()
        {
            btn_Retirar.Enabled = true;
            btn_Incluir.Enabled = true;
        }

        private void CarregaUmNaQuantidade()
        {
            txt_Quantidade.Text = "1";
        }

        private void CarregaGridAoSelecionar(Produto produto)
        {

            if (produtoDao.selectProdutoComIdECodigo(produto) != null)
            {

                dgv_Estoque.DataSource = produtoDao.selectProdutoComIdECodigo(produto);
                dgv_Estoque.ClearSelection();

            }
            else
            {
                Message("Código: " + txt_CodigoDoProduto.Text + " Não Corresponde A Um Produto", "Aviso");
                txt_CodigoDoProduto.Text = string.Empty;
                focoNoTxtDeCodigoDeBarra();
            }
        }

        private bool JogaLinhaDoBancoParaALabelComOId()
        {
            //try
            //{
            DataRow LinhaProduto = null;
            if (produtoDao.selectFullProdutoPorIDComEstoque(Convert.ToInt32(txt_CodigoDoProduto.Text), "Nao").Rows.Count > 0)
            {
                LinhaProduto = produtoDao.selectFullProdutoPorIDComEstoque(Convert.ToInt32(txt_CodigoDoProduto.Text), "Nao").Rows[0];
                AtribuirValoresParaALabel(LinhaProduto);
                return true;
            }
            else
            {
                return false;
            }

            /*}
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                limparTxt();
                ZerarLabel();
                CarregaUmNaQuantidade();
                return false;
                // CarregaGrid();
            }*/
        }

        private void rdb_ComCodigoDeBarra_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Código Do Produto";
            limparTxt();
            DesabilitaBotoes();
            lbl_ValorRetiradoDoEstoque.Values.ExtraText = "??";
            focoNoTxtDeCodigoDeBarra();
            txt_Quantidade.Text = "1";
        }

        private void rdb_SemCodigoDeBarra_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "ID Do Produto";
            limparTxt();
            lbl_ValorRetiradoDoEstoque.Values.ExtraText = "??";
            DesabilitaBotoes();
            FocoNoTxtEUmNaQuantidade();

        }

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

        private void txt_CodigoDoProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdb_SemCodigoDeBarra.Checked)
                {
                    txt_CodigoDoProduto.MaxLength = 6;
                }
                else
                {
                    txt_CodigoDoProduto.MaxLength = 15;
                }
                if (txt_CodigoDoProduto.Text.Length == 0)
                {
                    DesabilitaBotoes();
                    lbl_ValorRetiradoDoEstoque.Values.ExtraText = "??";
                    focoNoTxtDeCodigoDeBarra();
                    CarregaGrid();
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }

            dgv_Estoque.ClearSelection();

        }

        private void txt_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void dgv_Estoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dgv_Estoque.Rows)
                {
                    //row.DefaultCellStyle.Font.Equals(Font.Bold);

                    if (Convert.ToInt32(row.Cells["Quantidade"].Value) <= Convert.ToInt32(row.Cells["MIN"].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(row.Cells["Quantidade"].Value) > Convert.ToInt32(row.Cells["MIN"].Value) && Convert.ToInt32(row.Cells["Quantidade"].Value) < Convert.ToInt32(row.Cells["MAX"].Value))//
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (Convert.ToInt32(row.Cells["Quantidade"].Value) >= Convert.ToInt32(row.Cells["MAX"].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Lime;
                    }
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Formulario: " + Erro.Message, "Erro");
            }


            // this.dgv_Estoque.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
        }

        private void frmAlterarEstoque_TextChanged(object sender, EventArgs e)
        {
            /*
            if (txt_CodigoDoProduto.Text.Length == 0)
            {78923409
                DesabilitaBotoes();
                lbl_ValorRetiradoDoEstoque.Values.ExtraText = "??";
                focoNoTxtDeCodigoDeBarra();
            }*/
        }

        private void txt_Quantidade_TextChanged(object sender, EventArgs e)
        {

        }





    }
}
