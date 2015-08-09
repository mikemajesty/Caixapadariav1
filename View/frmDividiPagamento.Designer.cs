namespace View
{
    partial class frmDividiPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDividiPagamento));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_TipoDePagamento = new System.Windows.Forms.GroupBox();
            this.gpb_Total = new System.Windows.Forms.GroupBox();
            this.lbl_Total = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_ValorDoTroco = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gpb_TerminarVenda = new System.Windows.Forms.GroupBox();
            this.btn_ConcluirVenda = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gpb_GerarTroco = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.btn_Troco = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_TipoDePagamento = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_TipoPagamento = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_GerarParcelas = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valorParcela = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.cbb_Parcelar = new ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_TipoDePagamento);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_GerarParcelas);
            this.k_panelCabecalho.Panel.Controls.Add(this.label2);
            this.k_panelCabecalho.Panel.Controls.Add(this.label4);
            this.k_panelCabecalho.Panel.Controls.Add(this.txt_valorParcela);
            this.k_panelCabecalho.Panel.Controls.Add(this.label1);
            this.k_panelCabecalho.Panel.Controls.Add(this.txt_Total);
            this.k_panelCabecalho.Panel.Controls.Add(this.cbb_Parcelar);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(689, 332);
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
            // gpb_TipoDePagamento
            // 
            this.gpb_TipoDePagamento.BackColor = System.Drawing.Color.Transparent;
            this.gpb_TipoDePagamento.Controls.Add(this.gpb_Total);
            this.gpb_TipoDePagamento.Controls.Add(this.gpb_TerminarVenda);
            this.gpb_TipoDePagamento.Controls.Add(this.gpb_GerarTroco);
            this.gpb_TipoDePagamento.Controls.Add(this.lbl_TipoDePagamento);
            this.gpb_TipoDePagamento.Controls.Add(this.cbb_TipoPagamento);
            this.gpb_TipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_TipoDePagamento.ForeColor = System.Drawing.Color.Black;
            this.gpb_TipoDePagamento.Location = new System.Drawing.Point(11, 116);
            this.gpb_TipoDePagamento.Name = "gpb_TipoDePagamento";
            this.gpb_TipoDePagamento.Size = new System.Drawing.Size(666, 160);
            this.gpb_TipoDePagamento.TabIndex = 4;
            this.gpb_TipoDePagamento.TabStop = false;
            this.gpb_TipoDePagamento.Text = "Tipo De Pagamento";
            // 
            // gpb_Total
            // 
            this.gpb_Total.Controls.Add(this.lbl_Total);
            this.gpb_Total.Controls.Add(this.lbl_ValorDoTroco);
            this.gpb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Total.ForeColor = System.Drawing.Color.Black;
            this.gpb_Total.Location = new System.Drawing.Point(484, 19);
            this.gpb_Total.Name = "gpb_Total";
            this.gpb_Total.Size = new System.Drawing.Size(176, 131);
            this.gpb_Total.TabIndex = 7;
            this.gpb_Total.TabStop = false;
            this.gpb_Total.Text = "Total";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbl_Total.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_Total.Location = new System.Drawing.Point(6, 67);
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
            this.btn_ConcluirVenda.Location = new System.Drawing.Point(20, 19);
            this.btn_ConcluirVenda.Name = "btn_ConcluirVenda";
            this.btn_ConcluirVenda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btn_ConcluirVenda.Size = new System.Drawing.Size(233, 74);
            this.btn_ConcluirVenda.TabIndex = 0;
            this.btn_ConcluirVenda.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConcluirVenda.Values.Image")));
            this.btn_ConcluirVenda.Values.Text = "Pagar Parcela";
            this.btn_ConcluirVenda.Click += new System.EventHandler(this.btn_ConcluirVenda_Click);
            // 
            // gpb_GerarTroco
            // 
            this.gpb_GerarTroco.Controls.Add(this.label3);
            this.gpb_GerarTroco.Controls.Add(this.txt_ValorPago);
            this.gpb_GerarTroco.Controls.Add(this.btn_Troco);
            this.gpb_GerarTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_GerarTroco.ForeColor = System.Drawing.Color.Black;
            this.gpb_GerarTroco.Location = new System.Drawing.Point(321, 19);
            this.gpb_GerarTroco.Name = "gpb_GerarTroco";
            this.gpb_GerarTroco.Size = new System.Drawing.Size(148, 130);
            this.gpb_GerarTroco.TabIndex = 5;
            this.gpb_GerarTroco.TabStop = false;
            this.gpb_GerarTroco.Text = "Troco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Valor Pago";
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorPago.Location = new System.Drawing.Point(26, 30);
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(100, 44);
            this.txt_ValorPago.TabIndex = 0;
            this.txt_ValorPago.TextChanged += new System.EventHandler(this.txt_ValorPago_TextChanged);
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
            // btn_GerarParcelas
            // 
            this.btn_GerarParcelas.Location = new System.Drawing.Point(293, 5);
            this.btn_GerarParcelas.Name = "btn_GerarParcelas";
            this.btn_GerarParcelas.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_GerarParcelas.Size = new System.Drawing.Size(241, 108);
            this.btn_GerarParcelas.TabIndex = 3;
            this.btn_GerarParcelas.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_GerarParcelas.Values.Image")));
            this.btn_GerarParcelas.Values.Text = "Parcelar";
            this.btn_GerarParcelas.Click += new System.EventHandler(this.btn_GerarParcelas_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total De Parcelas";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 69);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parcela Valor R$";
            // 
            // txt_valorParcela
            // 
            this.txt_valorParcela.Enabled = false;
            this.txt_valorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorParcela.Location = new System.Drawing.Point(556, 75);
            this.txt_valorParcela.Name = "txt_valorParcela";
            this.txt_valorParcela.Size = new System.Drawing.Size(115, 38);
            this.txt_valorParcela.TabIndex = 1;
            this.txt_valorParcela.TabStop = false;
            this.txt_valorParcela.TextChanged += new System.EventHandler(this.txt_valorParcela_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Total R$";
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(17, 75);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(115, 38);
            this.txt_Total.TabIndex = 1;
            this.txt_Total.TabStop = false;
            // 
            // cbb_Parcelar
            // 
            this.cbb_Parcelar.Items.Add("10");
            this.cbb_Parcelar.Items.Add("2");
            this.cbb_Parcelar.Items.Add("3");
            this.cbb_Parcelar.Items.Add("4");
            this.cbb_Parcelar.Items.Add("5");
            this.cbb_Parcelar.Items.Add("6");
            this.cbb_Parcelar.Items.Add("7");
            this.cbb_Parcelar.Items.Add("8");
            this.cbb_Parcelar.Items.Add("9");
            this.cbb_Parcelar.Location = new System.Drawing.Point(161, 88);
            this.cbb_Parcelar.Name = "cbb_Parcelar";
            this.cbb_Parcelar.ReadOnly = true;
            this.cbb_Parcelar.Size = new System.Drawing.Size(115, 22);
            this.cbb_Parcelar.TabIndex = 0;
            this.cbb_Parcelar.TabStop = false;
            this.cbb_Parcelar.Text = "2";
            // 
            // frmDividiPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 332);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDividiPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividir Pagamento";
            this.Load += new System.EventHandler(this.frmDividiPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            this.k_panelCabecalho.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Total;
        private ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown cbb_Parcelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_GerarParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpb_TipoDePagamento;
        private System.Windows.Forms.GroupBox gpb_Total;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Total;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ValorDoTroco;
        private System.Windows.Forms.GroupBox gpb_TerminarVenda;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ConcluirVenda;
        private System.Windows.Forms.GroupBox gpb_GerarTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Troco;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_TipoDePagamento;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_TipoPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valorParcela;
    }
}