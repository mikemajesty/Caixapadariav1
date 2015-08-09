using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        private double Total = 0, lucroTotal = 0;
        //  private static decimal totalEnviar = 0;
        List<ExcluirEstoque> listExluirEstoque = new List<ExcluirEstoque>();
        List<Comanda> listComanda = new List<Comanda>();

        EstoqueDAO estoqueDao = new EstoqueDAO();
        ProdutoDAO produtoDao = new ProdutoDAO();
        ExcluirEstoque exckui = new ExcluirEstoque();
        VendaDAO vendaDao = new VendaDAO();
        ComandaDAO comandaDao = new ComandaDAO();
        FiadoDAO fiadoDao = new FiadoDAO();
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
                k_rdbSemCodigoDeBarra.Checked = true;
                k_ComCodigoDeBarra.Checked = true;
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

        private void frmVendas_Load(object sender, EventArgs e)
        {

            try
            {

                //ClienteDAO clienteDao = new ClienteDAO();
                //if (clienteDao.selectClienteSemValor().Rows.Count > 0)
                //{
                //    ShowButtonFiado();
                //}
                 MarcaOsRadioButton();
                //EsconderTipoDePagamento();
                if (fiadoDao.SelectFiado().Rows.Count > 0)
                {
                    ShowButtonFiado();
                }
                else
                {
                    HideButtonFiado();
                }
                // DesaparecerTxtProduto();
                if (vendaDao.SelectValorCaixa().Rows.Count > 0)
                {
                    Message("O Caixa Esta Em Aberto, Verifique Se Esse Valor É O Valor Atual Ou Do Dia Anterior, Se For Do Dia Anteriro Aperte O Botão [Fechar Caixa] E Atualize Com O Valor Correspondente Ao Valor Do Dia", "Aviso");
                }
                //NaoChecarDividirComanda();
               // FonoNotxtProduto();
                if (vendaDao.SelectValorCaixa().Rows.Count == 0)
                {
                    Message("Para Não Ocorrer Problemas É Necessario Abrir O Caixa Com Um Determinado Valor", "Aviso");
                    frmAlterarCaixa mostra = new frmAlterarCaixa();
                    mostra.ShowDialog();
                    /*
                    if (vendaDao.SelectValorCaixa().Rows.Count > 0)
                    {
                        
                    }*/
                }
                lbl_CaixaValor.Values.ExtraText = CarregarValorCaixa();
                tmp_AtualizaCaixa.Start();
                //k_rdbSemComanda.Checked = true;

                LoadCbbTypePay();


                CarregarTxtComUm();

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Metodo De Pagamento: " + Erro.Message, "");
            }


        }

        private void MarcaOsRadioButton()
        {
            k_rdbComComanda.Checked = true;
            k_ComCodigoDeBarra.Checked = true;
        }

        private void LoadCbbTypePay()
        {
            cbb_TipoPagamento.DisplayMember = "TIPO";
            cbb_TipoPagamento.DataSource = vendaDao.SelectTipoPagamento();
        }

        private void HideButtonFiado()
        {
            btn_PagamentoFiado.Visible = false;
        }

        private void ShowButtonFiado()
        {
            btn_PagamentoFiado.Visible = true;
        }

        //private void NaoChecarDividirComanda()
        //{
        //    ccb_DividiComanda.Checked = false;
        //}

        private string CarregarValorCaixa()
        {
            decimal valor = 0;
            if (vendaDao.SelectValorCaixa().Rows.Count > 0)
            {
                valor = Convert.ToDecimal(vendaDao.SelectValorCaixa().Rows[0]["Valor"]);
                return valor.ToString("C");
            }
            else
            {
                return valor.ToString("C");
            }
        }
        private void MostrarPanel()
        {
            pnl_Esconde.Visible = true;
        }
        private void EscondePanel()
        {
            pnl_Esconde.Visible = false;
        }
        private void k_rdbSemComanda_CheckedChanged(object sender, EventArgs e)
        {
            if (k_rdbSemComanda.Checked)
            {
                EscondeTxtELbaleQuandoORarioButtonEstiverChecado();
                FonoNotxtProduto();
                // MostraTipoDePagamento();
                //MostrarPanel();

            }
        }

        private void FonoNotxtProduto()
        {
            this.ActiveControl = txt_Produto;
        }
        private void k_rdbComComanda_CheckedChanged(object sender, EventArgs e)
        {
            if (k_rdbComComanda.Checked)
            {
                ApareceTxtELbaleQuandoORarioButtonEstiverChecado();
                // MostraTipoDePagamento();
            }
        }
        private void EscondeTxtELbaleQuandoORarioButtonEstiverChecado()
        {

            //    lbl_CodProduto.Visible = false;
            txt_CodigoProduto.Visible = false;
        }
        private void ApareceTxtELbaleQuandoORarioButtonEstiverChecado()
        {
            lbl_CodProduto.Visible = true;
            txt_CodigoProduto.Visible = true;
            this.ActiveControl = txt_CodigoProduto;
        }
        private void txt_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (k_ComCodigoDeBarra.Checked || k_rdbSemCodigoDeBarra.Checked)
            {

                if ((Keys)e.KeyChar == Keys.Enter)
                {

                    if (txt_Quantidade.Text.Length > 0 && txt_Produto.Text.Length > 0)
                    {
                        if (k_rdbSemCodigoDeBarra.Checked == true && k_ComCodigoDeBarra.Checked == false)
                        {
                            try
                            {

                                ValorComComanda volorComanda = new ValorComComanda();
                                if (produtoDao.SelectProdutoPorId(Convert.ToInt32(txt_Produto.Text), "Nao"))//produtoDao.SelectProdutoPorId(produto, "Pes")
                                {


                                    DataRow Linha = produtoDao.selectProdutoSomadoSemComandaPorId(Convert.ToInt32(txt_Quantidade.Text), Convert.ToInt32(txt_Produto.Text)).Rows[0];

                                    if (Linha != null)
                                    {
                                        txt_Produto.Text = string.Empty;
                                        AdicionarItemsNoListBox(Linha, volorComanda);
                                    }
                                    else
                                    {
                                        Message("Não Foi Encontrado Produto Com O ID: " + txt_CodigoProduto.Text + " Verifique Se O ID Corresponde A Um Produto Com Peso", "Aviso");
                                        LimparTxtDeCodigo();
                                        FonoNotxtProduto();
                                    }
                                }
                                else
                                {
                                    Message("Codigo Não Corresponde a Um Produto", "Aviso");
                                    LimparTxtDeCodigo();
                                    FonoNotxtProduto();
                                }

                            }
                            catch (Exception Erro)
                            {
                                LimparTxtDeCodigo();
                                txt_Produto.Text = string.Empty;
                                Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                            }
                        }
                        else if (k_ComCodigoDeBarra.Checked == true && k_rdbSemCodigoDeBarra.Checked == false)
                        {

                            try
                            {
                                ValorComComanda volorComanda = new ValorComComanda();
                                /*if (produtoDao.selectFullProdutoPorIDComEstoque(Convert.ToInt32(txt_Produto.Text),"Nao") == null)
                                {
                                    MessageBox.Show("Nulão");
                                }*/
                                if (produtoDao.SelectProdutoPorCodigo(txt_Produto.Text, "Nao"))
                                {
                                    //MessageBox.Show("Test");

                                    DataRow Linha = produtoDao.selectProdutoSomadoSemComandaPorCodigo(Convert.ToInt32(txt_Quantidade.Text), txt_Produto.Text).Rows[0];
                                    if (Linha != null)
                                    {
                                        txt_Produto.Text = string.Empty;
                                        AdicionarItemsNoListBox(Linha, volorComanda);
                                    }
                                    else
                                    {
                                        Message("Não Foi Encontrado Produto Com O Codigo De Barra: " + txt_CodigoProduto.Text + " Verifique Se O Codigo Corresponde A Um Produto Com Peso", "Aviso");
                                        LimparTxtDeCodigo();
                                        FonoNotxtProduto();
                                    }
                                }
                                else
                                {
                                    Message("Codigo Não Corresponde a Um Produto", "Aviso");
                                    LimparTxtDeCodigo();
                                    FonoNotxtProduto();
                                }
                            }
                            catch (Exception Erro)
                            {
                                LimparTxtDeCodigo();
                                Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                            }
                        }
                    }
                    else
                    {
                        txt_Produto.Text = string.Empty;
                        Message("É Necessario Selecionar Um Produto E Uma Quantidade", "Aviso");
                        FonoNotxtProduto();
                    }
                }

            }
            else
            {
                Message("Marque Um Tipo[Com Código De Barra/Sem Código de Barra] Antes De Encaminhar O Produto Para A Venda", "Aviso");
                LimparTxtDeCodigo();
            }
            //}
            //else
            //{
            //    Message("Antes De Apertar [Enter] É Necessario Selecionar Um Produto","Aviso");
            //    FonoNotxtProduto();
            //}
        }
        private void LimparTxtDeCodigo()
        {
            txt_CodigoProduto.Text = string.Empty;
            txt_Produto.Text = string.Empty;

        }
        private void AdicionarItemsNoListBox(DataRow Linha, ValorComComanda volorComanda)
        {
            try
            {
                if (Convert.ToInt32(Linha["Quantidade"]) != 0)
                {
                    //  if ()
                    //{

                    //}
                    volorComanda.Nome = Linha["NOME"].ToString();
                    volorComanda.Id = Convert.ToInt32(Linha["ID"]);
                    exckui.Id = volorComanda.Id;
                    volorComanda.PrecoTotal = Convert.ToDouble(Linha["TOTAL"]);
                    volorComanda.Quantidade = Convert.ToInt32(Linha["Quantidade"]);
                    exckui.Quantidade = volorComanda.Quantidade;
                    lucroTotal += Convert.ToDouble(Linha["Lucro"]);
                    listExluirEstoque.Add(exckui);
                    exckui = new ExcluirEstoque();
                    string ValoresParaMostrar = volorComanda.ToString();
                    Total += volorComanda.PrecoTotal;
                    lbl_Total.Values.ExtraText = Total.ToString("C");
                    rtb_MiniRelatorio.Text += ValoresParaMostrar;
                }
                else
                {
                    volorComanda = new ValorComComanda();
                    volorComanda.Nome = Linha["NOME"].ToString();
                    volorComanda.Id = Convert.ToInt32(Linha["ID"]);
                    exckui.Id = volorComanda.Id;
                    volorComanda.PrecoTotal = Convert.ToDouble(Linha["TOTAL"]);
                    exckui.Quantidade = 0;
                    lucroTotal += Convert.ToDouble(Linha["Lucro"]);
                    listExluirEstoque.Add(exckui);
                    exckui = new ExcluirEstoque();
                    string ValoresParaMostrar = volorComanda.ToString();
                    Total += volorComanda.PrecoTotal;
                    lbl_Total.Values.ExtraText = Total.ToString("C");
                    rtb_MiniRelatorio.Text += ValoresParaMostrar;
                }

            }
            catch (Exception Erro)
            {
                LimparTxtDeCodigo();
                Message("Não Foi Possível Carregar Os Items: " + Erro, "Erro");
            }
        }
        private void btn_Troco_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ckb_PagamentoParcial.Checked)
                //{

                //}
                if (txt_ValorPago.Text.Length > 0 && rtb_MiniRelatorio.Text.Length > 0/* && ckb_PagamentoParcial.Checked == false*/)
                {

                    double troquinho = Convert.ToDouble(txt_ValorPago.Text);
                    double valorzinho = Convert.ToDouble(lbl_Total.Values.ExtraText.Substring(2, lbl_Total.Values.ExtraText.Length - 2));

                    if (troquinho >= valorzinho)
                    {
                        double ValorPago;
                        ValorPago = Convert.ToDouble(txt_ValorPago.Text);
                        Total = (ValorPago - Convert.ToDouble(lbl_Total.Values.ExtraText.Substring(2, lbl_Total.Values.ExtraText.Length - 2)));
                        if (vendaDao.SelectValorCaixaCompleto() < Total)
                        {
                            Message("Valor Do Troco é Maior Que o Valor Resgistrado No Caixa, Atualize o Caixa Corretamente", "Aviso");

                        }
                        else
                        {
                            lbl_ValorDoTroco.Values.ExtraText = Total.ToString("C");

                        }

                    }
                    else
                    {
                        txt_ValorPago.Text = string.Empty;
                        Message("Valor Inserido No Campo[Valor Pago] É Menor Que O Valor Total, Verifique Os Dados Corretamente", "Aviso");
                        this.ActiveControl = txt_ValorPago;
                    }


                }
                else
                {
                    Message("Antes De Gerar O Troco Insira O Valor Pago Pelo Cliente e Uma Venda", "Aviso");
                    FonoNotxtProduto();
                    txt_ValorPago.Text = string.Empty;
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Gerar O Troco, Verifique Os Valores: " + Erro.Message, "Erro");
            }

        }

        private void btn_ConcluirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                #region irrelevante
                //if (ckb_PagamentoParcial.Checked)
                ////{
                //   Venda venda = new Venda();
                //    JogaParaAVenda(venda);
                //    decimal valorPagoParcialmente = Convert.ToDecimal(txt_ValorPago.Text);
                //    //venda.LucroTotal
                //    if (venda.VendaTotal > 0)
                //    {
                //        if (venda.VendaTotal > valorPagoParcialmente)
                //        {

                //            if (valorPagoParcialmente > 0)
                //            {


                //                venda.VendaTotal -= valorPagoParcialmente;
                //                lbl_Total.Values.ExtraText = venda.VendaTotal.ToString("C");
                //                InserirVendaEBaixarEstoque(venda);
                //                return;
                //            }
                //            else
                //            {
                //                Message("Antes De Gerar Um Pagamento Parcial É Necessario Inserir O Valor A Ser Discontado", "Aviso");
                //                this.ActiveControl = txt_ValorPago;
                //                return;
                //            }
                //        }

                //    }
                //    ///////////////////////////////////////////////////////
                //    //bool certoExcluiEstoque = true;
                //    //certoExcluiEstoque = ExcluiComanda(certoExcluiEstoque);
                //    //ValidacaoEstoque(certoExcluiEstoque);
                //    //CarregarTxtComUm();
                //    return;
                //}
                //if (ckb_PagamentoParcial.Checked == false)
                //{
                #endregion

                if (vendaDao.SelectValorCaixa().Rows.Count > 0)
                {
                    string valor = cbb_TipoPagamento.Text;

                    DialogResult dialog = MessageBox.Show("Deseja Confirmar A Venda Com Essa Forma De Pagamento: " + valor + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialog == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (lucroTotal != 0)
                        {
                            if (txt_ValorPago.Text.Length > 0 || cbb_TipoPagamento.Text.Equals("Fiado") || cbb_TipoPagamento.Text.Equals("Cartão"))
                            {
                                Venda venda = new Venda();

                                if (cbb_TipoPagamento.Text.Equals("Dinheiro"))
                                {
                                    JogaParaAVenda(venda);
                                    AlterarCaixaComPagamentoEmDinheiro(venda);
                                    ///listComanda.Clear();
                                }
                                else if (cbb_TipoPagamento.Text.Equals("Fiado"))
                                {
                                    JogaParaAVenda(venda);
                                    frmPagamentoFiado show = new frmPagamentoFiado();
                                    DialogResult D = show.ShowDialog();
                                    if (D == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        Fiado.Valor = venda.VendaTotal;
                                        Fiado.IdFuncionario = vendaDao.SelectIdUsuarioPorNome(NomeLoginGlobal.Nome);
                                        fiadoDao.InsertFiado();
                                        if (fiadoDao.SelectFiado().Rows.Count.Equals(0))
                                        {
                                            HideButtonFiado();
                                            //listComanda.Clear();
                                        }
                                        else
                                        {
                                            ShowButtonFiado();
                                        }
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                if (cbb_TipoPagamento.Text.Equals("Cartão"))
                                {
                                    JogaParaAVenda(venda);
                                }
                                InserirVendaEBaixarEstoque(venda);
                            }
                            else
                            {
                                Message("É Necessario Inserir O Valor Pago Para Concluir A Venda", "Aviso");
                                this.ActiveControl = txt_ValorPago;
                            }
                        }
                        else
                        {
                            Message("Não Foi Gerado Nenhuma Venda", "Aviso");
                            LimparTxtDeCodigo();
                            LimparListBoxDeInformacao();
                            FonoNotxtProduto();
                        }
                    }
                    else
                    {
                        ZerarLabel();
                        ZerarLista();
                        ZerarTotal();
                        ZerarValorPago();
                        Message("Venda Cancelada", "Aviso");
                        rtb_MiniRelatorio.Text = string.Empty;
                        // x = new Comanda();
                        listComanda.Clear();
                        listExluirEstoque.Clear();
                    }

                }
                else
                {
                    Message("Não É Possível Concluir Uma Venda Com O Caixa Vazio", "Aviso");
                    ZerarLabel();
                    ZerarLista();
                    ZerarTotal();
                    rtb_MiniRelatorio.Text = string.Empty;
                    ZerarValorPago();
                    listComanda.Clear();
                    listExluirEstoque.Clear();
                }
                //EsconderTipoDePagamento();
                LoadCbbTypePay();
                //}
                CarregarTxtComUm();
                LimparListBoxDeInformacao();
                LimparTxtDeCodigo();
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Salvar As Vendas: " + Erro.Message, "Erro");
                ZerarLabel();
                ZerarLista();
                ZerarTotal();
                ZerarValorPago();
                LoadCbbTypePay();
                CarregarTxtComUm();
            }


        }

        private void InserirVendaEBaixarEstoque(Venda venda)
        {
            if (vendaDao.InsertVendas(venda))
            {
                //DesaparecerTxtProduto();
                CarregarComanda();
                listComanda.Clear();
                bool certoExcluiEstoque = true;
                certoExcluiEstoque = ExcluiComanda(certoExcluiEstoque);
                listExluirEstoque.Clear();
                ValidacaoEstoque(certoExcluiEstoque);
                CarregarTxtComUm();
                FonoNotxtProduto();

            }
            else
            {
                Message("Não Foi Possível Salvar A Venda, Verifique Se Os Dados Estão Corretos", "Aviso");
            }
        }

        private void ValidacaoEstoque(bool certoExcluiEstoque)
        {
            if (certoExcluiEstoque)
            {
                //DialogResult DIALOG  = MessageBox.Show("Venda Concluida, Deseja Inserir Mais Itens Nessa Comanda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (DIALOG == System.Windows.Forms.DialogResult.Yes)
                //{
                //    txt_ValorPago.Text = string.Empty;
                //}
                //else
                //{
                timer1.Start();
                MessageBox.Show("Venda Concluida", "Aviso");
                //if (ckb_PagamentoParcial.Checked == false)
                //{
                LimparTxtDeCodigo();
                LimparListBoxDeInformacao();
                ZerarLabel();
                ZerarTotal();
                ZerarLista();
                ZerarValorPago();
                // }

                //}                                        
            }
            else
            {
                string valoreNegativos = "";

                foreach (DataRow Linha in estoqueDao.SelectEstoqueNegativo().Rows)
                {

                    valoreNegativos += " Nome: " + Linha["Nome"].ToString() + " Quantidate: " + Linha["Quantidade"].ToString() + ".";
                }
                Message("Venda Salva Com Sucesso," + " Ma Existem Items Que Estão Negativo No Estoque, É Necessario Dar Entrada No Mesmo Corretamente Para Evitar Esse Tipo De Erro, Informe Um Funcionario Para Verificar A"
                    + " Quantidade Do Produto: " + valoreNegativos + " E Atualizar A Quantidade Correta Para O Erro Não Persistir", "Aviso");
                LimparTxtDeCodigo();
                LimparListBoxDeInformacao();
                txt_ValorPago.Text = string.Empty;
                ZerarLabel();
                ZerarTotal();
            }
        }

        private bool ExcluiComanda(bool certoExcluiEstoque)
        {
            foreach (ExcluirEstoque estoque in listExluirEstoque)
            {
                certoExcluiEstoque = estoqueDao.ExlcuiEstoqueAposSalvar(estoque);
            }
            return certoExcluiEstoque;
        }

        private void CarregarComanda()
        {
            foreach (Comanda comanda in listComanda)
            {
                comandaDao.DeleteComandaComVendaAtiva(comanda);
            }
        }

        private void JogaParaAVenda(Venda venda)
        {

            venda.VendaTotal = Convert.ToDecimal(lbl_Total.Values.ExtraText.Substring(2, lbl_Total.Values.ExtraText.Length - 2));
            venda.LucroTotal = Convert.ToDecimal(lucroTotal);
            venda.Data = DateTime.Now.ToShortDateString();
            venda.IdUsuario = vendaDao.SelectIdUsuarioPorNome(NomeLoginGlobal.Nome);
            venda.IdTipoPagamento = Convert.ToInt32(vendaDao.SelectIDTipoPagementoPorNome(cbb_TipoPagamento.Text).Rows[0]["Id"]);
            //totalEnviar = venda.VendaTotal;
        }

        private void DesaparecerTxtProduto()
        {
            txt_Produto.Visible = false;
        }

        private void AlterarCaixaComPagamentoEmDinheiro(Venda venda)
        {
            vendaDao.UpdateValorCaixa(venda.VendaTotal, "+", 1);
        }

        private void ZerarValorPago()
        {
            txt_ValorPago.Text = string.Empty;
        }

        private void ZerarLista()
        {
            listExluirEstoque.Clear();
        }

        private void ZerarTotal()
        {
            lucroTotal = 0;
            Total = 0;
        }

        private void ZerarLabel()
        {
            lbl_Total.Values.ExtraText = "00.00";
            lbl_ValorDoTroco.Values.ExtraText = "00.00";
        }

        private void LimparListBoxDeInformacao()
        {
            rtb_MiniRelatorio.Text = string.Empty;
        }


        private void CarregarTxtComUm()
        {
            txt_Quantidade.Text = "1";
        }
        private void txt_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text.Length > 2)
            {
                txt_Quantidade.Text = string.Empty;
                Message("Valor Inserido Incorreto, É Necessario Preencher Os Campos Corretamente", "Aviso");
            }
        }


        private void txt_Produto_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text.Length > 0)
            {

                MostraTipoDePagamento();

                if (txt_Produto.Text.Length > 15)
                {
                    txt_Produto.Text = string.Empty;
                    Message("Valor Inserido Incorreto, É Necessario Preencher Os Campos Corretamente", "Aviso");

                }
            }


        }

        //private void EsconderTipoDePagamento()
        //{
        //    gpb_TipoDePagamento.Visible = false;
        //}

        private void MostraTipoDePagamento()
        {
            gpb_TipoDePagamento.Visible = true;
        }

        private void txt_CodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (k_rdbComComanda.Checked)
                {

                    try
                    {
                        if (produtoDao.selectValorDaComanda(txt_CodigoProduto.Text).Rows.Count > 0)
                        {
                            ValorComComanda volorComanda = new ValorComComanda();

                            int LinhaAPercorrer = produtoDao.selectValorDaComanda(txt_CodigoProduto.Text).Rows.Count;

                            Comanda comanda = new Comanda();

                            comanda.Codigo = txt_CodigoProduto.Text;


                            Comanda x = (listComanda.Find(c => c.Codigo == comanda.Codigo));
                            //listComanda.FindAll(c=>c.Codigo == comanda.Codigo);
                            //bool jaExiste =(listComanda.Where(c=>c.Codigo ==comanda.Codigo).Count() > 0 );


                            if (x == null)
                            {

                                listComanda.Add(comanda);
                                x = null;
                                JogaValoresparaComanda(volorComanda);
                            }
                            else
                            {
                                Message("Não É Permitido Passar A Mesma Comanda Mais De Uma Vez", "Aviso");
                                LimparTxtDeCodigo();
                            }


                        }
                        else
                        {
                            Message("Não Existe Produtos Adicionados Nessa Comanda, Ou Comanda Inexistente", "Aviso");
                            LimparTxtDeCodigo();
                            // x = new Comanda();
                        }
                    }
                    catch (Exception Erro)
                    {
                        LimparTxtDeCodigo();
                        Message("Erro Ao Carregar O Produto: " + Erro.Message, "Erro");
                    }
                }
                else
                {
                    LimparTxtDeCodigo();
                    Message("Escolha O Modo De Pagamento[Com Comanda/Sem Comanda] Antes De Encaminhar O Produto Para A Venda", "");
                }
            }
        }

        private void JogaValoresparaComanda(ValorComComanda volorComanda)
        {
            foreach (DataRow LinhaPreco in produtoDao.selectValorDaComandaPorPreco(txt_CodigoProduto.Text).Rows)
            {
                if (Convert.ToInt32(LinhaPreco["Quantidade"]) == 0)
                {
                    lucroTotal += Convert.ToDouble(LinhaPreco["totalMax"]);

                }


            }

            foreach (DataRow Linha in produtoDao.selectValorDaComanda(txt_CodigoProduto.Text).Rows)
            {

                // if (volorComanda.Quantidade >= 1)
                //{
                volorComanda.Id = Convert.ToInt32(Linha["ID"]);
                volorComanda.IdComanda = Convert.ToInt32(Linha["IDCOMANDA"]);
                volorComanda.Nome = Linha["Nome"].ToString();
                volorComanda.IdProduto = Convert.ToInt32(Linha["IDPRODUTO"]);
                //exckui.Id = volorComanda.IdProduto;
                volorComanda.PrecoTotal = Convert.ToDouble(Linha["PRECOTOTAL"]);
                volorComanda.Quantidade = Convert.ToInt32(Linha["QUANTIDADE"]);
                //exckui.Quantidade = volorComanda.Quantidade;
                //listExluirEstoque.Add(exckui);
                //  exckui = new ExcluirEstoque();
                //------------------------
                //-------------------
                lucroTotal += Convert.ToDouble(Linha["total"]);

                // }

                //--------------------
                string ValoresParaMostrar = null;
                if (Convert.ToInt32(Linha["QUANTIDADE"]) != 0)
                {
                    ValoresParaMostrar = string.Format("Nome: {0} - Quantidade: {1}x - Preço Total: {2}",
volorComanda.Nome,
volorComanda.Quantidade,
volorComanda.PrecoTotal.ToString("C") + "\n");
                }
                else
                {
                    ValoresParaMostrar = string.Format("Nome: {0} - Peso - Preço Total: {1}",
volorComanda.Nome,
volorComanda.PrecoTotal.ToString("C") + "\n");
                }


                Total += volorComanda.PrecoTotal;
                lbl_Total.Values.ExtraText = Total.ToString("C");


                rtb_MiniRelatorio.Text += ValoresParaMostrar;
                txt_CodigoProduto.Text = string.Empty;


            }
        }

        private void txt_CodigoProduto_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_CodigoProduto.Text.Length > 15)
            {
                txt_CodigoProduto.Text = string.Empty;
                Message("Valor Inserido Incorreto, É Necessario Preencher Os Campos Corretamente", "Aviso");

            }
            if (txt_CodigoProduto.Text.Length > 0/* 1 && rtb_MiniRelatorio.Text.Length >0*/)
            {
                MostraTipoDePagamento();
            }
        }

        private void txt_ValorPago_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_ValorPago.Text.Length > 7)
            {
                //if (!txt_ValorPago.Text.Contains("."))
                //{
                txt_ValorPago.Text = string.Empty;
                Message("Valor Inserido Incorreto, É Necessario Preencher Os Campos Corretamente", "Aviso");
                //   }
            }

        }

        private void k_ComCodigoDeBarra_CheckedChanged_1(object sender, EventArgs e)
        {
            lbl_CodigoOuIdProduto.Text = "Código De Barra";
            txt_Produto.Text = string.Empty;
            //MostrarPanel();
            //if (k_ComCodigoDeBarra.Checked == true)
            //{
            //    txt_Produto.Visible = true;
            //    gpb_TipoDePagamento.Visible = true;
            //}
            //////////////////
            ////////////////////
            /////////////////////
           FonoNotxtProduto();
        }

        private void k_rdbSemCodigoDeBarra_CheckedChanged_1(object sender, EventArgs e)
        {
            lbl_CodigoOuIdProduto.Text = "ID Do Produto";
            txt_Produto.Text = string.Empty;
            //MostrarPanel();
            //if (k_rdbSemCodigoDeBarra.Checked)
            //{
            //    txt_Produto.Visible = true;
            //    gpb_TipoDePagamento.Visible = true;
            //}
            FonoNotxtProduto();
        }

        private void tmp_AtualizaCaixa_Tick(object sender, EventArgs e)
        {
            try
            {
                if (vendaDao.SelectValorCaixa().Rows.Count > 0)
                {
                    double valor = Convert.ToDouble(vendaDao.SelectValorCaixa().Rows[0]["Valor"]);

                    if (valor > 0)
                    {
                        lbl_CaixaValor.Values.ExtraText = valor.ToString("C");
                    }
                }
                else
                {
                    lbl_CaixaValor.Values.ExtraText = "00.00";
                }

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Valor Do Caixa: " + Erro.Message, "Erro");
            }
        }

        private void btn_AlterarCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlterarCaixa alterarCaixa = new frmAlterarCaixa();
                DialogResult result = alterarCaixa.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (CarregarValorCaixa().Equals(0.ToString("C")))
                    {
                        this.Close();
                    }


                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Alterar O Caixa: " + Erro.Message, "Aviso");
            }

            //else
            //{
            //    Message("Não Foi Possível Alterar O Valor Do Caixa, Antes De Alterar O Caixa Insira O Valor Corretamente","Aviso");
            //}
        }

        private void btn_FecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Deseja Realmente Fechar O Caixa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    if (vendaDao.DeleteCaixa())
                    {
                        Message("Caixa Fechado Com Sucesso", "Aviso");
                        CarregarValorCaixa();
                    }
                    else
                    {
                        Message("Não Foi Possível Fechar O Caixa, Tente Novamente", "Aviso");
                    }
                }

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Fechar O Caixa: " + Erro.Message, "Erro");
            }
        }

        private void txt_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

        }

        private void btn_PagamentoFiado_Click(object sender, EventArgs e)
        {
            try
            {


                frmFiado show = new frmFiado(EnumModificaFiado.Pagamento);
                show.ShowDialog();
                if (fiadoDao.SelectFiado().Rows.Count.Equals(0))
                {
                    HideButtonFiado();
                    FonoNotxtProduto();
                }
                else
                {
                    ShowButtonFiado();
                    FonoNotxtProduto();
                }

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Os Dados: " + Erro.Message, "Erro");
            }
        }

        private void cbb_TipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TipoPagamento.Text.Equals("Fiado"))
            {
                EsconderTroco();
            }
            else if (cbb_TipoPagamento.Text.Equals("Cartão"))
            {
                EsconderTroco();
            }
            else if (cbb_TipoPagamento.Text.Equals("Dinheiro"))
            {
                AparecerTroco();
            }
        }

        private void AparecerTroco()
        {
            gpb_GerarTroco.Visible = true;
        }

        private void EsconderTroco()
        {
            gpb_GerarTroco.Visible = false;
        }


        private void btn_parcelar_Click(object sender, EventArgs e)
        {
            if (rtb_MiniRelatorio.Text.Length > 0)
            {


                decimal a = Convert.ToDecimal(Total), b = Convert.ToDecimal(lucroTotal);
                frmDividiPagamento show = new frmDividiPagamento(a, b);
                DialogResult dialog = show.ShowDialog();
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    //Venda venda = new Venda();
                    //JogaParaAVenda(venda);
                    // InserirVendaEBaixarEstoque(venda);
                    if (fiadoDao.SelectFiado().Rows.Count > 0)
                    {
                        ShowButtonFiado();
                    }
                    CarregarComanda();
                    listComanda.Clear();
                    bool certoExcluiEstoque = true;
                    certoExcluiEstoque = ExcluiComanda(certoExcluiEstoque);
                    ValidacaoEstoque(certoExcluiEstoque);
                    CarregarTxtComUm();
                    FonoNotxtProduto();
                }

            }
            else
            {
                Message("Antes De Dividir Uma Comanda É Necessario Existir Uma Venda", "Aviso");
            }
        }

        private void btn_CancelarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtb_MiniRelatorio.Text.Length > 0)
                {
                    ZerarLabel();
                    ZerarLista();
                    ZerarTotal();
                    ZerarValorPago();
                    LoadCbbTypePay();
                    LimparListBoxDeInformacao();
                    listComanda.Clear();
                    listExluirEstoque.Clear();
                    Message("Venda Cancelada", "Aviso");
                    FonoNotxtProduto();
                }



            }
            catch (Exception Erro)
            {
                Message("Erro Ao Cancelar A Venda: " + Erro.Message, "Erro");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
            timer1.Stop();
        }








    }
}
