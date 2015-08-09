using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class frmDividiPagamento : Form
    {
        decimal VALORVENDA = 0, LUCROTOTAL = 0, TOTALNALABEL = 0, TotalL = 0;
        public frmDividiPagamento(decimal vendaTotal, decimal Lucro)
        {
            VALORVENDA = Math.Round(vendaTotal, 1);
            LUCROTOTAL = Lucro;
            InitializeComponent();
        }
        VendaDAO vendaDao = new VendaDAO();
        List<ExcluirEstoque> listExluirEstoque = new List<ExcluirEstoque>();
        EstoqueDAO estoqueDao = new EstoqueDAO();
        FiadoDAO fiadoDao = new FiadoDAO();
        private void frmDividiPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                txt_Total.Text = VALORVENDA.ToString();
                LoadCbbTypePay();
                TOTALNALABEL = VALORVENDA;
                AtribuiParaLabelTotal(TOTALNALABEL);
                EscondePanelTipoDePagamento();
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Atribuir Valores Para O Valor Total: " + Erro.Message, "");
            }
        }

        private void AtribuiParaLabelTotal(decimal TOTALNALABEL)
        {
            Math.Round(TOTALNALABEL, 1);
            lbl_Total.Values.ExtraText = TOTALNALABEL.ToString("C");
        }

        private void btn_GerarParcelas_Click(object sender, EventArgs e)
        {
            try
            {
                txt_valorParcela.Text = (VALORVENDA / Math.Round(Convert.ToDecimal(cbb_Parcelar.Text))).ToString(".00");
                TotalL = (LUCROTOTAL / Convert.ToDecimal(cbb_Parcelar.Text));
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Atribuir Valores Para O Valor Total: " + Erro.Message, "");
            }
        }
        private void AlterarCaixaComPagamentoEmDinheiro(Venda venda)
        {
            vendaDao.UpdateValorCaixa(venda.VendaTotal, "+", 1);
        }
        private void btn_ConcluirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (vendaDao.SelectValorCaixa().Rows.Count > 0)
                {
                    string valor = cbb_TipoPagamento.Text;

                    DialogResult dialog = MessageBox.Show("Deseja Confirmar A Venda Com Essa Forma De Pagamento: " + valor + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialog == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (TotalL != 0)
                        {
                            if (txt_ValorPago.Text.Length > 0 || cbb_TipoPagamento.Text.Equals("Fiado") || cbb_TipoPagamento.Text.Equals("Cartão"))
                            {
                                Venda venda = new Venda();

                                if (cbb_TipoPagamento.Text.Equals("Dinheiro"))
                                {

                                    if (JogaParaAVenda(venda))
                                    {
                                        AlterarCaixaComPagamentoEmDinheiro(venda);
                                        TOTALNALABEL -= Math.Round(Convert.ToDecimal(txt_valorParcela.Text), 2);
                                        AtribuiParaLabelTotal(Math.Round(TOTALNALABEL, 2));
                                        if (InserirVendaEBaixarEstoque(venda))
                                        {
                                            LimparTxtValorPago();
                                            if (TOTALNALABEL <= 01)
                                            {
                                                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                                            }
                                        }
                                        else
                                        {
                                            Message("Verifique Os Dados E Tente Novamente", "Aviso");

                                        }
                                    }
                                    else
                                    {
                                        Message("Verifique Os Dados E Tente Novamente", "Aviso");

                                    }
                                }
                                else if (cbb_TipoPagamento.Text.Equals("Fiado"))
                                {

                                    if (JogaParaAVenda(venda))
                                    {
                                        frmPagamentoFiado show = new frmPagamentoFiado();
                                        DialogResult D = show.ShowDialog();
                                        if (D == System.Windows.Forms.DialogResult.Yes)
                                        {
                                            Fiado.Valor = venda.VendaTotal;
                                            Fiado.IdFuncionario = vendaDao.SelectIdUsuarioPorNome(NomeLoginGlobal.Nome);

                                            if (JogaParaAVenda(venda))
                                            {
                                                TOTALNALABEL -= Math.Round(Convert.ToDecimal(txt_valorParcela.Text), 2);
                                                AtribuiParaLabelTotal(Math.Round(TOTALNALABEL, 2));
                                                if (InserirVendaEBaixarEstoque(venda))
                                                {
                                                    LimparTxtValorPago();
                                                    if (fiadoDao.InsertFiado())
                                                    {
                                                        if (fiadoDao.SelectFiado().Rows.Count > 0 && TOTALNALABEL <= 01)
                                                        {
                                                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Message("Verifique Os Dados E Tente Novamente", "Aviso");

                                                    }
                                                }
                                                else
                                                {
                                                    Message("Verifique Os Dados E Tente Novamente", "Aviso");
                                                }
                                            }
                                            else
                                            {
                                                Message("Verifique Os Dados E Tente Novamente", "Aviso");

                                            }
                                        }

                                    }
                                    else
                                    {
                                        Message("Verifique Os Dados E Tente Novamente", "Aviso");

                                    }
                                }
                                if (cbb_TipoPagamento.Text.Equals("Cartão"))
                                {

                                    if (JogaParaAVenda(venda))
                                    {
                                        LimparTxtValorPago();
                                        TOTALNALABEL -= Math.Round(Convert.ToDecimal(txt_valorParcela.Text), 2);
                                        AtribuiParaLabelTotal(Math.Round(TOTALNALABEL, 2));

                                        if (InserirVendaEBaixarEstoque(venda))
                                        {
                                            if (TOTALNALABEL <= 01)
                                            {
                                                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                                            }
                                        }
                                        else
                                        {
                                            Message("Verifique Os Dados E Tente Novamente", "Aviso");

                                        }
                                    }
                                    else
                                    {
                                        Message("Verifique Os Dados E Tente Novamente", "Aviso");
                                    }
                                }

                            }
                            else
                            {
                                Message("É Necessario Inserir O Valor Pago Para Concluir A Venda", "Aviso");
                                this.ActiveControl = txt_ValorPago;
                            }
                        }
                        else
                        {
                            Message("É Necessario Existir Um Valor Antes De Gerar Um Venda", "Aviso");
                        }
                    }
                    else
                    {
                        LimparTxtValorPago();
                    }

                }
                else
                {
                    Message("Não É Possível Concluir Uma Venda Com O Caixa Vazio", "Aviso");
                }
                LoadCbbTypePay();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Salvar As Vendas: " + Erro.Message, "Erro");
                LimparTxtValorPago();
            }

        }
        private bool InserirVendaEBaixarEstoque(Venda venda)
        {
            if (vendaDao.InsertVendas(venda))
            {
                #region validacao estoque

                //bool certoExcluiEstoque = true;
                //certoExcluiEstoque = ExcluiComanda(certoExcluiEstoque);
                //ValidacaoEstoque(certoExcluiEstoque);
                #endregion
                return true;

            }
            else
            {
                Message("Não Foi Possível Salvar A Venda, Verifique Se Os Dados Estão Corretos", "Aviso");
                return false;
            }
        }
        //private void ValidacaoEstoque(bool certoExcluiEstoque)
        //{
        //    if (certoExcluiEstoque)
        //    {

        //        MessageBox.Show("Venda Concluida", "Aviso");

        //    }
        //    else
        //    {
        //        string valoreNegativos = "";

        //        foreach (DataRow Linha in estoqueDao.SelectEstoqueNegativo().Rows)
        //        {
        //            valoreNegativos += " Nome: " + Linha["Nome"].ToString() + " Quantidate: " + Linha["Quantidade"].ToString() + ".";
        //        }
        //        Message("Venda Salva Com Sucesso," + " Ma Existem Items Que Estão Negativo No Estoque, É Necessario Dar Entrada No Mesmo Corretamente Para Evitar Esse Tipo De Erro, Informe Um Funcionario Para Verificar A"
        //            + " Quantidade Do Produto: " + valoreNegativos + " E Atualizar A Quantidade Correta Para O Erro Não Persistir", "Aviso");

        //    }
        //}
        //private bool ExcluiComanda(bool certoExcluiEstoque)
        //{
        //    try
        //    {
        //        foreach (ExcluirEstoque estoque in listExluirEstoque)
        //        {
        //            certoExcluiEstoque = estoqueDao.ExlcuiEstoqueAposSalvar(estoque);
        //        }
        //        return certoExcluiEstoque;
        //    }
        //    catch (Exception Erro)
        //    {

        //        Message("Erro Ao Excluir Produtos Da Comanda Os Valores: " + Erro.Message, "Erro");
        //        return false;
        //    }
            
        //}
        private bool JogaParaAVenda(Venda venda)
        {

            try
            {
                venda.VendaTotal = Convert.ToDecimal(txt_valorParcela.Text);
                venda.LucroTotal = Convert.ToDecimal(TotalL);
                venda.Data = DateTime.Now.ToShortDateString();
                venda.IdUsuario = vendaDao.SelectIdUsuarioPorNome(NomeLoginGlobal.Nome);
                venda.IdTipoPagamento = Convert.ToInt32(vendaDao.SelectIDTipoPagementoPorNome(cbb_TipoPagamento.Text).Rows[0]["Id"]);
                if (venda.IdTipoPagamento != 0 && venda.IdUsuario != 0 && venda.LucroTotal != 0 &&
                    venda.VendaTotal != 0 && venda.Data != "")
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

                Message("Erro Ao Atribuir Os Valores: " + Erro.Message, "Erro");
                return false;
            }
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_Troco_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorPago, total, valorTotal;
                ValorPago = Convert.ToDouble(txt_ValorPago.Text);
                valorTotal = Convert.ToDouble(txt_valorParcela.Text);
                if (ValorPago < valorTotal)
                {
                    Message("É Necessario Inserir Um Valor Maior Que O Valor Da Parcela", "Aviso");
                    LimparTxtValorPago();
                    FocoNoTxtValorPago();
                }
                else
                {
                    total = ValorPago - valorTotal;
                    lbl_ValorDoTroco.Values.ExtraText = total.ToString("C");
                }


            }
            catch (Exception Erro)
            {

                Message("Erro Ao Gerar O Troco: " + Erro.Message, "Erro");
            }
        }

        private void FocoNoTxtValorPago()
        {
            this.ActiveControl = txt_ValorPago;
        }

        private void LimparTxtValorPago()
        {
            txt_ValorPago.Text = string.Empty;
        }
        private void LoadCbbTypePay()
        {
            try
            {
                cbb_TipoPagamento.DisplayMember = "TIPO";
                cbb_TipoPagamento.DataSource = vendaDao.SelectTipoPagamento();
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar Os Dados: " + Erro.Message, "Erro");
            }

        }

        private void txt_valorParcela_TextChanged(object sender, EventArgs e)
        {
            if (txt_valorParcela.Text.Length > 0)
            {
              
                MostraPanelTipoDePagamento();
            }
        }

        private void MostraPanelTipoDePagamento()
        {
            gpb_TipoDePagamento.Visible = true;
        }

        private void EscondePanelTipoDePagamento()
        {
            gpb_TipoDePagamento.Visible = false;
        }

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txt_ValorPago_TextChanged(object sender, EventArgs e)
        {
            if (txt_ValorPago.Text.Length > 7)
            {
                //if (!txt_ValorPago.Text.Contains("."))
                //{
                txt_ValorPago.Text = string.Empty;
                Message("Valor Inserido Incorreto, É Necessario Preencher Os Campos Corretamente", "Aviso");
                this.ActiveControl = txt_ValorPago;
                //   }
            }
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

        private void cbb_TipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TipoPagamento.Text.Equals("Dinheiro"))
            {
                MostrarTroco();
            }
            else if (cbb_TipoPagamento.Text.Equals("Fiado"))
            {
                EsconderTroco();
            }
            else if (cbb_TipoPagamento.Text.Equals("Cartão"))
            {
                EsconderTroco();
            }
        }

        private void EsconderTroco()
        {
            gpb_GerarTroco.Visible = false;
        }

        private void MostrarTroco()
        {
            gpb_GerarTroco.Visible = true;
        }

    }
}
