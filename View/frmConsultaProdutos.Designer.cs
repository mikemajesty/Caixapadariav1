namespace View
{
    partial class frmConsultaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProdutos));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnCarregarPorUnidade = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCarregarPorPeso = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gpb_TipoDePesquisa = new System.Windows.Forms.GroupBox();
            this.ckb_PorPeso = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_PesquisaProduto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbb_TipoDePesquisa = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbl_TipoDaPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gpb_Pesquisar = new System.Windows.Forms.GroupBox();
            this.dgv_k_Produtos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_TipoDePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TipoDePesquisa)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.btnCarregarPorUnidade);
            this.k_panelCabecalho.Panel.Controls.Add(this.btnCarregarPorPeso);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_TipoDePesquisa);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Pesquisar);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(809, 351);
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
            // btnCarregarPorUnidade
            // 
            this.btnCarregarPorUnidade.Location = new System.Drawing.Point(397, 84);
            this.btnCarregarPorUnidade.Name = "btnCarregarPorUnidade";
            this.btnCarregarPorUnidade.Size = new System.Drawing.Size(181, 27);
            this.btnCarregarPorUnidade.TabIndex = 10;
            this.btnCarregarPorUnidade.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarPorUnidade.Values.Image")));
            this.btnCarregarPorUnidade.Values.Text = "Carregar Por Unidade";
            this.btnCarregarPorUnidade.Click += new System.EventHandler(this.btnCarregarPorUnidade_Click);
            // 
            // btnCarregarPorPeso
            // 
            this.btnCarregarPorPeso.Location = new System.Drawing.Point(618, 84);
            this.btnCarregarPorPeso.Name = "btnCarregarPorPeso";
            this.btnCarregarPorPeso.Size = new System.Drawing.Size(172, 27);
            this.btnCarregarPorPeso.TabIndex = 10;
            this.btnCarregarPorPeso.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregarPorPeso.Values.Image")));
            this.btnCarregarPorPeso.Values.Text = "Carregar Por peso";
            this.btnCarregarPorPeso.Click += new System.EventHandler(this.btnCarregarPorPeso_Click);
            // 
            // gpb_TipoDePesquisa
            // 
            this.gpb_TipoDePesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gpb_TipoDePesquisa.Controls.Add(this.ckb_PorPeso);
            this.gpb_TipoDePesquisa.Controls.Add(this.label2);
            this.gpb_TipoDePesquisa.Controls.Add(this.label1);
            this.gpb_TipoDePesquisa.Controls.Add(this.btn_Pesquisar);
            this.gpb_TipoDePesquisa.Controls.Add(this.txt_PesquisaProduto);
            this.gpb_TipoDePesquisa.Controls.Add(this.cbb_TipoDePesquisa);
            this.gpb_TipoDePesquisa.Controls.Add(this.lbl_TipoDaPesquisa);
            this.gpb_TipoDePesquisa.Controls.Add(this.kryptonLabel1);
            this.gpb_TipoDePesquisa.Location = new System.Drawing.Point(17, 14);
            this.gpb_TipoDePesquisa.Name = "gpb_TipoDePesquisa";
            this.gpb_TipoDePesquisa.Size = new System.Drawing.Size(779, 70);
            this.gpb_TipoDePesquisa.TabIndex = 9;
            this.gpb_TipoDePesquisa.TabStop = false;
            this.gpb_TipoDePesquisa.Text = "Tipo De Pesquisa";
            // 
            // ckb_PorPeso
            // 
            this.ckb_PorPeso.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ckb_PorPeso.AutoSize = false;
            this.ckb_PorPeso.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right;
            this.ckb_PorPeso.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.ckb_PorPeso.Location = new System.Drawing.Point(132, 12);
            this.ckb_PorPeso.Name = "ckb_PorPeso";
            this.ckb_PorPeso.Size = new System.Drawing.Size(228, 26);
            this.ckb_PorPeso.TabIndex = 10;
            this.ckb_PorPeso.Text = "Por Peso";
            this.ckb_PorPeso.Values.Image = ((System.Drawing.Image)(resources.GetObject("ckb_PorPeso.Values.Image")));
            this.ckb_PorPeso.Values.Text = "Por Peso";
            this.ckb_PorPeso.CheckedChanged += new System.EventHandler(this.ckb_PorPeso_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(175, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(380, 9);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Pesquisar.Size = new System.Drawing.Size(393, 55);
            this.btn_Pesquisar.TabIndex = 2;
            this.btn_Pesquisar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Values.Image")));
            this.btn_Pesquisar.Values.Text = "Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_PesquisaProduto
            // 
            this.txt_PesquisaProduto.Location = new System.Drawing.Point(188, 44);
            this.txt_PesquisaProduto.MaxLength = 15;
            this.txt_PesquisaProduto.Name = "txt_PesquisaProduto";
            this.txt_PesquisaProduto.Size = new System.Drawing.Size(172, 20);
            this.txt_PesquisaProduto.TabIndex = 1;
            this.txt_PesquisaProduto.TextChanged += new System.EventHandler(this.txt_PesquisaProduto_TextChanged);
            this.txt_PesquisaProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PesquisaProduto_KeyPress);
            // 
            // cbb_TipoDePesquisa
            // 
            this.cbb_TipoDePesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TipoDePesquisa.DropDownWidth = 136;
            this.cbb_TipoDePesquisa.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbb_TipoDePesquisa.Location = new System.Drawing.Point(36, 43);
            this.cbb_TipoDePesquisa.Name = "cbb_TipoDePesquisa";
            this.cbb_TipoDePesquisa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.cbb_TipoDePesquisa.Size = new System.Drawing.Size(136, 21);
            this.cbb_TipoDePesquisa.TabIndex = 0;
            this.cbb_TipoDePesquisa.SelectedIndexChanged += new System.EventHandler(this.cbb_TipoDePesquisa_SelectedIndexChanged);
            // 
            // lbl_TipoDaPesquisa
            // 
            this.lbl_TipoDaPesquisa.Location = new System.Drawing.Point(193, 30);
            this.lbl_TipoDaPesquisa.Name = "lbl_TipoDaPesquisa";
            this.lbl_TipoDaPesquisa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.lbl_TipoDaPesquisa.Size = new System.Drawing.Size(6, 2);
            this.lbl_TipoDaPesquisa.TabIndex = 6;
            this.lbl_TipoDaPesquisa.Values.Text = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(36, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(104, 20);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Tipo De Pesquisa";
            // 
            // gpb_Pesquisar
            // 
            this.gpb_Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Pesquisar.Controls.Add(this.dgv_k_Produtos);
            this.gpb_Pesquisar.Location = new System.Drawing.Point(17, 108);
            this.gpb_Pesquisar.Name = "gpb_Pesquisar";
            this.gpb_Pesquisar.Size = new System.Drawing.Size(779, 187);
            this.gpb_Pesquisar.TabIndex = 1;
            this.gpb_Pesquisar.TabStop = false;
            this.gpb_Pesquisar.Text = "Pesquisar";
            // 
            // dgv_k_Produtos
            // 
            this.dgv_k_Produtos.AllowUserToAddRows = false;
            this.dgv_k_Produtos.AllowUserToDeleteRows = false;
            this.dgv_k_Produtos.AllowUserToOrderColumns = true;
            this.dgv_k_Produtos.AllowUserToResizeColumns = false;
            this.dgv_k_Produtos.AllowUserToResizeRows = false;
            this.dgv_k_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_k_Produtos.Location = new System.Drawing.Point(8, 24);
            this.dgv_k_Produtos.MultiSelect = false;
            this.dgv_k_Produtos.Name = "dgv_k_Produtos";
            this.dgv_k_Produtos.ReadOnly = true;
            this.dgv_k_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_k_Produtos.Size = new System.Drawing.Size(765, 157);
            this.dgv_k_Produtos.TabIndex = 0;
            this.dgv_k_Produtos.TabStop = false;
            // 
            // frmConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 351);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta De Produtos";
            this.Load += new System.EventHandler(this.frmConsultaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_TipoDePesquisa.ResumeLayout(false);
            this.gpb_TipoDePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_TipoDePesquisa)).EndInit();
            this.gpb_Pesquisar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_k_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Pesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_k_Produtos;
        private System.Windows.Forms.GroupBox gpb_TipoDePesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Pesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_PesquisaProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_TipoDePesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_TipoDaPesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ckb_PorPeso;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCarregarPorUnidade;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCarregarPorPeso;
    }
}