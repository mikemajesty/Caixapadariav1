namespace View
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Venda = new System.Windows.Forms.GroupBox();
            this.btn_FecharCaixa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.k_rdbComComanda = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.k_rdbSemComanda = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_AlterarCaixa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.k_ComCodigoDeBarra = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.k_rdbSemCodigoDeBarra = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txt_CodigoProduto = new System.Windows.Forms.TextBox();
            this.gpb_AdicionarProdutos = new System.Windows.Forms.GroupBox();
            this.pnl_Esconde = new System.Windows.Forms.Panel();
            this.lbl_CaixaValor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_CodigoOuIdProduto = new System.Windows.Forms.Label();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.lbl_QuantidadeProdutoAlterar = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.rtb_MiniRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lbl_NomeProduto = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_CodProduto = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gpb_TipoDePagamento = new System.Windows.Forms.GroupBox();
            this.btn_CancelarVenda = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_parcelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_PagamentoFiado = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gpb_Total = new System.Windows.Forms.GroupBox();
            this.lbl_Total = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_ValorDoTroco = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gpb_TerminarVenda = new System.Windows.Forms.GroupBox();
            this.btn_ConcluirVenda = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gpb_GerarTroco = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.btn_Troco = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_TipoDePagamento = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_TipoPagamento = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tmp_AtualizaCaixa = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Venda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpb_AdicionarProdutos.SuspendLayout();
            this.pnl_Esconde.SuspendLayout();
            this.gpb_TipoDePagamento.SuspendLayout();
            this.gpb_Total.SuspendLayout();
            this.gpb_TerminarVenda.SuspendLayout();
            this.gpb_GerarTroco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TipoPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // k_panelCabecalho
            // 
            this.k_panelCabecalho.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btn_Minimize,
            this.btn_Sair});
            this.k_panelCabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.k_panelCabecalho.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelCustom1;
            this.k_panelCabecalho.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.k_panelCabecalho.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.k_panelCabecalho.ImeMode = System.Windows.Forms.ImeMode.On;
            this.k_panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.k_panelCabecalho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.k_panelCabecalho.Name = "k_panelCabecalho";
            this.k_panelCabecalho.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            // 
            // k_panelCabecalho.Panel
            // 
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Venda);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_TipoDePagamento);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(695, 562);
            this.k_panelCabecalho.TabIndex = 2;
            this.k_panelCabecalho.ValuesPrimary.Heading = "Sistema Para Padarias";
            this.k_panelCabecalho.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("k_panelCabecalho.ValuesPrimary.Image")));
            this.k_panelCabecalho.ValuesSecondary.Heading = "MJ - Desenvolvimento De Sistemas";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.UniqueName = "F9DC7085F7C9466CD1805C31B418453C";
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.UniqueName = "B24EDB7BA17B41152E94D952E272EA35";
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // gpb_Venda
            // 
            this.gpb_Venda.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Venda.Controls.Add(this.btn_FecharCaixa);
            this.gpb_Venda.Controls.Add(this.panel1);
            this.gpb_Venda.Controls.Add(this.btn_AlterarCaixa);
            this.gpb_Venda.Controls.Add(this.k_ComCodigoDeBarra);
            this.gpb_Venda.Controls.Add(this.k_rdbSemCodigoDeBarra);
            this.gpb_Venda.Controls.Add(this.txt_CodigoProduto);
            this.gpb_Venda.Controls.Add(this.gpb_AdicionarProdutos);
            this.gpb_Venda.Controls.Add(this.rtb_MiniRelatorio);
            this.gpb_Venda.Controls.Add(this.lbl_NomeProduto);
            this.gpb_Venda.Controls.Add(this.lbl_CodProduto);
            this.gpb_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Venda.ForeColor = System.Drawing.Color.Red;
            this.gpb_Venda.Location = new System.Drawing.Point(11, 4);
            this.gpb_Venda.Name = "gpb_Venda";
            this.gpb_Venda.Size = new System.Drawing.Size(666, 322);
            this.gpb_Venda.TabIndex = 7;
            this.gpb_Venda.TabStop = false;
            this.gpb_Venda.Text = "Caixa De Venda";
            // 
            // btn_FecharCaixa
            // 
            this.btn_FecharCaixa.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_FecharCaixa.Location = new System.Drawing.Point(509, 15);
            this.btn_FecharCaixa.Name = "btn_FecharCaixa";
            this.btn_FecharCaixa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_FecharCaixa.Size = new System.Drawing.Size(146, 68);
            this.btn_FecharCaixa.TabIndex = 19;
            this.btn_FecharCaixa.TabStop = false;
            this.btn_FecharCaixa.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_FecharCaixa.Values.Image")));
            this.btn_FecharCaixa.Values.Text = "Fechar Caixa";
            this.btn_FecharCaixa.Click += new System.EventHandler(this.btn_FecharCaixa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.k_rdbComComanda);
            this.panel1.Controls.Add(this.k_rdbSemComanda);
            this.panel1.Location = new System.Drawing.Point(47, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 40);
            this.panel1.TabIndex = 17;
            // 
            // k_rdbComComanda
            // 
            this.k_rdbComComanda.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.k_rdbComComanda.Location = new System.Drawing.Point(131, 8);
            this.k_rdbComComanda.Name = "k_rdbComComanda";
            this.k_rdbComComanda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.k_rdbComComanda.Size = new System.Drawing.Size(126, 22);
            this.k_rdbComComanda.TabIndex = 3;
            this.k_rdbComComanda.TabStop = false;
            this.k_rdbComComanda.Values.Image = ((System.Drawing.Image)(resources.GetObject("k_rdbComComanda.Values.Image")));
            this.k_rdbComComanda.Values.Text = "Com Comanda";
            this.k_rdbComComanda.CheckedChanged += new System.EventHandler(this.k_rdbComComanda_CheckedChanged);
            // 
            // k_rdbSemComanda
            // 
            this.k_rdbSemComanda.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.k_rdbSemComanda.Location = new System.Drawing.Point(6, 8);
            this.k_rdbSemComanda.Name = "k_rdbSemComanda";
            this.k_rdbSemComanda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.k_rdbSemComanda.Size = new System.Drawing.Size(124, 22);
            this.k_rdbSemComanda.TabIndex = 3;
            this.k_rdbSemComanda.TabStop = false;
            this.k_rdbSemComanda.Values.Image = ((System.Drawing.Image)(resources.GetObject("k_rdbSemComanda.Values.Image")));
            this.k_rdbSemComanda.Values.Text = "Sem Comanda";
            this.k_rdbSemComanda.CheckedChanged += new System.EventHandler(this.k_rdbSemComanda_CheckedChanged);
            // 
            // btn_AlterarCaixa
            // 
            this.btn_AlterarCaixa.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btn_AlterarCaixa.Location = new System.Drawing.Point(356, 15);
            this.btn_AlterarCaixa.Name = "btn_AlterarCaixa";
            this.btn_AlterarCaixa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_AlterarCaixa.Size = new System.Drawing.Size(146, 68);
            this.btn_AlterarCaixa.TabIndex = 19;
            this.btn_AlterarCaixa.TabStop = false;
            this.btn_AlterarCaixa.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlterarCaixa.Values.Image")));
            this.btn_AlterarCaixa.Values.Text = "Abrir Caixa";
            this.btn_AlterarCaixa.Click += new System.EventHandler(this.btn_AlterarCaixa_Click);
            // 
            // k_ComCodigoDeBarra
            // 
            this.k_ComCodigoDeBarra.AutoSize = false;
            this.k_ComCodigoDeBarra.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.k_ComCodigoDeBarra.Location = new System.Drawing.Point(190, 114);
            this.k_ComCodigoDeBarra.Name = "k_ComCodigoDeBarra";
            this.k_ComCodigoDeBarra.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.k_ComCodigoDeBarra.Size = new System.Drawing.Size(166, 26);
            this.k_ComCodigoDeBarra.TabIndex = 16;
            this.k_ComCodigoDeBarra.TabStop = false;
            this.k_ComCodigoDeBarra.Values.Image = ((System.Drawing.Image)(resources.GetObject("k_ComCodigoDeBarra.Values.Image")));
            this.k_ComCodigoDeBarra.Values.Text = "Com Código De Barra";
            this.k_ComCodigoDeBarra.CheckedChanged += new System.EventHandler(this.k_ComCodigoDeBarra_CheckedChanged_1);
            // 
            // k_rdbSemCodigoDeBarra
            // 
            this.k_rdbSemCodigoDeBarra.AutoSize = false;
            this.k_rdbSemCodigoDeBarra.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.k_rdbSemCodigoDeBarra.Location = new System.Drawing.Point(22, 116);
            this.k_rdbSemCodigoDeBarra.Name = "k_rdbSemCodigoDeBarra";
            this.k_rdbSemCodigoDeBarra.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.k_rdbSemCodigoDeBarra.Size = new System.Drawing.Size(164, 23);
            this.k_rdbSemCodigoDeBarra.TabIndex = 15;
            this.k_rdbSemCodigoDeBarra.TabStop = false;
            this.k_rdbSemCodigoDeBarra.Values.Image = ((System.Drawing.Image)(resources.GetObject("k_rdbSemCodigoDeBarra.Values.Image")));
            this.k_rdbSemCodigoDeBarra.Values.Text = "Sem Código De Barra";
            this.k_rdbSemCodigoDeBarra.CheckedChanged += new System.EventHandler(this.k_rdbSemCodigoDeBarra_CheckedChanged_1);
            // 
            // txt_CodigoProduto
            // 
            this.txt_CodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoProduto.Location = new System.Drawing.Point(22, 66);
            this.txt_CodigoProduto.MaxLength = 50;
            this.txt_CodigoProduto.Name = "txt_CodigoProduto";
            this.txt_CodigoProduto.Size = new System.Drawing.Size(324, 44);
            this.txt_CodigoProduto.TabIndex = 0;
            this.txt_CodigoProduto.TextChanged += new System.EventHandler(this.txt_CodigoProduto_TextChanged_1);
            this.txt_CodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoProduto_KeyPress);
            // 
            // gpb_AdicionarProdutos
            // 
            this.gpb_AdicionarProdutos.Controls.Add(this.pnl_Esconde);
            this.gpb_AdicionarProdutos.Location = new System.Drawing.Point(20, 143);
            this.gpb_AdicionarProdutos.Name = "gpb_AdicionarProdutos";
            this.gpb_AdicionarProdutos.Size = new System.Drawing.Size(326, 171);
            this.gpb_AdicionarProdutos.TabIndex = 9;
            this.gpb_AdicionarProdutos.TabStop = false;
            this.gpb_AdicionarProdutos.Text = "Adicionar Produtos";
            // 
            // pnl_Esconde
            // 
            this.pnl_Esconde.Controls.Add(this.lbl_CaixaValor);
            this.pnl_Esconde.Controls.Add(this.lbl_CodigoOuIdProduto);
            this.pnl_Esconde.Controls.Add(this.txt_Produto);
            this.pnl_Esconde.Controls.Add(this.lbl_QuantidadeProdutoAlterar);
            this.pnl_Esconde.Controls.Add(this.txt_Quantidade);
            this.pnl_Esconde.Location = new System.Drawing.Point(6, 19);
            this.pnl_Esconde.Name = "pnl_Esconde";
            this.pnl_Esconde.Size = new System.Drawing.Size(299, 140);
            this.pnl_Esconde.TabIndex = 10;
            // 
            // lbl_CaixaValor
            // 
            this.lbl_CaixaValor.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_CaixaValor.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_CaixaValor.Location = new System.Drawing.Point(127, 26);
            this.lbl_CaixaValor.Name = "lbl_CaixaValor";
            this.lbl_CaixaValor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lbl_CaixaValor.Size = new System.Drawing.Size(110, 36);
            this.lbl_CaixaValor.StateDisabled.LongText.Color1 = System.Drawing.Color.Black;
            this.lbl_CaixaValor.StateDisabled.LongText.Color2 = System.Drawing.Color.Black;
            this.lbl_CaixaValor.TabIndex = 18;
            this.lbl_CaixaValor.Values.ExtraText = "00.00";
            this.lbl_CaixaValor.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_CaixaValor.Values.Image")));
            this.lbl_CaixaValor.Values.Text = "Caixa";
            // 
            // lbl_CodigoOuIdProduto
            // 
            this.lbl_CodigoOuIdProduto.AutoSize = true;
            this.lbl_CodigoOuIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoOuIdProduto.ForeColor = System.Drawing.Color.Red;
            this.lbl_CodigoOuIdProduto.Location = new System.Drawing.Point(1, 71);
            this.lbl_CodigoOuIdProduto.Name = "lbl_CodigoOuIdProduto";
            this.lbl_CodigoOuIdProduto.Size = new System.Drawing.Size(114, 13);
            this.lbl_CodigoOuIdProduto.TabIndex = 10;
            this.lbl_CodigoOuIdProduto.Text = "Código Do Produto";
            // 
            // txt_Produto
            // 
            this.txt_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Produto.Location = new System.Drawing.Point(3, 87);
            this.txt_Produto.MaxLength = 50;
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(281, 44);
            this.txt_Produto.TabIndex = 1;
            this.txt_Produto.TextChanged += new System.EventHandler(this.txt_Produto_TextChanged);
            this.txt_Produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Produto_KeyPress);
            // 
            // lbl_QuantidadeProdutoAlterar
            // 
            this.lbl_QuantidadeProdutoAlterar.AutoSize = true;
            this.lbl_QuantidadeProdutoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuantidadeProdutoAlterar.ForeColor = System.Drawing.Color.Red;
            this.lbl_QuantidadeProdutoAlterar.Location = new System.Drawing.Point(3, 4);
            this.lbl_QuantidadeProdutoAlterar.Name = "lbl_QuantidadeProdutoAlterar";
            this.lbl_QuantidadeProdutoAlterar.Size = new System.Drawing.Size(72, 13);
            this.lbl_QuantidadeProdutoAlterar.TabIndex = 10;
            this.lbl_QuantidadeProdutoAlterar.Text = "Quantidade";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(3, 20);
            this.txt_Quantidade.MaxLength = 3;
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(94, 44);
            this.txt_Quantidade.TabIndex = 0;
            this.txt_Quantidade.TextChanged += new System.EventHandler(this.txt_Quantidade_TextChanged);
            this.txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantidade_KeyPress);
            // 
            // rtb_MiniRelatorio
            // 
            this.rtb_MiniRelatorio.Location = new System.Drawing.Point(362, 116);
            this.rtb_MiniRelatorio.Name = "rtb_MiniRelatorio";
            this.rtb_MiniRelatorio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.rtb_MiniRelatorio.ReadOnly = true;
            this.rtb_MiniRelatorio.Size = new System.Drawing.Size(286, 196);
            this.rtb_MiniRelatorio.TabIndex = 7;
            this.rtb_MiniRelatorio.TabStop = false;
            this.rtb_MiniRelatorio.Text = "";
            this.rtb_MiniRelatorio.WordWrap = false;
            // 
            // lbl_NomeProduto
            // 
            this.lbl_NomeProduto.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.lbl_NomeProduto.Location = new System.Drawing.Point(438, 89);
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            this.lbl_NomeProduto.Size = new System.Drawing.Size(153, 20);
            this.lbl_NomeProduto.TabIndex = 6;
            this.lbl_NomeProduto.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_NomeProduto.Values.Image")));
            this.lbl_NomeProduto.Values.Text = "Informação Do Produto";
            // 
            // lbl_CodProduto
            // 
            this.lbl_CodProduto.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.lbl_CodProduto.Location = new System.Drawing.Point(20, 47);
            this.lbl_CodProduto.Name = "lbl_CodProduto";
            this.lbl_CodProduto.Size = new System.Drawing.Size(123, 20);
            this.lbl_CodProduto.TabIndex = 8;
            this.lbl_CodProduto.TabStop = false;
            this.lbl_CodProduto.Values.Text = "Codigo Da Comanda";
            // 
            // gpb_TipoDePagamento
            // 
            this.gpb_TipoDePagamento.BackColor = System.Drawing.Color.Transparent;
            this.gpb_TipoDePagamento.Controls.Add(this.btn_CancelarVenda);
            this.gpb_TipoDePagamento.Controls.Add(this.btn_parcelar);
            this.gpb_TipoDePagamento.Controls.Add(this.btn_PagamentoFiado);
            this.gpb_TipoDePagamento.Controls.Add(this.gpb_Total);
            this.gpb_TipoDePagamento.Controls.Add(this.gpb_TerminarVenda);
            this.gpb_TipoDePagamento.Controls.Add(this.gpb_GerarTroco);
            this.gpb_TipoDePagamento.Controls.Add(this.lbl_TipoDePagamento);
            this.gpb_TipoDePagamento.Controls.Add(this.cbb_TipoPagamento);
            this.gpb_TipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_TipoDePagamento.ForeColor = System.Drawing.Color.Black;
            this.gpb_TipoDePagamento.Location = new System.Drawing.Point(11, 326);
            this.gpb_TipoDePagamento.Name = "gpb_TipoDePagamento";
            this.gpb_TipoDePagamento.Size = new System.Drawing.Size(666, 181);
            this.gpb_TipoDePagamento.TabIndex = 3;
            this.gpb_TipoDePagamento.TabStop = false;
            this.gpb_TipoDePagamento.Text = "Tipo De Pagamento";
            // 
            // btn_CancelarVenda
            // 
            this.btn_CancelarVenda.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btn_CancelarVenda.Location = new System.Drawing.Point(88, 150);
            this.btn_CancelarVenda.Name = "btn_CancelarVenda";
            this.btn_CancelarVenda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.btn_CancelarVenda.Size = new System.Drawing.Size(133, 25);
            this.btn_CancelarVenda.TabIndex = 8;
            this.btn_CancelarVenda.TabStop = false;
            this.btn_CancelarVenda.Values.Text = "Cancelar Venda";
            this.btn_CancelarVenda.Click += new System.EventHandler(this.btn_CancelarVenda_Click);
            // 
            // btn_parcelar
            // 
            this.btn_parcelar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btn_parcelar.Location = new System.Drawing.Point(321, 149);
            this.btn_parcelar.Name = "btn_parcelar";
            this.btn_parcelar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btn_parcelar.Size = new System.Drawing.Size(148, 25);
            this.btn_parcelar.TabIndex = 8;
            this.btn_parcelar.TabStop = false;
            this.btn_parcelar.Values.Text = "Dividir Conta";
            this.btn_parcelar.Click += new System.EventHandler(this.btn_parcelar_Click);
            // 
            // btn_PagamentoFiado
            // 
            this.btn_PagamentoFiado.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btn_PagamentoFiado.Location = new System.Drawing.Point(321, 8);
            this.btn_PagamentoFiado.Name = "btn_PagamentoFiado";
            this.btn_PagamentoFiado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_PagamentoFiado.Size = new System.Drawing.Size(148, 25);
            this.btn_PagamentoFiado.TabIndex = 8;
            this.btn_PagamentoFiado.TabStop = false;
            this.btn_PagamentoFiado.Values.Text = "Receber Fiado";
            this.btn_PagamentoFiado.Click += new System.EventHandler(this.btn_PagamentoFiado_Click);
            // 
            // gpb_Total
            // 
            this.gpb_Total.Controls.Add(this.lbl_Total);
            this.gpb_Total.Controls.Add(this.lbl_ValorDoTroco);
            this.gpb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Total.ForeColor = System.Drawing.Color.Black;
            this.gpb_Total.Location = new System.Drawing.Point(484, 19);
            this.gpb_Total.Name = "gpb_Total";
            this.gpb_Total.Size = new System.Drawing.Size(159, 141);
            this.gpb_Total.TabIndex = 7;
            this.gpb_Total.TabStop = false;
            this.gpb_Total.Text = "Total";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_Total.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_Total.Location = new System.Drawing.Point(6, 85);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(146, 50);
            this.lbl_Total.StateDisabled.LongText.Color1 = System.Drawing.Color.Black;
            this.lbl_Total.StateDisabled.LongText.Color2 = System.Drawing.Color.Black;
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Values.ExtraText = "00.00";
            this.lbl_Total.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Total.Values.Image")));
            this.lbl_Total.Values.Text = "Total";
            // 
            // lbl_ValorDoTroco
            // 
            this.lbl_ValorDoTroco.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_ValorDoTroco.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_ValorDoTroco.Location = new System.Drawing.Point(6, 14);
            this.lbl_ValorDoTroco.Name = "lbl_ValorDoTroco";
            this.lbl_ValorDoTroco.Size = new System.Drawing.Size(151, 50);
            this.lbl_ValorDoTroco.TabIndex = 4;
            this.lbl_ValorDoTroco.Values.ExtraText = "00.00";
            this.lbl_ValorDoTroco.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ValorDoTroco.Values.Image")));
            this.lbl_ValorDoTroco.Values.Text = "Troco";
            // 
            // gpb_TerminarVenda
            // 
            this.gpb_TerminarVenda.Controls.Add(this.btn_ConcluirVenda);
            this.gpb_TerminarVenda.Location = new System.Drawing.Point(23, 51);
            this.gpb_TerminarVenda.Name = "gpb_TerminarVenda";
            this.gpb_TerminarVenda.Size = new System.Drawing.Size(274, 100);
            this.gpb_TerminarVenda.TabIndex = 6;
            this.gpb_TerminarVenda.TabStop = false;
            this.gpb_TerminarVenda.Text = "Terminar Venda";
            // 
            // btn_ConcluirVenda
            // 
            this.btn_ConcluirVenda.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btn_ConcluirVenda.Location = new System.Drawing.Point(23, 19);
            this.btn_ConcluirVenda.Name = "btn_ConcluirVenda";
            this.btn_ConcluirVenda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.btn_ConcluirVenda.Size = new System.Drawing.Size(233, 74);
            this.btn_ConcluirVenda.TabIndex = 0;
            this.btn_ConcluirVenda.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConcluirVenda.Values.Image")));
            this.btn_ConcluirVenda.Values.Text = "Concluir Venda";
            this.btn_ConcluirVenda.Click += new System.EventHandler(this.btn_ConcluirVenda_Click);
            // 
            // gpb_GerarTroco
            // 
            this.gpb_GerarTroco.Controls.Add(this.label1);
            this.gpb_GerarTroco.Controls.Add(this.txt_ValorPago);
            this.gpb_GerarTroco.Controls.Add(this.btn_Troco);
            this.gpb_GerarTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_GerarTroco.ForeColor = System.Drawing.Color.Black;
            this.gpb_GerarTroco.Location = new System.Drawing.Point(321, 37);
            this.gpb_GerarTroco.Name = "gpb_GerarTroco";
            this.gpb_GerarTroco.Size = new System.Drawing.Size(148, 112);
            this.gpb_GerarTroco.TabIndex = 5;
            this.gpb_GerarTroco.TabStop = false;
            this.gpb_GerarTroco.Text = "Troco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Valor Pago";
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorPago.Location = new System.Drawing.Point(26, 30);
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(100, 44);
            this.txt_ValorPago.TabIndex = 0;
            this.txt_ValorPago.TextChanged += new System.EventHandler(this.txt_ValorPago_TextChanged_1);
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            // 
            // btn_Troco
            // 
            this.btn_Troco.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btn_Troco.Location = new System.Drawing.Point(26, 75);
            this.btn_Troco.Name = "btn_Troco";
            this.btn_Troco.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Troco.Size = new System.Drawing.Size(100, 31);
            this.btn_Troco.TabIndex = 1;
            this.btn_Troco.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Troco.Values.Image")));
            this.btn_Troco.Values.Text = "Gerar Troco";
            this.btn_Troco.Click += new System.EventHandler(this.btn_Troco_Click);
            // 
            // lbl_TipoDePagamento
            // 
            this.lbl_TipoDePagamento.AutoSize = false;
            this.lbl_TipoDePagamento.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_TipoDePagamento.Location = new System.Drawing.Point(23, 23);
            this.lbl_TipoDePagamento.Name = "lbl_TipoDePagamento";
            this.lbl_TipoDePagamento.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.lbl_TipoDePagamento.Size = new System.Drawing.Size(144, 20);
            this.lbl_TipoDePagamento.TabIndex = 2;
            this.lbl_TipoDePagamento.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_TipoDePagamento.Values.Image")));
            this.lbl_TipoDePagamento.Values.Text = "Tipo De Pagamento";
            // 
            // cbb_TipoPagamento
            // 
            this.cbb_TipoPagamento.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.cbb_TipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TipoPagamento.DropDownWidth = 137;
            this.cbb_TipoPagamento.Location = new System.Drawing.Point(170, 24);
            this.cbb_TipoPagamento.Name = "cbb_TipoPagamento";
            this.cbb_TipoPagamento.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cbb_TipoPagamento.Size = new System.Drawing.Size(127, 21);
            this.cbb_TipoPagamento.TabIndex = 1;
            this.cbb_TipoPagamento.TabStop = false;
            this.cbb_TipoPagamento.SelectedIndexChanged += new System.EventHandler(this.cbb_TipoPagamento_SelectedIndexChanged);
            // 
            // tmp_AtualizaCaixa
            // 
            this.tmp_AtualizaCaixa.Enabled = true;
            this.tmp_AtualizaCaixa.Interval = 10000;
            this.tmp_AtualizaCaixa.Tick += new System.EventHandler(this.tmp_AtualizaCaixa_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 562);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario De Venda";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Venda.ResumeLayout(false);
            this.gpb_Venda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_AdicionarProdutos.ResumeLayout(false);
            this.pnl_Esconde.ResumeLayout(false);
            this.pnl_Esconde.PerformLayout();
            this.gpb_TipoDePagamento.ResumeLayout(false);
            this.gpb_Total.ResumeLayout(false);
            this.gpb_Total.PerformLayout();
            this.gpb_TerminarVenda.ResumeLayout(false);
            this.gpb_GerarTroco.ResumeLayout(false);
            this.gpb_GerarTroco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TipoPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_TipoPagamento;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_TipoDePagamento;
        private System.Windows.Forms.GroupBox gpb_TipoDePagamento;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton k_rdbSemComanda;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton k_rdbComComanda;
        private System.Windows.Forms.GroupBox gpb_Venda;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtb_MiniRelatorio;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_NomeProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Total;
        private System.Windows.Forms.GroupBox gpb_GerarTroco;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Troco;
        private System.Windows.Forms.GroupBox gpb_Total;
        private System.Windows.Forms.GroupBox gpb_TerminarVenda;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ConcluirVenda;
        private System.Windows.Forms.GroupBox gpb_AdicionarProdutos;
        private System.Windows.Forms.Label lbl_CodigoOuIdProduto;
        private System.Windows.Forms.Label lbl_QuantidadeProdutoAlterar;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_Produto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ValorDoTroco;
        private System.Windows.Forms.Panel pnl_Esconde;
        private System.Windows.Forms.TextBox txt_CodigoProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton k_ComCodigoDeBarra;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton k_rdbSemCodigoDeBarra;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_CaixaValor;
        private System.Windows.Forms.Timer tmp_AtualizaCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AlterarCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_FecharCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_CodProduto;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PagamentoFiado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_parcelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_CancelarVenda;
        private System.Windows.Forms.Timer timer1;
    }
}