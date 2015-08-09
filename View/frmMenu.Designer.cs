namespace View
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Calculadora = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn_BlocoDeNotas = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.k_Menu = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnCadastroCliente = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_ChamaCadastroComanda = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Estoque = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_CadastroCategoria = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_PesquisarProdutos = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Cadastro = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Venda = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Caixa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnCalculador = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.rodape = new System.Windows.Forms.StatusStrip();
            this.lbl_Relogio = new System.Windows.Forms.ToolStripStatusLabel();
            this.NomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.rodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Calculadora
            // 
            this.btn_Calculadora.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btn_Calculadora.ImageLarge")));
            this.btn_Calculadora.TextLine1 = "Calculadora";
            // 
            // btn_BlocoDeNotas
            // 
            this.btn_BlocoDeNotas.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btn_BlocoDeNotas.ImageLarge")));
            this.btn_BlocoDeNotas.TextLine1 = "Bloco De Notas";
            // 
            // k_Menu
            // 
            this.k_Menu.AutoSize = false;
            this.k_Menu.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCadastroCliente,
            this.btn_ChamaCadastroComanda,
            this.btn_Estoque,
            this.btn_CadastroCategoria,
            this.btn_PesquisarProdutos,
            this.btn_Cadastro,
            this.btn_Venda,
            this.btn_Caixa,
            this.btnCalculador,
            this.btn_Login});
            this.k_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.k_Menu.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.k_Menu.Location = new System.Drawing.Point(0, 0);
            this.k_Menu.Name = "k_Menu";
            this.k_Menu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.k_Menu.Size = new System.Drawing.Size(1305, 42);
            this.k_Menu.StateCommon.ButtonEdgeInset = 1;
            this.k_Menu.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.k_Menu.TabIndex = 3;
            this.k_Menu.Values.Description = "";
            this.k_Menu.Values.Heading = "Caixa";
            this.k_Menu.Values.Image = ((System.Drawing.Image)(resources.GetObject("k_Menu.Values.Image")));
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.ExtraText = "Cliente VIP";
            this.btnCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroCliente.Image")));
            this.btnCadastroCliente.UniqueName = "728B96F0B5CA45D89DA02D26EE86DC13";
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btn_ChamaCadastroComanda
            // 
            this.btn_ChamaCadastroComanda.ExtraText = "Comanda";
            this.btn_ChamaCadastroComanda.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChamaCadastroComanda.Image")));
            this.btn_ChamaCadastroComanda.UniqueName = "307D960BA5BF49EA72B83BE948FBC0F8";
            this.btn_ChamaCadastroComanda.Click += new System.EventHandler(this.btn_ChamaCadastroComanda_Click);
            // 
            // btn_Estoque
            // 
            this.btn_Estoque.ExtraText = "Estoque";
            this.btn_Estoque.Image = ((System.Drawing.Image)(resources.GetObject("btn_Estoque.Image")));
            this.btn_Estoque.UniqueName = "5022A191AA8C4777CB802425E531BCEF";
            this.btn_Estoque.Click += new System.EventHandler(this.btn_Estoque_Click);
            // 
            // btn_CadastroCategoria
            // 
            this.btn_CadastroCategoria.ExtraText = "Categoria";
            this.btn_CadastroCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_CadastroCategoria.Image")));
            this.btn_CadastroCategoria.UniqueName = "D72CACF40C6548B31A9D7271F192A0C6";
            this.btn_CadastroCategoria.Click += new System.EventHandler(this.btn_CadastroCategoria_Click);
            // 
            // btn_PesquisarProdutos
            // 
            this.btn_PesquisarProdutos.ExtraText = "Produto";
            this.btn_PesquisarProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btn_PesquisarProdutos.Image")));
            this.btn_PesquisarProdutos.UniqueName = "B53D0ADDA01D447C76A423BEC3E2332B";
            this.btn_PesquisarProdutos.Click += new System.EventHandler(this.btn_PesquisarProdutos_Click);
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.ExtraText = "Produto";
            this.btn_Cadastro.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadastro.Image")));
            this.btn_Cadastro.UniqueName = "205CFED4D0B7436C5D954A222C9AA34E";
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // btn_Venda
            // 
            this.btn_Venda.ExtraText = "Venda";
            this.btn_Venda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Venda.Image")));
            this.btn_Venda.UniqueName = "83F4CEBDDD98455B55A0346B1455A8A9";
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // btn_Caixa
            // 
            this.btn_Caixa.ExtraText = "Caixa";
            this.btn_Caixa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Caixa.Image")));
            this.btn_Caixa.UniqueName = "537D51B4DA744ADAD3BDE49D5A9ECCBA";
            this.btn_Caixa.Click += new System.EventHandler(this.btn_Caixa_Click);
            // 
            // btnCalculador
            // 
            this.btnCalculador.ExtraText = "Calculadora";
            this.btnCalculador.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculador.Image")));
            this.btnCalculador.ToolTipTitle = "Calculadora";
            this.btnCalculador.UniqueName = "2D6E97AC686C4A7F65B09D3D064B0E6E";
            this.btnCalculador.Click += new System.EventHandler(this.btnCalculador_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.ExtraText = "Login";
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.UniqueName = "8C4D3E3695A44CE66BBDA8697CD534D7";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // rodape
            // 
            this.rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Relogio,
            this.NomeUsuario});
            this.rodape.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.rodape.Location = new System.Drawing.Point(0, 282);
            this.rodape.Name = "rodape";
            this.rodape.Size = new System.Drawing.Size(1305, 20);
            this.rodape.TabIndex = 5;
            // 
            // lbl_Relogio
            // 
            this.lbl_Relogio.Name = "lbl_Relogio";
            this.lbl_Relogio.Size = new System.Drawing.Size(0, 0);
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(53, 15);
            this.NomeUsuario.Text = "Úsuario: ";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 302);
            this.Controls.Add(this.rodape);
            this.Controls.Add(this.k_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MJ - Desenvolvimento De Sistemas";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.rodape.ResumeLayout(false);
            this.rodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn_Calculadora;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn_BlocoDeNotas;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader k_Menu;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnCalculador;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Caixa;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Venda;
        private System.Windows.Forms.StatusStrip rodape;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Relogio;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Cadastro;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_PesquisarProdutos;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_CadastroCategoria;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Estoque;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_Login;
        private System.Windows.Forms.ToolStripStatusLabel NomeUsuario;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btn_ChamaCadastroComanda;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnCadastroCliente;
    }
}