namespace View
{
    partial class frmFiado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiado));
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.gpb_Pagamento = new System.Windows.Forms.GroupBox();
            this.btn_Pagar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalDivida = new System.Windows.Forms.TextBox();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clienteSelecionado = new System.Windows.Forms.TextBox();
            this.btn_deletar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Alterar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Novo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_cliente = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Pagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Pagamento);
            this.k_panelCabecalho.Panel.Controls.Add(this.label1);
            this.k_panelCabecalho.Panel.Controls.Add(this.txt_clienteSelecionado);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_deletar);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_Alterar);
            this.k_panelCabecalho.Panel.Controls.Add(this.btn_Novo);
            this.k_panelCabecalho.Panel.Controls.Add(this.dgv_cliente);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.k_panelCabecalho_Panel_Paint);
            this.k_panelCabecalho.Size = new System.Drawing.Size(640, 466);
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
            // gpb_Pagamento
            // 
            this.gpb_Pagamento.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Pagamento.Controls.Add(this.btn_Pagar);
            this.gpb_Pagamento.Controls.Add(this.label3);
            this.gpb_Pagamento.Controls.Add(this.label2);
            this.gpb_Pagamento.Controls.Add(this.txt_TotalDivida);
            this.gpb_Pagamento.Controls.Add(this.txt_ValorPago);
            this.gpb_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Pagamento.Location = new System.Drawing.Point(21, 305);
            this.gpb_Pagamento.Name = "gpb_Pagamento";
            this.gpb_Pagamento.Size = new System.Drawing.Size(591, 100);
            this.gpb_Pagamento.TabIndex = 12;
            this.gpb_Pagamento.TabStop = false;
            this.gpb_Pagamento.Text = "Pagamento";
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Location = new System.Drawing.Point(424, 31);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(139, 38);
            this.btn_Pagar.TabIndex = 2;
            this.btn_Pagar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pagar.Values.Image")));
            this.btn_Pagar.Values.Text = "Pagar";
            this.btn_Pagar.Click += new System.EventHandler(this.btn_Pagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Pago";
            // 
            // txt_TotalDivida
            // 
            this.txt_TotalDivida.Enabled = false;
            this.txt_TotalDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalDivida.Location = new System.Drawing.Point(297, 31);
            this.txt_TotalDivida.MaxLength = 10;
            this.txt_TotalDivida.Name = "txt_TotalDivida";
            this.txt_TotalDivida.Size = new System.Drawing.Size(100, 38);
            this.txt_TotalDivida.TabIndex = 0;
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorPago.Location = new System.Drawing.Point(81, 31);
            this.txt_ValorPago.MaxLength = 10;
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(100, 38);
            this.txt_ValorPago.TabIndex = 0;
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente Selecionado";
            // 
            // txt_clienteSelecionado
            // 
            this.txt_clienteSelecionado.Enabled = false;
            this.txt_clienteSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clienteSelecionado.Location = new System.Drawing.Point(21, 43);
            this.txt_clienteSelecionado.MaxLength = 50;
            this.txt_clienteSelecionado.Name = "txt_clienteSelecionado";
            this.txt_clienteSelecionado.Size = new System.Drawing.Size(282, 38);
            this.txt_clienteSelecionado.TabIndex = 5;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(538, 43);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_deletar.Size = new System.Drawing.Size(74, 41);
            this.btn_deletar.TabIndex = 11;
            this.btn_deletar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_deletar.Values.Image")));
            this.btn_deletar.Values.Text = "Deletar";
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(445, 42);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Alterar.Size = new System.Drawing.Size(74, 41);
            this.btn_Alterar.TabIndex = 10;
            this.btn_Alterar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Values.Image")));
            this.btn_Alterar.Values.Text = "Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(318, 40);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Novo.Size = new System.Drawing.Size(74, 41);
            this.btn_Novo.TabIndex = 8;
            this.btn_Novo.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Values.Image")));
            this.btn_Novo.Values.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.AllowUserToOrderColumns = true;
            this.dgv_cliente.AllowUserToResizeColumns = false;
            this.dgv_cliente.AllowUserToResizeRows = false;
            this.dgv_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cliente.Location = new System.Drawing.Point(21, 89);
            this.dgv_cliente.MultiSelect = false;
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.Size = new System.Drawing.Size(591, 209);
            this.dgv_cliente.TabIndex = 6;
            this.dgv_cliente.TabStop = false;
            this.dgv_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellClick);
            // 
            // frmFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 466);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFiado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Cliente";
            this.Load += new System.EventHandler(this.frmFiado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            this.k_panelCabecalho.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Pagamento.ResumeLayout(false);
            this.gpb_Pagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_clienteSelecionado;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_deletar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Alterar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Novo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_cliente;
        private System.Windows.Forms.GroupBox gpb_Pagamento;
        private System.Windows.Forms.TextBox txt_TotalDivida;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Pagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}