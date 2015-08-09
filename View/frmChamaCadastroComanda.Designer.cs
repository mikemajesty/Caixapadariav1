namespace View
{
    partial class frmChamaCadastroComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamaCadastroComanda));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Comanda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_comandaSelecionada = new System.Windows.Forms.TextBox();
            this.btn_deletar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Alterar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Novo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_Comanda = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Comanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Comanda)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Comanda);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(488, 392);
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
            // gpb_Comanda
            // 
            this.gpb_Comanda.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Comanda.Controls.Add(this.label1);
            this.gpb_Comanda.Controls.Add(this.txt_comandaSelecionada);
            this.gpb_Comanda.Controls.Add(this.btn_deletar);
            this.gpb_Comanda.Controls.Add(this.btn_Alterar);
            this.gpb_Comanda.Controls.Add(this.btn_Novo);
            this.gpb_Comanda.Controls.Add(this.dgv_Comanda);
            this.gpb_Comanda.Location = new System.Drawing.Point(11, 13);
            this.gpb_Comanda.Name = "gpb_Comanda";
            this.gpb_Comanda.Size = new System.Drawing.Size(464, 326);
            this.gpb_Comanda.TabIndex = 0;
            this.gpb_Comanda.TabStop = false;
            this.gpb_Comanda.Text = "Comamda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecionado";
            // 
            // txt_comandaSelecionada
            // 
            this.txt_comandaSelecionada.Enabled = false;
            this.txt_comandaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comandaSelecionada.Location = new System.Drawing.Point(4, 43);
            this.txt_comandaSelecionada.MaxLength = 50;
            this.txt_comandaSelecionada.Name = "txt_comandaSelecionada";
            this.txt_comandaSelecionada.ReadOnly = true;
            this.txt_comandaSelecionada.Size = new System.Drawing.Size(177, 38);
            this.txt_comandaSelecionada.TabIndex = 12;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(390, 40);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_deletar.Size = new System.Drawing.Size(68, 41);
            this.btn_deletar.TabIndex = 17;
            this.btn_deletar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletar.Values.Image")));
            this.btn_deletar.Values.Text = "Deletar";
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click_1);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(313, 40);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Alterar.Size = new System.Drawing.Size(71, 41);
            this.btn_Alterar.TabIndex = 16;
            this.btn_Alterar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Values.Image")));
            this.btn_Alterar.Values.Text = "Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click_1);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(187, 40);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Novo.Size = new System.Drawing.Size(69, 41);
            this.btn_Novo.TabIndex = 14;
            this.btn_Novo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Values.Image")));
            this.btn_Novo.Values.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click_1);
            // 
            // dgv_Comanda
            // 
            this.dgv_Comanda.AllowUserToAddRows = false;
            this.dgv_Comanda.AllowUserToDeleteRows = false;
            this.dgv_Comanda.AllowUserToOrderColumns = true;
            this.dgv_Comanda.AllowUserToResizeColumns = false;
            this.dgv_Comanda.AllowUserToResizeRows = false;
            this.dgv_Comanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Comanda.Location = new System.Drawing.Point(4, 104);
            this.dgv_Comanda.MultiSelect = false;
            this.dgv_Comanda.Name = "dgv_Comanda";
            this.dgv_Comanda.ReadOnly = true;
            this.dgv_Comanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Comanda.Size = new System.Drawing.Size(451, 216);
            this.dgv_Comanda.TabIndex = 13;
            this.dgv_Comanda.TabStop = false;
            this.dgv_Comanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Comanda_CellClick);
            // 
            // frmChamaCadastroComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 392);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChamaCadastroComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Comanda";
            this.Load += new System.EventHandler(this.frmChamaCadastroComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Comanda.ResumeLayout(false);
            this.gpb_Comanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Comanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Comanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_comandaSelecionada;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_deletar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Alterar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Novo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_Comanda;
    }
}