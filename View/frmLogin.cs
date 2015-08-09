using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();


        }
        LoginDAO loginDao = new LoginDAO();

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            try
            {
                
                KeyGenDAO keygenDao = new KeyGenDAO();
                keygenDao.InsertData();

                if (keygenDao.selectQuantidadeData() >= 30)
                {
                    frmAtivacao fom = new frmAtivacao();
                    fom.Show();
                    this.Hide();
                }
                else
                {
    

                    Login login = new Login
                    {
                        Nome = txt_Nome.Text,
                        Senha = txt_Senha.Text
                    };

                    if (loginDao.SelectLogin(login))
                    {

                        string NomeComSubstring = txt_Nome.Text.ToUpper();
                        NomeLoginGlobal.Nome = NomeComSubstring;
                        NomeLoginGlobal.Permicao = loginDao.SelectPermissaoPorUsuario(NomeComSubstring).Rows[0]["Permicao"].ToString().ToUpper();
                        frmMenu chamaMenu = new frmMenu();
                        chamaMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        Message("Login Enexistente, Crie Um Login E Tente Novamente", "Aviso");
                        FocoNoLogin();
                        LimparTxt();
                    }
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Tentar Acessar O Menu: " + Erro.Message, "Erro");
                LimparTxt();
                FocoNoLogin();
            }
        }

        private void focoNoSenhaAdministrador()
        {
            this.ActiveControl = txt_NaoPossuoSenha;
        }

        private void FocoNoLogin()
        {
            this.ActiveControl = txt_Nome;
        }

        private void LimparTxt()
        {
            txt_Nome.Text = string.Empty;
            txt_Senha.Text = string.Empty;
            txt_NaoPossuoSenha.Text = string.Empty;
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Tentar Acessar O Menu: " + Erro.Message, "Erro");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                KeyGenDAO keygenDao = new KeyGenDAO();

                //keygenDao.InsertData();
                // this.Close();
                this.ActiveControl = txt_Nome;

                //this.Close();
                //this.ActiveControl = txt_Nome;
                string trial = keygenDao.SelectDiasTrail();
                if (Convert.ToInt32(trial) <= 0)
                {
                    lbl_Trail.Text = "A Lincença Expirou, contate O Responsavel";
                }
                else
                {
                    lbl_Trail.Text += "  [" + trial + "]";
                }




            }
            catch (Exception Erro)
            {

                Message("Erro Ao Tentar Carregar As Informações: " + Erro.Message, "Erro");
            }

        }

        private void txt_NaoPossuoSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txt_NaoPossuoSenha.Text.Equals("administrador"))
                {
                    frmChamaCadastroLogin chamaCadastroLogin = new frmChamaCadastroLogin();
                    this.Hide();
                    chamaCadastroLogin.Show();

                }
                else
                {
                    Message("Senha De Administrador Incorreto, Insira A Senha Novamente", "Aviso");
                    LimparTxt();
                }
            }
        }
    }
}
