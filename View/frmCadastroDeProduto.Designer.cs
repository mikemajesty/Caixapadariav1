namespace View
{
    partial class frmCadastroDeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDeProduto));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.lblTipoVenda = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbTipoDeCadastro = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.gpb_Produto = new System.Windows.Forms.GroupBox();
            this.btn_k_Cancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_k_Confirmar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gpp_Detales = new System.Windows.Forms.GroupBox();
            this.txt_CodigoProduto = new System.Windows.Forms.TextBox();
            this.gpb_Estoque = new System.Windows.Forms.GroupBox();
            this.txt_QuantidadeMaxima = new System.Windows.Forms.TextBox();
            this.txt_k_QtdEstoque = new System.Windows.Forms.TextBox();
            this.txt_QuantidadeMinima = new System.Windows.Forms.TextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_QuantidadeEstoque = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_AlterarEstoque = new System.Windows.Forms.Label();
            this.gpb_Porcentagem = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Porcentagem = new System.Windows.Forms.TextBox();
            this.btn_GotoCadastroCad = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IdCategoria = new System.Windows.Forms.Label();
            this.txt_k_NomeProd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.gpb_Precos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_k_PrecoCompra = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_k_PrecoVenda = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_k_Descricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbb_k_Categoria = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_CodProduto = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoDeCadastro)).BeginInit();
            this.gpb_Produto.SuspendLayout();
            this.gpp_Detales.SuspendLayout();
            this.gpb_Estoque.SuspendLayout();
            this.gpb_Porcentagem.SuspendLayout();
            this.gpb_Precos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_k_Categoria)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.lblTipoVenda);
            this.k_panelCabecalho.Panel.Controls.Add(this.cbbTipoDeCadastro);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Produto);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(462, 560);
            this.k_panelCabecalho.TabIndex = 4;
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
            // lblTipoVenda
            // 
            this.lblTipoVenda.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblTipoVenda.Location = new System.Drawing.Point(73, 19);
            this.lblTipoVenda.Name = "lblTipoVenda";
            this.lblTipoVenda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.lblTipoVenda.Size = new System.Drawing.Size(153, 22);
            this.lblTipoVenda.TabIndex = 3;
            this.lblTipoVenda.Values.Text = "Escolha o Tipo Da Venda";
            // 
            // cbbTipoDeCadastro
            // 
            this.cbbTipoDeCadastro.DropDownWidth = 121;
            this.cbbTipoDeCadastro.Items.AddRange(new object[] {
            "Unidade",
            "Peso"});
            this.cbbTipoDeCadastro.Location = new System.Drawing.Point(232, 20);
            this.cbbTipoDeCadastro.Name = "cbbTipoDeCadastro";
            this.cbbTipoDeCadastro.Size = new System.Drawing.Size(188, 21);
            this.cbbTipoDeCadastro.TabIndex = 2;
            this.cbbTipoDeCadastro.SelectedIndexChanged += new System.EventHandler(this.cbbTipoDeCadastro_SelectedIndexChanged);
            // 
            // gpb_Produto
            // 
            this.gpb_Produto.Controls.Add(this.btn_k_Cancelar);
            this.gpb_Produto.Controls.Add(this.btn_k_Confirmar);
            this.gpb_Produto.Controls.Add(this.gpp_Detales);
            this.gpb_Produto.Location = new System.Drawing.Point(3, 49);
            this.gpb_Produto.Name = "gpb_Produto";
            this.gpb_Produto.Size = new System.Drawing.Size(469, 454);
            this.gpb_Produto.TabIndex = 1;
            this.gpb_Produto.TabStop = false;
            this.gpb_Produto.Text = "Produto";
            // 
            // btn_k_Cancelar
            // 
            this.btn_k_Cancelar.Location = new System.Drawing.Point(237, 400);
            this.btn_k_Cancelar.Name = "btn_k_Cancelar";
            this.btn_k_Cancelar.Size = new System.Drawing.Size(206, 48);
            this.btn_k_Cancelar.TabIndex = 1;
            this.btn_k_Cancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_k_Cancelar.Values.Image")));
            this.btn_k_Cancelar.Values.Text = "Sair";
            this.btn_k_Cancelar.Click += new System.EventHandler(this.btn_k_Cancelar_Click);
            // 
            // btn_k_Confirmar
            // 
            this.btn_k_Confirmar.Location = new System.Drawing.Point(8, 400);
            this.btn_k_Confirmar.Name = "btn_k_Confirmar";
            this.btn_k_Confirmar.Size = new System.Drawing.Size(206, 48);
            this.btn_k_Confirmar.TabIndex = 0;
            this.btn_k_Confirmar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_k_Confirmar.Values.Image")));
            this.btn_k_Confirmar.Values.Text = "Confirmar";
            this.btn_k_Confirmar.Click += new System.EventHandler(this.btn_k_Confirmar_Click);
            // 
            // gpp_Detales
            // 
            this.gpp_Detales.Controls.Add(this.txt_CodigoProduto);
            this.gpp_Detales.Controls.Add(this.gpb_Estoque);
            this.gpp_Detales.Controls.Add(this.gpb_Porcentagem);
            this.gpp_Detales.Controls.Add(this.btn_GotoCadastroCad);
            this.gpp_Detales.Controls.Add(this.label4);
            this.gpp_Detales.Controls.Add(this.label1);
            this.gpp_Detales.Controls.Add(this.lbl_IdCategoria);
            this.gpp_Detales.Controls.Add(this.txt_k_NomeProd);
            this.gpp_Detales.Controls.Add(this.gpb_Precos);
            this.gpp_Detales.Controls.Add(this.txt_k_Descricao);
            this.gpp_Detales.Controls.Add(this.cbb_k_Categoria);
            this.gpp_Detales.Controls.Add(this.kryptonLabel5);
            this.gpp_Detales.Controls.Add(this.lbl_CodProduto);
            this.gpp_Detales.Controls.Add(this.kryptonLabel1);
            this.gpp_Detales.Controls.Add(this.kryptonLabel2);
            this.gpp_Detales.Location = new System.Drawing.Point(8, 19);
            this.gpp_Detales.Name = "gpp_Detales";
            this.gpp_Detales.Size = new System.Drawing.Size(435, 375);
            this.gpp_Detales.TabIndex = 0;
            this.gpp_Detales.TabStop = false;
            this.gpp_Detales.Text = "Detales Do Produto";
            // 
            // txt_CodigoProduto
            // 
            this.txt_CodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoProduto.Location = new System.Drawing.Point(26, 35);
            this.txt_CodigoProduto.Name = "txt_CodigoProduto";
            this.txt_CodigoProduto.Size = new System.Drawing.Size(381, 31);
            this.txt_CodigoProduto.TabIndex = 0;
            // 
            // gpb_Estoque
            // 
            this.gpb_Estoque.Controls.Add(this.txt_QuantidadeMaxima);
            this.gpb_Estoque.Controls.Add(this.txt_k_QtdEstoque);
            this.gpb_Estoque.Controls.Add(this.txt_QuantidadeMinima);
            this.gpb_Estoque.Controls.Add(this.kryptonLabel7);
            this.gpb_Estoque.Controls.Add(this.kryptonLabel6);
            this.gpb_Estoque.Controls.Add(this.label8);
            this.gpb_Estoque.Controls.Add(this.label7);
            this.gpb_Estoque.Controls.Add(this.lbl_QuantidadeEstoque);
            this.gpb_Estoque.Controls.Add(this.lbl_AlterarEstoque);
            this.gpb_Estoque.Location = new System.Drawing.Point(223, 199);
            this.gpb_Estoque.Name = "gpb_Estoque";
            this.gpb_Estoque.Size = new System.Drawing.Size(184, 156);
            this.gpb_Estoque.TabIndex = 17;
            this.gpb_Estoque.TabStop = false;
            this.gpb_Estoque.Text = "Estoque";
            // 
            // txt_QuantidadeMaxima
            // 
            this.txt_QuantidadeMaxima.BackColor = System.Drawing.Color.White;
            this.txt_QuantidadeMaxima.Location = new System.Drawing.Point(27, 126);
            this.txt_QuantidadeMaxima.MaxLength = 5;
            this.txt_QuantidadeMaxima.Name = "txt_QuantidadeMaxima";
            this.txt_QuantidadeMaxima.Size = new System.Drawing.Size(106, 20);
            this.txt_QuantidadeMaxima.TabIndex = 2;
            this.txt_QuantidadeMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuantidadeMaxima_KeyPress);
            // 
            // txt_k_QtdEstoque
            // 
            this.txt_k_QtdEstoque.BackColor = System.Drawing.Color.White;
            this.txt_k_QtdEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k_QtdEstoque.ForeColor = System.Drawing.Color.Black;
            this.txt_k_QtdEstoque.Location = new System.Drawing.Point(27, 30);
            this.txt_k_QtdEstoque.MaxLength = 5;
            this.txt_k_QtdEstoque.Name = "txt_k_QtdEstoque";
            this.txt_k_QtdEstoque.Size = new System.Drawing.Size(106, 35);
            this.txt_k_QtdEstoque.TabIndex = 0;
            this.txt_k_QtdEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k_QtdEstoque_KeyPress_1);
            // 
            // txt_QuantidadeMinima
            // 
            this.txt_QuantidadeMinima.BackColor = System.Drawing.Color.White;
            this.txt_QuantidadeMinima.Location = new System.Drawing.Point(27, 87);
            this.txt_QuantidadeMinima.MaxLength = 5;
            this.txt_QuantidadeMinima.Name = "txt_QuantidadeMinima";
            this.txt_QuantidadeMinima.Size = new System.Drawing.Size(106, 20);
            this.txt_QuantidadeMinima.TabIndex = 1;
            this.txt_QuantidadeMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuantidadeMinima_KeyPress);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(27, 108);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel7.TabIndex = 8;
            this.kryptonLabel7.Values.Text = "QTD Máxima";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(27, 65);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(79, 20);
            this.kryptonLabel6.TabIndex = 8;
            this.kryptonLabel6.Values.Text = "QTD Minima";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "*";
            // 
            // lbl_QuantidadeEstoque
            // 
            this.lbl_QuantidadeEstoque.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.lbl_QuantidadeEstoque.Location = new System.Drawing.Point(27, 12);
            this.lbl_QuantidadeEstoque.Name = "lbl_QuantidadeEstoque";
            this.lbl_QuantidadeEstoque.Size = new System.Drawing.Size(99, 20);
            this.lbl_QuantidadeEstoque.TabIndex = 8;
            this.lbl_QuantidadeEstoque.Values.Text = "QTD No Estoque";
            // 
            // lbl_AlterarEstoque
            // 
            this.lbl_AlterarEstoque.AutoSize = true;
            this.lbl_AlterarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlterarEstoque.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlterarEstoque.Location = new System.Drawing.Point(13, 37);
            this.lbl_AlterarEstoque.Name = "lbl_AlterarEstoque";
            this.lbl_AlterarEstoque.Size = new System.Drawing.Size(12, 13);
            this.lbl_AlterarEstoque.TabIndex = 6;
            this.lbl_AlterarEstoque.Text = "*";
            // 
            // gpb_Porcentagem
            // 
            this.gpb_Porcentagem.Controls.Add(this.label6);
            this.gpb_Porcentagem.Controls.Add(this.label5);
            this.gpb_Porcentagem.Controls.Add(this.txt_Porcentagem);
            this.gpb_Porcentagem.Location = new System.Drawing.Point(223, 76);
            this.gpb_Porcentagem.Name = "gpb_Porcentagem";
            this.gpb_Porcentagem.Size = new System.Drawing.Size(184, 117);
            this.gpb_Porcentagem.TabIndex = 9;
            this.gpb_Porcentagem.TabStop = false;
            this.gpb_Porcentagem.Text = "Porcentagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(2, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "%  De Lucro";
            // 
            // txt_Porcentagem
            // 
            this.txt_Porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Porcentagem.Location = new System.Drawing.Point(22, 43);
            this.txt_Porcentagem.MaxLength = 5;
            this.txt_Porcentagem.Name = "txt_Porcentagem";
            this.txt_Porcentagem.Size = new System.Drawing.Size(122, 38);
            this.txt_Porcentagem.TabIndex = 0;
            this.txt_Porcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Porcentagem_KeyPress);
            // 
            // btn_GotoCadastroCad
            // 
            this.btn_GotoCadastroCad.Location = new System.Drawing.Point(181, 147);
            this.btn_GotoCadastroCad.Name = "btn_GotoCadastroCad";
            this.btn_GotoCadastroCad.Size = new System.Drawing.Size(41, 22);
            this.btn_GotoCadastroCad.TabIndex = 16;
            this.btn_GotoCadastroCad.TabStop = false;
            this.btn_GotoCadastroCad.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_GotoCadastroCad.Values.Image")));
            this.btn_GotoCadastroCad.Values.Text = "";
            this.btn_GotoCadastroCad.Click += new System.EventHandler(this.btn_GotoCadastroCad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*";
            // 
            // lbl_IdCategoria
            // 
            this.lbl_IdCategoria.AutoSize = true;
            this.lbl_IdCategoria.Location = new System.Drawing.Point(307, 19);
            this.lbl_IdCategoria.Name = "lbl_IdCategoria";
            this.lbl_IdCategoria.Size = new System.Drawing.Size(0, 13);
            this.lbl_IdCategoria.TabIndex = 11;
            this.lbl_IdCategoria.Visible = false;
            // 
            // txt_k_NomeProd
            // 
            this.txt_k_NomeProd.Location = new System.Drawing.Point(27, 103);
            this.txt_k_NomeProd.MaxLength = 50;
            this.txt_k_NomeProd.Name = "txt_k_NomeProd";
            this.txt_k_NomeProd.Size = new System.Drawing.Size(152, 20);
            this.txt_k_NomeProd.TabIndex = 1;
            // 
            // gpb_Precos
            // 
            this.gpb_Precos.Controls.Add(this.label3);
            this.gpb_Precos.Controls.Add(this.label2);
            this.gpb_Precos.Controls.Add(this.txt_k_PrecoCompra);
            this.gpb_Precos.Controls.Add(this.txt_k_PrecoVenda);
            this.gpb_Precos.Controls.Add(this.kryptonLabel3);
            this.gpb_Precos.Controls.Add(this.kryptonLabel4);
            this.gpb_Precos.Location = new System.Drawing.Point(228, 76);
            this.gpb_Precos.Name = "gpb_Precos";
            this.gpb_Precos.Size = new System.Drawing.Size(179, 105);
            this.gpb_Precos.TabIndex = 6;
            this.gpb_Precos.TabStop = false;
            this.gpb_Precos.Text = "Preços";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*";
            // 
            // txt_k_PrecoCompra
            // 
            this.txt_k_PrecoCompra.Location = new System.Drawing.Point(17, 29);
            this.txt_k_PrecoCompra.MaxLength = 10;
            this.txt_k_PrecoCompra.Name = "txt_k_PrecoCompra";
            this.txt_k_PrecoCompra.Size = new System.Drawing.Size(152, 20);
            this.txt_k_PrecoCompra.TabIndex = 2;
            this.txt_k_PrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k_PrecoCompra_KeyPress);
            // 
            // txt_k_PrecoVenda
            // 
            this.txt_k_PrecoVenda.Location = new System.Drawing.Point(17, 75);
            this.txt_k_PrecoVenda.MaxLength = 10;
            this.txt_k_PrecoVenda.Name = "txt_k_PrecoVenda";
            this.txt_k_PrecoVenda.Size = new System.Drawing.Size(152, 20);
            this.txt_k_PrecoVenda.TabIndex = 4;
            this.txt_k_PrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k_PrecoVenda_KeyPress);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(11, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Preço Compra";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 56);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Preço Venda";
            // 
            // txt_k_Descricao
            // 
            this.txt_k_Descricao.Location = new System.Drawing.Point(26, 199);
            this.txt_k_Descricao.MaxLength = 50;
            this.txt_k_Descricao.Multiline = true;
            this.txt_k_Descricao.Name = "txt_k_Descricao";
            this.txt_k_Descricao.Size = new System.Drawing.Size(152, 156);
            this.txt_k_Descricao.TabIndex = 3;
            // 
            // cbb_k_Categoria
            // 
            this.cbb_k_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_k_Categoria.DropDownWidth = 152;
            this.cbb_k_Categoria.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cbb_k_Categoria.Location = new System.Drawing.Point(27, 148);
            this.cbb_k_Categoria.Name = "cbb_k_Categoria";
            this.cbb_k_Categoria.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.cbb_k_Categoria.Size = new System.Drawing.Size(152, 21);
            this.cbb_k_Categoria.TabIndex = 2;
            this.cbb_k_Categoria.SelectedIndexChanged += new System.EventHandler(this.cbb_k_Categoria_SelectedIndexChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(23, 178);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(126, 20);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "Descrição Do Produto";
            // 
            // lbl_CodProduto
            // 
            this.lbl_CodProduto.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.lbl_CodProduto.Location = new System.Drawing.Point(23, 18);
            this.lbl_CodProduto.Name = "lbl_CodProduto";
            this.lbl_CodProduto.Size = new System.Drawing.Size(113, 20);
            this.lbl_CodProduto.TabIndex = 8;
            this.lbl_CodProduto.Values.Text = "Código Do Produto";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 84);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "Nome Do Produto";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 129);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(127, 20);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Categoria Do Produto";
            // 
            // frmCadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 560);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            this.k_panelCabecalho.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoDeCadastro)).EndInit();
            this.gpb_Produto.ResumeLayout(false);
            this.gpp_Detales.ResumeLayout(false);
            this.gpp_Detales.PerformLayout();
            this.gpb_Estoque.ResumeLayout(false);
            this.gpb_Estoque.PerformLayout();
            this.gpb_Porcentagem.ResumeLayout(false);
            this.gpb_Porcentagem.PerformLayout();
            this.gpb_Precos.ResumeLayout(false);
            this.gpb_Precos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_k_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Produto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_k_Cancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_k_Confirmar;
        private System.Windows.Forms.GroupBox gpp_Detales;
        private System.Windows.Forms.GroupBox gpb_Precos;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_k_PrecoCompra;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_k_PrecoVenda;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_k_Categoria;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_CodProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_QuantidadeEstoque;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_k_Descricao;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.Label lbl_IdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_k_NomeProd;
        private System.Windows.Forms.Label lbl_AlterarEstoque;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_GotoCadastroCad;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbTipoDeCadastro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTipoVenda;
        private System.Windows.Forms.GroupBox gpb_Porcentagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Porcentagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpb_Estoque;
        private System.Windows.Forms.TextBox txt_QuantidadeMaxima;
        private System.Windows.Forms.TextBox txt_QuantidadeMinima;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_k_QtdEstoque;
        private System.Windows.Forms.TextBox txt_CodigoProduto;

    }
}