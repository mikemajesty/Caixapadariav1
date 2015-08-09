namespace View
{
    partial class frmChamaCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamaCadastroProduto));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Categoria = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.btn_deletar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Alterar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Novo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Pesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_produto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Categoria);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(715, 368);
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
            // gpb_Categoria
            // 
            this.gpb_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Categoria.Controls.Add(this.label1);
            this.gpb_Categoria.Controls.Add(this.txt_produto);
            this.gpb_Categoria.Controls.Add(this.btn_deletar);
            this.gpb_Categoria.Controls.Add(this.btn_Alterar);
            this.gpb_Categoria.Controls.Add(this.btn_Novo);
            this.gpb_Categoria.Controls.Add(this.btn_Pesquisar);
            this.gpb_Categoria.Controls.Add(this.dgv_produto);
            this.gpb_Categoria.Location = new System.Drawing.Point(11, 3);
            this.gpb_Categoria.Name = "gpb_Categoria";
            this.gpb_Categoria.Size = new System.Drawing.Size(691, 304);
            this.gpb_Categoria.TabIndex = 2;
            this.gpb_Categoria.TabStop = false;
            this.gpb_Categoria.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Do Produto";
            // 
            // txt_produto
            // 
            this.txt_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produto.Location = new System.Drawing.Point(9, 36);
            this.txt_produto.MaxLength = 10;
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(168, 38);
            this.txt_produto.TabIndex = 0;
            this.txt_produto.TextChanged += new System.EventHandler(this.txt_produto_TextChanged);
            this.txt_produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_produto_KeyPress);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(611, 34);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_deletar.Size = new System.Drawing.Size(74, 41);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletar.Values.Image")));
            this.btn_deletar.Values.Text = "Deletar";
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(512, 34);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Alterar.Size = new System.Drawing.Size(74, 41);
            this.btn_Alterar.TabIndex = 3;
            this.btn_Alterar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Values.Image")));
            this.btn_Alterar.Values.Text = "Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(361, 34);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Novo.Size = new System.Drawing.Size(74, 41);
            this.btn_Novo.TabIndex = 2;
            this.btn_Novo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Values.Image")));
            this.btn_Novo.Values.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(183, 34);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(108, 41);
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Values.Image")));
            this.btn_Pesquisar.Values.Text = "Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // dgv_produto
            // 
            this.dgv_produto.AllowUserToAddRows = false;
            this.dgv_produto.AllowUserToDeleteRows = false;
            this.dgv_produto.AllowUserToOrderColumns = true;
            this.dgv_produto.AllowUserToResizeColumns = false;
            this.dgv_produto.AllowUserToResizeRows = false;
            this.dgv_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_produto.Location = new System.Drawing.Point(9, 82);
            this.dgv_produto.MultiSelect = false;
            this.dgv_produto.Name = "dgv_produto";
            this.dgv_produto.ReadOnly = true;
            this.dgv_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produto.Size = new System.Drawing.Size(679, 216);
            this.dgv_produto.TabIndex = 0;
            this.dgv_produto.TabStop = false;
            this.dgv_produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produto_CellClick);
            // 
            // frmChamaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 368);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChamaCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Produto";
            this.Load += new System.EventHandler(this.frmChamaCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Categoria.ResumeLayout(false);
            this.gpb_Categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_produto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_deletar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Alterar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Novo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Pesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_produto;
    }
}