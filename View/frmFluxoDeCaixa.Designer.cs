namespace View
{
    partial class frmFluxoDeCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoDeCaixa));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_PesquisarPorDia = new System.Windows.Forms.GroupBox();
            this.btn_K_PesquisarPorDia = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_k_pesquisaindividual = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PesquisarPorIntervalo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_k_2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtp_K_data1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.gpb_Pesquisar = new System.Windows.Forms.GroupBox();
            this.cbb_tipoVendaPagamento = new System.Windows.Forms.ComboBox();
            this.lbl_totalLucro = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_PesquisaTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgv_k_Produtos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_PesquisarPorDia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpb_Pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_k_Produtos)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_PesquisarPorDia);
            this.k_panelCabecalho.Panel.Controls.Add(this.groupBox1);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Pesquisar);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(629, 360);
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
            // gpb_PesquisarPorDia
            // 
            this.gpb_PesquisarPorDia.BackColor = System.Drawing.Color.Transparent;
            this.gpb_PesquisarPorDia.Controls.Add(this.btn_K_PesquisarPorDia);
            this.gpb_PesquisarPorDia.Controls.Add(this.dtp_k_pesquisaindividual);
            this.gpb_PesquisarPorDia.Location = new System.Drawing.Point(375, 19);
            this.gpb_PesquisarPorDia.Name = "gpb_PesquisarPorDia";
            this.gpb_PesquisarPorDia.Size = new System.Drawing.Size(241, 68);
            this.gpb_PesquisarPorDia.TabIndex = 8;
            this.gpb_PesquisarPorDia.TabStop = false;
            this.gpb_PesquisarPorDia.Text = "Pesquisar Por Dia";
            // 
            // btn_K_PesquisarPorDia
            // 
            this.btn_K_PesquisarPorDia.Location = new System.Drawing.Point(121, 14);
            this.btn_K_PesquisarPorDia.Name = "btn_K_PesquisarPorDia";
            this.btn_K_PesquisarPorDia.Size = new System.Drawing.Size(114, 48);
            this.btn_K_PesquisarPorDia.TabIndex = 0;
            this.btn_K_PesquisarPorDia.Values.ExtraText = "Total";
            this.btn_K_PesquisarPorDia.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_K_PesquisarPorDia.Values.Image")));
            this.btn_K_PesquisarPorDia.Values.Text = "Pesquisar";
            this.btn_K_PesquisarPorDia.Click += new System.EventHandler(this.btn_K_PesquisarPorDia_Click);
            // 
            // dtp_k_pesquisaindividual
            // 
            this.dtp_k_pesquisaindividual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_k_pesquisaindividual.Location = new System.Drawing.Point(18, 41);
            this.dtp_k_pesquisaindividual.Name = "dtp_k_pesquisaindividual";
            this.dtp_k_pesquisaindividual.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.dtp_k_pesquisaindividual.Size = new System.Drawing.Size(97, 21);
            this.dtp_k_pesquisaindividual.TabIndex = 6;
            this.dtp_k_pesquisaindividual.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_PesquisarPorIntervalo);
            this.groupBox1.Controls.Add(this.dtp_k_2);
            this.groupBox1.Controls.Add(this.dtp_K_data1);
            this.groupBox1.Location = new System.Drawing.Point(11, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por Intervalo De Datas";
            // 
            // btn_PesquisarPorIntervalo
            // 
            this.btn_PesquisarPorIntervalo.Location = new System.Drawing.Point(241, 14);
            this.btn_PesquisarPorIntervalo.Name = "btn_PesquisarPorIntervalo";
            this.btn_PesquisarPorIntervalo.Size = new System.Drawing.Size(111, 48);
            this.btn_PesquisarPorIntervalo.TabIndex = 0;
            this.btn_PesquisarPorIntervalo.Values.ExtraText = "Tipo";
            this.btn_PesquisarPorIntervalo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_PesquisarPorIntervalo.Values.Image")));
            this.btn_PesquisarPorIntervalo.Values.Text = "Pesquisar";
            this.btn_PesquisarPorIntervalo.Click += new System.EventHandler(this.btn_PesquisarPorIntervalo_Click);
            // 
            // dtp_k_2
            // 
            this.dtp_k_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_k_2.Location = new System.Drawing.Point(126, 41);
            this.dtp_k_2.Name = "dtp_k_2";
            this.dtp_k_2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.dtp_k_2.Size = new System.Drawing.Size(97, 21);
            this.dtp_k_2.TabIndex = 6;
            this.dtp_k_2.TabStop = false;
            // 
            // dtp_K_data1
            // 
            this.dtp_K_data1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_K_data1.Location = new System.Drawing.Point(8, 41);
            this.dtp_K_data1.Name = "dtp_K_data1";
            this.dtp_K_data1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.dtp_K_data1.Size = new System.Drawing.Size(97, 21);
            this.dtp_K_data1.TabIndex = 6;
            this.dtp_K_data1.TabStop = false;
            // 
            // gpb_Pesquisar
            // 
            this.gpb_Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Pesquisar.Controls.Add(this.cbb_tipoVendaPagamento);
            this.gpb_Pesquisar.Controls.Add(this.lbl_totalLucro);
            this.gpb_Pesquisar.Controls.Add(this.lbl_PesquisaTotal);
            this.gpb_Pesquisar.Controls.Add(this.dgv_k_Produtos);
            this.gpb_Pesquisar.Location = new System.Drawing.Point(11, 93);
            this.gpb_Pesquisar.Name = "gpb_Pesquisar";
            this.gpb_Pesquisar.Size = new System.Drawing.Size(605, 214);
            this.gpb_Pesquisar.TabIndex = 5;
            this.gpb_Pesquisar.TabStop = false;
            this.gpb_Pesquisar.Text = "Pesquisar";
            // 
            // cbb_tipoVendaPagamento
            // 
            this.cbb_tipoVendaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_tipoVendaPagamento.FormattingEnabled = true;
            this.cbb_tipoVendaPagamento.Location = new System.Drawing.Point(239, 26);
            this.cbb_tipoVendaPagamento.Name = "cbb_tipoVendaPagamento";
            this.cbb_tipoVendaPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbb_tipoVendaPagamento.TabIndex = 0;
            this.cbb_tipoVendaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbb_tipoVendaPagamento_SelectedIndexChanged);
            // 
            // lbl_totalLucro
            // 
            this.lbl_totalLucro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_totalLucro.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_totalLucro.Location = new System.Drawing.Point(405, 12);
            this.lbl_totalLucro.Name = "lbl_totalLucro";
            this.lbl_totalLucro.Size = new System.Drawing.Size(206, 50);
            this.lbl_totalLucro.StateDisabled.LongText.Color1 = System.Drawing.Color.Black;
            this.lbl_totalLucro.StateDisabled.LongText.Color2 = System.Drawing.Color.Black;
            this.lbl_totalLucro.TabIndex = 5;
            this.lbl_totalLucro.TabStop = false;
            this.lbl_totalLucro.Values.ExtraText = "00.00";
            this.lbl_totalLucro.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_totalLucro.Values.Image")));
            this.lbl_totalLucro.Values.Text = "Total Venda";
            // 
            // lbl_PesquisaTotal
            // 
            this.lbl_PesquisaTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_PesquisaTotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_PesquisaTotal.Location = new System.Drawing.Point(44, 12);
            this.lbl_PesquisaTotal.Name = "lbl_PesquisaTotal";
            this.lbl_PesquisaTotal.Size = new System.Drawing.Size(200, 50);
            this.lbl_PesquisaTotal.StateDisabled.LongText.Color1 = System.Drawing.Color.Black;
            this.lbl_PesquisaTotal.StateDisabled.LongText.Color2 = System.Drawing.Color.Black;
            this.lbl_PesquisaTotal.TabIndex = 5;
            this.lbl_PesquisaTotal.TabStop = false;
            this.lbl_PesquisaTotal.Values.ExtraText = "00.00";
            this.lbl_PesquisaTotal.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_PesquisaTotal.Values.Image")));
            this.lbl_PesquisaTotal.Values.Text = "Total Lucro";
            // 
            // dgv_k_Produtos
            // 
            this.dgv_k_Produtos.AllowDrop = true;
            this.dgv_k_Produtos.AllowUserToAddRows = false;
            this.dgv_k_Produtos.AllowUserToDeleteRows = false;
            this.dgv_k_Produtos.AllowUserToOrderColumns = true;
            this.dgv_k_Produtos.AllowUserToResizeColumns = false;
            this.dgv_k_Produtos.AllowUserToResizeRows = false;
            this.dgv_k_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_k_Produtos.Location = new System.Drawing.Point(8, 66);
            this.dgv_k_Produtos.MultiSelect = false;
            this.dgv_k_Produtos.Name = "dgv_k_Produtos";
            this.dgv_k_Produtos.ReadOnly = true;
            this.dgv_k_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_k_Produtos.Size = new System.Drawing.Size(591, 141);
            this.dgv_k_Produtos.TabIndex = 0;
            this.dgv_k_Produtos.TabStop = false;
            // 
            // frmFluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 360);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFluxoDeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Lucro";
            this.Load += new System.EventHandler(this.frmFluxoDeCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_PesquisarPorDia.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gpb_Pesquisar.ResumeLayout(false);
            this.gpb_Pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_k_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_PesquisarPorDia;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_K_PesquisarPorDia;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PesquisarPorIntervalo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_k_2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_K_data1;
        private System.Windows.Forms.GroupBox gpb_Pesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_k_Produtos;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_k_pesquisaindividual;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_PesquisaTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_totalLucro;
        private System.Windows.Forms.ComboBox cbb_tipoVendaPagamento;
    }
}