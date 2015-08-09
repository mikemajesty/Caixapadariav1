namespace View
{
    partial class frmAlterarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.k_panelCabecalho = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_Minimize = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ValorRetiradoDoEstoque = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpb_Estoque = new System.Windows.Forms.GroupBox();
            this.dgv_Estoque = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gpb_AlterarEstoque = new System.Windows.Forms.GroupBox();
            this.lblParametroOperacao = new System.Windows.Forms.Label();
            this.rdb_SemCodigoDeBarra = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gpb_Operacao = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSomeAparece = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoDoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.btn_Retirar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Incluir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rdb_ComCodigoDeBarra = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).BeginInit();
            this.k_panelCabecalho.Panel.SuspendLayout();
            this.k_panelCabecalho.SuspendLayout();
            this.gpb_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estoque)).BeginInit();
            this.gpb_AlterarEstoque.SuspendLayout();
            this.gpb_Operacao.SuspendLayout();
            this.pnlSomeAparece.SuspendLayout();
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
            this.k_panelCabecalho.Panel.Controls.Add(this.label5);
            this.k_panelCabecalho.Panel.Controls.Add(this.label8);
            this.k_panelCabecalho.Panel.Controls.Add(this.lbl_ValorRetiradoDoEstoque);
            this.k_panelCabecalho.Panel.Controls.Add(this.label6);
            this.k_panelCabecalho.Panel.Controls.Add(this.textBox3);
            this.k_panelCabecalho.Panel.Controls.Add(this.textBox2);
            this.k_panelCabecalho.Panel.Controls.Add(this.textBox1);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_Estoque);
            this.k_panelCabecalho.Panel.Controls.Add(this.gpb_AlterarEstoque);
            this.k_panelCabecalho.Panel.Tag = "";
            this.k_panelCabecalho.Size = new System.Drawing.Size(903, 371);
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(815, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Baixo";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(815, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Normal";
            // 
            // lbl_ValorRetiradoDoEstoque
            // 
            this.lbl_ValorRetiradoDoEstoque.AutoSize = false;
            this.lbl_ValorRetiradoDoEstoque.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_ValorRetiradoDoEstoque.Location = new System.Drawing.Point(11, 262);
            this.lbl_ValorRetiradoDoEstoque.Name = "lbl_ValorRetiradoDoEstoque";
            this.lbl_ValorRetiradoDoEstoque.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.lbl_ValorRetiradoDoEstoque.Size = new System.Drawing.Size(870, 46);
            this.lbl_ValorRetiradoDoEstoque.TabIndex = 5;
            this.lbl_ValorRetiradoDoEstoque.TabStop = false;
            this.lbl_ValorRetiradoDoEstoque.Values.ExtraText = "??";
            this.lbl_ValorRetiradoDoEstoque.Values.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ValorRetiradoDoEstoque.Values.Image")));
            this.lbl_ValorRetiradoDoEstoque.Values.Text = "Produto";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(815, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Acima";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gold;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(792, 202);
            this.textBox3.MaxLength = 0;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(89, 60);
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(792, 9);
            this.textBox2.MaxLength = 0;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(89, 60);
            this.textBox2.TabIndex = 6;
            this.textBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(792, 101);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(89, 60);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            // 
            // gpb_Estoque
            // 
            this.gpb_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Estoque.Controls.Add(this.dgv_Estoque);
            this.gpb_Estoque.Location = new System.Drawing.Point(347, 3);
            this.gpb_Estoque.Name = "gpb_Estoque";
            this.gpb_Estoque.Size = new System.Drawing.Size(440, 259);
            this.gpb_Estoque.TabIndex = 2;
            this.gpb_Estoque.TabStop = false;
            this.gpb_Estoque.Text = "Estoque";
            // 
            // dgv_Estoque
            // 
            this.dgv_Estoque.AllowDrop = true;
            this.dgv_Estoque.AllowUserToAddRows = false;
            this.dgv_Estoque.AllowUserToDeleteRows = false;
            this.dgv_Estoque.AllowUserToOrderColumns = true;
            this.dgv_Estoque.AllowUserToResizeColumns = false;
            this.dgv_Estoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgv_Estoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Estoque.Location = new System.Drawing.Point(6, 22);
            this.dgv_Estoque.MultiSelect = false;
            this.dgv_Estoque.Name = "dgv_Estoque";
            this.dgv_Estoque.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Estoque.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Estoque.Size = new System.Drawing.Size(428, 231);
            this.dgv_Estoque.TabIndex = 1;
            this.dgv_Estoque.TabStop = false;
            this.dgv_Estoque.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Estoque_CellFormatting);
            // 
            // gpb_AlterarEstoque
            // 
            this.gpb_AlterarEstoque.BackColor = System.Drawing.Color.Transparent;
            this.gpb_AlterarEstoque.Controls.Add(this.lblParametroOperacao);
            this.gpb_AlterarEstoque.Controls.Add(this.rdb_SemCodigoDeBarra);
            this.gpb_AlterarEstoque.Controls.Add(this.gpb_Operacao);
            this.gpb_AlterarEstoque.Controls.Add(this.rdb_ComCodigoDeBarra);
            this.gpb_AlterarEstoque.Location = new System.Drawing.Point(10, 3);
            this.gpb_AlterarEstoque.Name = "gpb_AlterarEstoque";
            this.gpb_AlterarEstoque.Size = new System.Drawing.Size(331, 259);
            this.gpb_AlterarEstoque.TabIndex = 0;
            this.gpb_AlterarEstoque.TabStop = false;
            this.gpb_AlterarEstoque.Text = "Alterar Estoque";
            // 
            // lblParametroOperacao
            // 
            this.lblParametroOperacao.AutoSize = true;
            this.lblParametroOperacao.Location = new System.Drawing.Point(6, 16);
            this.lblParametroOperacao.Name = "lblParametroOperacao";
            this.lblParametroOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblParametroOperacao.TabIndex = 6;
            this.lblParametroOperacao.Visible = false;
            // 
            // rdb_SemCodigoDeBarra
            // 
            this.rdb_SemCodigoDeBarra.Location = new System.Drawing.Point(11, 34);
            this.rdb_SemCodigoDeBarra.Name = "rdb_SemCodigoDeBarra";
            this.rdb_SemCodigoDeBarra.Size = new System.Drawing.Size(156, 20);
            this.rdb_SemCodigoDeBarra.TabIndex = 4;
            this.rdb_SemCodigoDeBarra.TabStop = false;
            this.rdb_SemCodigoDeBarra.Values.Image = ((System.Drawing.Image)(resources.GetObject("rdb_SemCodigoDeBarra.Values.Image")));
            this.rdb_SemCodigoDeBarra.Values.Text = "Sem Código De Barra";
            this.rdb_SemCodigoDeBarra.CheckedChanged += new System.EventHandler(this.rdb_SemCodigoDeBarra_CheckedChanged);
            // 
            // gpb_Operacao
            // 
            this.gpb_Operacao.Controls.Add(this.label4);
            this.gpb_Operacao.Controls.Add(this.pnlSomeAparece);
            this.gpb_Operacao.Controls.Add(this.label2);
            this.gpb_Operacao.Controls.Add(this.txt_Quantidade);
            this.gpb_Operacao.Controls.Add(this.btn_Retirar);
            this.gpb_Operacao.Controls.Add(this.btn_Incluir);
            this.gpb_Operacao.Location = new System.Drawing.Point(6, 52);
            this.gpb_Operacao.Name = "gpb_Operacao";
            this.gpb_Operacao.Size = new System.Drawing.Size(309, 198);
            this.gpb_Operacao.TabIndex = 0;
            this.gpb_Operacao.TabStop = false;
            this.gpb_Operacao.Text = "Operação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "*";
            // 
            // pnlSomeAparece
            // 
            this.pnlSomeAparece.Controls.Add(this.label3);
            this.pnlSomeAparece.Controls.Add(this.txt_CodigoDoProduto);
            this.pnlSomeAparece.Controls.Add(this.label1);
            this.pnlSomeAparece.Location = new System.Drawing.Point(7, 15);
            this.pnlSomeAparece.Name = "pnlSomeAparece";
            this.pnlSomeAparece.Size = new System.Drawing.Size(295, 58);
            this.pnlSomeAparece.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // txt_CodigoDoProduto
            // 
            this.txt_CodigoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoDoProduto.Location = new System.Drawing.Point(25, 14);
            this.txt_CodigoDoProduto.MaxLength = 15;
            this.txt_CodigoDoProduto.Name = "txt_CodigoDoProduto";
            this.txt_CodigoDoProduto.Size = new System.Drawing.Size(255, 38);
            this.txt_CodigoDoProduto.TabIndex = 1;
            this.txt_CodigoDoProduto.TextChanged += new System.EventHandler(this.txt_CodigoDoProduto_TextChanged);
            this.txt_CodigoDoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoDoProduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(34, 93);
            this.txt_Quantidade.MaxLength = 3;
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(73, 38);
            this.txt_Quantidade.TabIndex = 2;
            this.txt_Quantidade.TextChanged += new System.EventHandler(this.txt_Quantidade_TextChanged);
            this.txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantidade_KeyPress);
            // 
            // btn_Retirar
            // 
            this.btn_Retirar.Location = new System.Drawing.Point(32, 137);
            this.btn_Retirar.Name = "btn_Retirar";
            this.btn_Retirar.Size = new System.Drawing.Size(90, 49);
            this.btn_Retirar.TabIndex = 3;
            this.btn_Retirar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Retirar.Values.Image")));
            this.btn_Retirar.Values.Text = "Retirar";
            this.btn_Retirar.Click += new System.EventHandler(this.btn_Retirar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(197, 137);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(90, 49);
            this.btn_Incluir.TabIndex = 4;
            this.btn_Incluir.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Incluir.Values.Image")));
            this.btn_Incluir.Values.Text = "Incluir";
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // rdb_ComCodigoDeBarra
            // 
            this.rdb_ComCodigoDeBarra.Location = new System.Drawing.Point(168, 33);
            this.rdb_ComCodigoDeBarra.Name = "rdb_ComCodigoDeBarra";
            this.rdb_ComCodigoDeBarra.Size = new System.Drawing.Size(158, 20);
            this.rdb_ComCodigoDeBarra.TabIndex = 4;
            this.rdb_ComCodigoDeBarra.TabStop = false;
            this.rdb_ComCodigoDeBarra.Values.Image = ((System.Drawing.Image)(resources.GetObject("rdb_ComCodigoDeBarra.Values.Image")));
            this.rdb_ComCodigoDeBarra.Values.Text = "Com Código De Barra";
            this.rdb_ComCodigoDeBarra.CheckedChanged += new System.EventHandler(this.rdb_ComCodigoDeBarra_CheckedChanged);
            // 
            // frmAlterarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 371);
            this.Controls.Add(this.k_panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAlterarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Estoque";
            this.Load += new System.EventHandler(this.frmAlterarEstoque_Load);
            this.TextChanged += new System.EventHandler(this.frmAlterarEstoque_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho.Panel)).EndInit();
            this.k_panelCabecalho.Panel.ResumeLayout(false);
            this.k_panelCabecalho.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_panelCabecalho)).EndInit();
            this.k_panelCabecalho.ResumeLayout(false);
            this.gpb_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estoque)).EndInit();
            this.gpb_AlterarEstoque.ResumeLayout(false);
            this.gpb_AlterarEstoque.PerformLayout();
            this.gpb_Operacao.ResumeLayout(false);
            this.gpb_Operacao.PerformLayout();
            this.pnlSomeAparece.ResumeLayout(false);
            this.pnlSomeAparece.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup k_panelCabecalho;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Minimize;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btn_Sair;
        private System.Windows.Forms.GroupBox gpb_AlterarEstoque;
        private System.Windows.Forms.GroupBox gpb_Operacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_CodigoDoProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Retirar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Incluir;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdb_SemCodigoDeBarra;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdb_ComCodigoDeBarra;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ValorRetiradoDoEstoque;
        private System.Windows.Forms.Label lblParametroOperacao;
        private System.Windows.Forms.Panel pnlSomeAparece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_Estoque;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_Estoque;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}