namespace View
{
    partial class frmChamaCadastroLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamaCadastroLogin));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Usuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UsuarioSelecionado = new System.Windows.Forms.TextBox();
            this.btn_deletar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Alterar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Novo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_Usuario = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Usuario);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(564, 262);
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
            // gpb_Usuario
            // 
            this.gpb_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Usuario.Controls.Add(this.label1);
            this.gpb_Usuario.Controls.Add(this.txt_UsuarioSelecionado);
            this.gpb_Usuario.Controls.Add(this.btn_deletar);
            this.gpb_Usuario.Controls.Add(this.btn_Alterar);
            this.gpb_Usuario.Controls.Add(this.btn_Novo);
            this.gpb_Usuario.Controls.Add(this.dgv_Usuario);
            this.gpb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Usuario.Location = new System.Drawing.Point(11, 3);
            this.gpb_Usuario.Name = "gpb_Usuario";
            this.gpb_Usuario.Size = new System.Drawing.Size(540, 206);
            this.gpb_Usuario.TabIndex = 0;
            this.gpb_Usuario.TabStop = false;
            this.gpb_Usuario.Text = "Úsuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Úsuario Selecionado";
            // 
            // txt_UsuarioSelecionado
            // 
            this.txt_UsuarioSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioSelecionado.Location = new System.Drawing.Point(10, 36);
            this.txt_UsuarioSelecionado.MaxLength = 15;
            this.txt_UsuarioSelecionado.Name = "txt_UsuarioSelecionado";
            this.txt_UsuarioSelecionado.ReadOnly = true;
            this.txt_UsuarioSelecionado.Size = new System.Drawing.Size(179, 38);
            this.txt_UsuarioSelecionado.TabIndex = 5;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(460, 33);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_deletar.Size = new System.Drawing.Size(74, 41);
            this.btn_deletar.TabIndex = 10;
            this.btn_deletar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletar.Values.Image")));
            this.btn_deletar.Values.Text = "Deletar";
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(380, 33);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Alterar.Size = new System.Drawing.Size(74, 41);
            this.btn_Alterar.TabIndex = 9;
            this.btn_Alterar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Values.Image")));
            this.btn_Alterar.Values.Text = "Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(195, 33);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Novo.Size = new System.Drawing.Size(74, 41);
            this.btn_Novo.TabIndex = 7;
            this.btn_Novo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Values.Image")));
            this.btn_Novo.Values.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.AllowDrop = true;
            this.dgv_Usuario.AllowUserToAddRows = false;
            this.dgv_Usuario.AllowUserToDeleteRows = false;
            this.dgv_Usuario.AllowUserToOrderColumns = true;
            this.dgv_Usuario.AllowUserToResizeColumns = false;
            this.dgv_Usuario.AllowUserToResizeRows = false;
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuario.Location = new System.Drawing.Point(6, 90);
            this.dgv_Usuario.MultiSelect = false;
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.ReadOnly = true;
            this.dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuario.Size = new System.Drawing.Size(528, 110);
            this.dgv_Usuario.TabIndex = 1;
            this.dgv_Usuario.TabStop = false;
            this.dgv_Usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuario_CellClick);
            // 
            // frmChamaCadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChamaCadastroLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChamaCadastroLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmChamaCadastroLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Usuario.ResumeLayout(false);
            this.gpb_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_Usuario;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UsuarioSelecionado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_deletar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Alterar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Novo;
    }
}