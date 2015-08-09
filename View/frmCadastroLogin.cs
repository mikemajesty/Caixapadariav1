using System;
using System.Windows.Forms;
using Model;
using Controller;
namespace View
{
    public partial class frmCadastroLogin : Form
    {
        UsuarioEnum ENUM;
        Login LOGIN;

        public frmCadastroLogin(UsuarioEnum Enum, Login Login)
        {
            if (Login != null)
            {
                LOGIN = Login;
            }

            ENUM = Enum;


            InitializeComponent();
        }
        LoginDAO loginDao = new LoginDAO();


        private void frmCadastroLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (ENUM.Equals(UsuarioEnum.Novo))
                {
                    CarregareComboBox();
                    FocoNoTxt();
                    CarregareComboBox();
                    MudarTextoDoButton("Salvar");
                }
                else if (ENUM.Equals(UsuarioEnum.Deletar))
                {
                    CarregareComboBox();
                    MudarTextoDoButton("Deletar");
                    FocoNoTxt();
                    JogaParaOTxt();
                    DeabilitaCampos();
                    MostrarSenha();
                }
                else if (ENUM.Equals(UsuarioEnum.Alterar))
                {
                    CarregareComboBox();
                    MudarTextoDoButton("Alterar");
                    FocoNoTxt();
                    JogaParaOTxt();
                    MostrarSenha();
                }

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Os Dados: " + Erro.Message, "Erro");
            }
        }

        private void MostrarSenha()
        {
            txt_Senha.PasswordChar = '\0';
            txt_ConfirmaSenha.PasswordChar = '\0';
        }

        private void DeabilitaCampos()
        {
            txt_ConfirmaSenha.Enabled = false;
            txt_Nome.Enabled = false;
            txt_Senha.Enabled = false;
            cbb_Permicao.Enabled = false;
        }

        private void JogaParaOTxt()
        {
            txt_Nome.Text = LOGIN.Nome;
            txt_Senha.Text = LOGIN.Senha;
            txt_ConfirmaSenha.Text = LOGIN.Senha;
            cbb_Permicao.Text = LOGIN.Permissao;
        }

        private void MudarTextoDoButton(string Texto)
        {
            btn_Cancelar.Text = Texto;
        }

        private void CarregareComboBox()
        {
            cbb_Permicao.DisplayMember = "Permissao";
            cbb_Permicao.DataSource = CarregaTipoPermicao.SelectTipoPermicao();
        }

        private void FocoNoTxt()
        {
            this.ActiveControl = txt_Nome;
        }

        //private void CarregarLogin()
        //{
        //    //dgv_Usuario.DataSource = loginDao.SelectLogin();
        //}
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            if (txt_Nome.Text.Length > 0 && txt_Senha.Text.Length > 0)
            {


                try
                {
                    Login login = new Login
                    {
                        Nome = txt_Nome.Text,
                        Senha = txt_Senha.Text,
                        Permissao = cbb_Permicao.Text.ToUpper()
                    };
                    if (login.Senha.Equals(txt_ConfirmaSenha.Text))
                    {


                        if (loginDao.InsertLogin(login))
                        {
                            Message("Login Cadastrado Com Sucesso!", "Aviso");
                            frmLogin chamaLogin = new frmLogin();
                            chamaLogin.Show();
                            this.Hide();
                        }
                        else
                        {
                            Message("Não Foi Possível Cadastrar O Login, Dados Incorretos Ou Login Já Existente", "");
                        }
                    }
                    else
                    {
                        Message("Senhas Incorretas", "Aviso");
                        LimparTxtSenhas();

                    }
                }
                catch (Exception Erro)
                {
                    Message("Erro Ao Cadastrar O Login: " + Erro.Message, "Erro");
                    LimparTxtSenhas();
                }
            }
            else
            {
                Message("Existem Campos Em Branco, Para Cadastrar Um Úsuario è Necessario Preencher Todos Os Campos", "Aviso");
            }
        }

        private void LimparTxtSenhas()
        {
            txt_Senha.Text = string.Empty;
            txt_ConfirmaSenha.Text = string.Empty;
        }

      
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            frmLogin chamaLogin = new frmLogin();
            chamaLogin.Show();
            this.Hide();

        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ENUM.Equals(UsuarioEnum.Novo))
                {
                    if (txt_Senha.Text.Equals(txt_ConfirmaSenha.Text) && txt_Nome.Text.Length > 0
                        && txt_Senha.Text.Length > 0 && txt_ConfirmaSenha.Text.Length > 0)
                    {
                        if (loginDao.InsertLogin(JogaTxtParaObjeto()))
                        {
                            Message("Úsuario Inserido Com Sucesso", "Aviso");
                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        }
                        else
                        {
                            Message("Não Foi Possível Salvar Um Novo Úsuario, Verifique E Insira Os Dados Corretamente", "Aviso");
                            //this.DialogResult = System.Windows.Forms.DialogResult.No;
                            FocoNoTxt();
                            LimparTxtSenhas();
                        }
                    }
                    else
                    {
                        Message("Existem Campos Incorretos Ou A Senha É Diferente Do Confirmar Senha","Aviso");
                        FocoNoTxt();
                        LimparTxtSenhas();
                    }
                   
                }
                else if (ENUM.Equals(UsuarioEnum.Deletar))
                {

                    if (loginDao.DeleteLogin(LOGIN.Id))
                    
                    {
                        Message("Úsuario Excluido Com Sucesso", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {
                        Message("Não Foi Possível Excluir O Úsuario, Verifique E Insira Os Dados Corretamente", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                }
                else if (ENUM.Equals(UsuarioEnum.Alterar))
                {
                    if (loginDao.UpdateUsuario(JogaTxtParaObjeto()))
                    {
                        Message("Úsuario Alterado Com Sucesso", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {
                       
                        Message("Não Foi Possível Alterar O Úsuario, Verifique E Insira Os Dados Corretamente", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Fazer As Alterações Na Tabela De Produto: " + Erro.Message, "Erro");
            }
        }
        public Login JogaTxtParaObjeto()
        {
            try
            {
                Login login = new Login();
                if (LOGIN != null)
                {
                    login.Id = LOGIN.Id;
                }
                login.Nome = txt_Nome.Text;
                login.Senha = txt_Senha.Text;
                login.Permissao = cbb_Permicao.Text;

                return login;

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Atribuir Valores Para Os Campos: "+Erro.Message,"Erro");
                LimparTxtSenhas();
                txt_Nome.Text = string.Empty;
                return null;
            }
        }

        private void cbb_Permicao_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                string admin, caixa, restrito, intermediario;
                admin = "Acesso Total Ao Sistema "/* + Environment.NewLine + ",Cadastro, Pesquisa, Estoque," + Environment.NewLine + "Caixa, Venda E Consultar Lucro"*/;
                caixa = "Acesso A Venda" + Environment.NewLine + ", Pesquisa De Produtos Limitado E Cadastro De Comanda E Cliente VIP";
                restrito = "Acesso Somente A Pesquisa De Produto Limitado";
                intermediario = "Acesso Pesquisa Total, Venda" + Environment.NewLine + "Consulta De Lucro E Produtos" + Environment.NewLine + " Altera Estoque E Cadastro De Comanda E Cliente VIP";

                if (cbb_Permicao.Text.Equals("Admin"))
                {
                    ltb_Detales.Text = admin;
                }
                else if (cbb_Permicao.Text.Equals("Caixa"))
                {
                    ltb_Detales.Text = caixa;
                }
                else if (cbb_Permicao.Text.Equals("Restrito"))
                {
                    ltb_Detales.Text = restrito;
                }
                else if (cbb_Permicao.Text.Equals("Intermediario"))
                {
                    ltb_Detales.Text = intermediario;
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Permissões: " + Erro.Message, "Aviso");
            }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Minimizar O Formulario: " + Erro, "Erro");
            }
        }

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja Fechar Esse Formulario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                this.Close();
            }
        }
        //private void dgv_Usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    linhaIdSelecionada = 0;

        //    try
        //    {
        //        lbl_UsuarioSelecionado.Text = "Úsuario Selecionado: ";
        //        linhaIdSelecionada = Convert.ToInt32(dgv_Usuario.CurrentRow.Cells[0].Value);
        //        linhaNomeSelecionado = dgv_Usuario.CurrentRow.Cells[1].Value.ToString();
        //        lbl_UsuarioSelecionado.Text += linhaNomeSelecionado;
        //    }
        //    catch (Exception Erro)
        //    {
        //        Message("Erro Ao Selecionar Dados De Uma Linha: " + Erro.Message, "Erro");
        //    }
        //}

        //private void btn_Deletar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult dialog = MessageBox.Show("Deseja Excluir Esse Úsuario: "+linhaNomeSelecionado+"?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        //        if (dialog == DialogResult.Yes)
        //        {
        //            if (loginDao.DeleteLogin(linhaIdSelecionada))
        //            {
        //                Message("Login Deletado Com Sucesso", "Aviso");
        //                CarregarLogin();
        //            }
        //            else
        //            {
        //                Message("Não Foi Possível Deletar O Login", "Aviso");
        //            }
        //        }

        //    }
        //    catch (Exception Erro)
        //    {

        //        Message("Erro Ao Excluir O Úsuario: " + Erro.Message, "Aviso");
        //    }
        //}

        //private void btn_Alterar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        DialogResult dialog = MessageBox.Show("Deseja Alterar Esse Úsuario: "+linhaNomeSelecionado+"?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
