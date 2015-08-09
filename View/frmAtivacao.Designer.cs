namespace View
{
    partial class frmAtivacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtivacao));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.txt_Validacao = new System.Windows.Forms.TextBox();
            this.btn_Ativar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.txt_Validacao);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_Ativar);
            this.k_panelCabecalho.Panel.Controls.Add(this.label1);
            this.k_panelCabecalho.Panel.Controls.Add(this.lbl_Numero);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(344, 157);
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
            // 
            // btn_Sair
            // 
            this.btn_Sair.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.UniqueName = "B24EDB7BA17B41152E94D952E272EA35";
            // 
            // txt_Validacao
            // 
            this.txt_Validacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Validacao.Location = new System.Drawing.Point(29, 31);
            this.txt_Validacao.Name = "txt_Validacao";
            this.txt_Validacao.Size = new System.Drawing.Size(201, 38);
            this.txt_Validacao.TabIndex = 9;
            // 
            // btn_Ativar
            // 
            this.btn_Ativar.Location = new System.Drawing.Point(236, 31);
            this.btn_Ativar.Name = "btn_Ativar";
            this.btn_Ativar.Size = new System.Drawing.Size(75, 37);
            this.btn_Ativar.TabIndex = 8;
            this.btn_Ativar.Text = "Ativar";
            this.btn_Ativar.UseVisualStyleBackColor = true;
            this.btn_Ativar.Click += new System.EventHandler(this.btn_Ativar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Licença expirada, contate o administrador";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(31, 12);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(62, 16);
            this.lbl_Numero.TabIndex = 7;
            this.lbl_Numero.Text = "*********";
            // 
            // frmAtivacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 157);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAtivacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ativação Do Sistema";
            this.Load += new System.EventHandler(this.frmAtivacao_Load);
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
        private System.Windows.Forms.TextBox txt_Validacao;
        private System.Windows.Forms.Button btn_Ativar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Numero;
    }
}