namespace View
{
    partial class frmAlterarCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarCaixa));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IncluirCaixa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_RetiraCaixa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_ValorCaixa = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Saia = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_InserirCaixa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.label1);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_IncluirCaixa);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_RetiraCaixa);
            this.k_panelCabecalho.Panel.Controls.Add(this.lbl_ValorCaixa);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_Saia);
            this.k_panelCabecalho.Panel.Controls.Add(this.txt_InserirCaixa);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(248, 230);
            this.k_panelCabecalho.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            // 
            // btn_IncluirCaixa
            // 
            this.btn_IncluirCaixa.Location = new System.Drawing.Point(145, 104);
            this.btn_IncluirCaixa.Name = "btn_IncluirCaixa";
            this.btn_IncluirCaixa.Size = new System.Drawing.Size(47, 25);
            this.btn_IncluirCaixa.TabIndex = 3;
            this.btn_IncluirCaixa.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncluirCaixa.Values.Image")));
            this.btn_IncluirCaixa.Values.Text = "";
            this.btn_IncluirCaixa.Click += new System.EventHandler(this.btn_IncluirCaixa_Click);
            // 
            // btn_RetiraCaixa
            // 
            this.btn_RetiraCaixa.Location = new System.Drawing.Point(50, 104);
            this.btn_RetiraCaixa.Name = "btn_RetiraCaixa";
            this.btn_RetiraCaixa.Size = new System.Drawing.Size(47, 25);
            this.btn_RetiraCaixa.TabIndex = 2;
            this.btn_RetiraCaixa.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_RetiraCaixa.Values.Image")));
            this.btn_RetiraCaixa.Values.Text = "";
            this.btn_RetiraCaixa.Click += new System.EventHandler(this.btn_RetiraCaixa_Click);
            // 
            // lbl_ValorCaixa
            // 
            this.lbl_ValorCaixa.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lbl_ValorCaixa.Location = new System.Drawing.Point(24, 14);
            this.lbl_ValorCaixa.Name = "lbl_ValorCaixa";
            this.lbl_ValorCaixa.Size = new System.Drawing.Size(179, 34);
            this.lbl_ValorCaixa.TabIndex = 2;
            this.lbl_ValorCaixa.Values.ExtraText = "00.00";
            this.lbl_ValorCaixa.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ValorCaixa.Values.Image")));
            this.lbl_ValorCaixa.Values.Text = "Valor Atual Caixa";
            // 
            // btn_Saia
            // 
            this.btn_Saia.Location = new System.Drawing.Point(50, 135);
            this.btn_Saia.Name = "btn_Saia";
            this.btn_Saia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.btn_Saia.Size = new System.Drawing.Size(142, 25);
            this.btn_Saia.TabIndex = 4;
            this.btn_Saia.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Saia.Values.Image")));
            this.btn_Saia.Values.Text = "Sair";
            this.btn_Saia.Click += new System.EventHandler(this.btn_Saia_Click);
            // 
            // txt_InserirCaixa
            // 
            this.txt_InserirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InserirCaixa.Location = new System.Drawing.Point(50, 59);
            this.txt_InserirCaixa.MaxLength = 12;
            this.txt_InserirCaixa.Name = "txt_InserirCaixa";
            this.txt_InserirCaixa.Size = new System.Drawing.Size(145, 38);
            this.txt_InserirCaixa.TabIndex = 1;
            this.txt_InserirCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InserirCaixa_KeyPress);
            // 
            // frmAlterarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 230);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlterarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Valor No Caixa";
            this.Load += new System.EventHandler(this.frmAlterarCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            this.k_panelCabecalho.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Saia;
        private System.Windows.Forms.TextBox txt_InserirCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ValorCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_IncluirCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RetiraCaixa;
        private System.Windows.Forms.Label label1;
    }
}