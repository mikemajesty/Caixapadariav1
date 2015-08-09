namespace View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_Logar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Sair = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_NaoPossuoSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Trail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(379, 16);
            this.txt_Nome.MaxLength = 15;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(176, 38);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(379, 74);
            this.txt_Senha.MaxLength = 15;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(176, 38);
            this.txt_Senha.TabIndex = 2;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Red;
            this.lbl_Login.Location = new System.Drawing.Point(327, 26);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(49, 16);
            this.lbl_Login.TabIndex = 2;
            this.lbl_Login.Text = "Nome";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.Color.Red;
            this.lbl_Senha.Location = new System.Drawing.Point(324, 84);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(52, 16);
            this.lbl_Senha.TabIndex = 2;
            this.lbl_Senha.Text = "Senha";
            // 
            // btn_Logar
            // 
            this.btn_Logar.Location = new System.Drawing.Point(369, 118);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(90, 75);
            this.btn_Logar.TabIndex = 3;
            this.btn_Logar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logar.Values.Image")));
            this.btn_Logar.Values.Text = "Login";
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(465, 118);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(90, 75);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Values.Image")));
            this.btn_Sair.Values.Text = "Sair";
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // txt_NaoPossuoSenha
            // 
            this.txt_NaoPossuoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NaoPossuoSenha.Location = new System.Drawing.Point(379, 219);
            this.txt_NaoPossuoSenha.MaxLength = 15;
            this.txt_NaoPossuoSenha.Name = "txt_NaoPossuoSenha";
            this.txt_NaoPossuoSenha.PasswordChar = '*';
            this.txt_NaoPossuoSenha.Size = new System.Drawing.Size(176, 38);
            this.txt_NaoPossuoSenha.TabIndex = 5;
            this.txt_NaoPossuoSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NaoPossuoSenha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(376, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Não Possuo Senha";
            // 
            // lbl_Trail
            // 
            this.lbl_Trail.AutoSize = true;
            this.lbl_Trail.BackColor = System.Drawing.Color.Red;
            this.lbl_Trail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trail.Location = new System.Drawing.Point(14, 234);
            this.lbl_Trail.Name = "lbl_Trail";
            this.lbl_Trail.Size = new System.Drawing.Size(253, 20);
            this.lbl_Trail.TabIndex = 6;
            this.lbl_Trail.Text = "Dias Para Expirar O Programa:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 269);
            this.Controls.Add(this.lbl_Trail);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_NaoPossuoSenha);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Logar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Sair;
        private System.Windows.Forms.TextBox txt_NaoPossuoSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Trail;
    }
}