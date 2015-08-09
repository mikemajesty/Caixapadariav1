namespace View
{
    partial class frmCadastroDeCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDeCategoria));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Produto = new System.Windows.Forms.GroupBox();
            this.btn_k_Cancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_k_Confirmar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gpp_Detales = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NomeCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Produto.SuspendLayout();
            this.gpp_Detales.SuspendLayout();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Produto);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(248, 222);
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
            // gpb_Produto
            // 
            this.gpb_Produto.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Produto.Controls.Add(this.btn_k_Cancelar);
            this.gpb_Produto.Controls.Add(this.btn_k_Confirmar);
            this.gpb_Produto.Controls.Add(this.gpp_Detales);
            this.gpb_Produto.Location = new System.Drawing.Point(11, 3);
            this.gpb_Produto.Name = "gpb_Produto";
            this.gpb_Produto.Size = new System.Drawing.Size(217, 166);
            this.gpb_Produto.TabIndex = 1;
            this.gpb_Produto.TabStop = false;
            this.gpb_Produto.Text = "Produto";
            // 
            // btn_k_Cancelar
            // 
            this.btn_k_Cancelar.Location = new System.Drawing.Point(112, 108);
            this.btn_k_Cancelar.Name = "btn_k_Cancelar";
            this.btn_k_Cancelar.Size = new System.Drawing.Size(89, 48);
            this.btn_k_Cancelar.TabIndex = 3;
            this.btn_k_Cancelar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_k_Cancelar.Values.Image")));
            this.btn_k_Cancelar.Values.Text = "Sair";
            this.btn_k_Cancelar.Click += new System.EventHandler(this.btn_k_Cancelar_Click);
            // 
            // btn_k_Confirmar
            // 
            this.btn_k_Confirmar.Location = new System.Drawing.Point(16, 108);
            this.btn_k_Confirmar.Name = "btn_k_Confirmar";
            this.btn_k_Confirmar.Size = new System.Drawing.Size(90, 48);
            this.btn_k_Confirmar.TabIndex = 2;
            this.btn_k_Confirmar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_k_Confirmar.Values.Image")));
            this.btn_k_Confirmar.Values.Text = "Confirmar";
            this.btn_k_Confirmar.Click += new System.EventHandler(this.btn_k_Confirmar_Click);
            // 
            // gpp_Detales
            // 
            this.gpp_Detales.Controls.Add(this.label2);
            this.gpp_Detales.Controls.Add(this.label1);
            this.gpp_Detales.Controls.Add(this.txt_NomeCategoria);
            this.gpp_Detales.Location = new System.Drawing.Point(6, 19);
            this.gpp_Detales.Name = "gpp_Detales";
            this.gpp_Detales.Size = new System.Drawing.Size(203, 81);
            this.gpp_Detales.TabIndex = 10;
            this.gpp_Detales.TabStop = false;
            this.gpp_Detales.Text = "Detales Da Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Da Categoria";
            // 
            // txt_NomeCategoria
            // 
            this.txt_NomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeCategoria.Location = new System.Drawing.Point(20, 33);
            this.txt_NomeCategoria.MaxLength = 20;
            this.txt_NomeCategoria.Name = "txt_NomeCategoria";
            this.txt_NomeCategoria.Size = new System.Drawing.Size(173, 38);
            this.txt_NomeCategoria.TabIndex = 1;
            // 
            // frmCadastroDeCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 222);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroDeCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Categoria";
            this.Load += new System.EventHandler(this.frmCadastroDeCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Produto.ResumeLayout(false);
            this.gpp_Detales.ResumeLayout(false);
            this.gpp_Detales.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeCategoria;
        private System.Windows.Forms.Label label2;

    }
}