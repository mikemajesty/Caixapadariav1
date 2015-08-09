using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmChamaCadastroLogin : Form
    {
        public frmChamaCadastroLogin()
        {
            InitializeComponent();
        }
        LoginDAO loginDao = new LoginDAO();

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroLogin login = new frmCadastroLogin(UsuarioEnum.Novo, null);
                DialogResult dialogResult = login.ShowDialog();
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {

                    CarregaLogin();
                    limparTxt();
                    frmLogin LOG = new frmLogin();
                    LOG.Show();
                    this.Close();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Chamar O Formulario: " + Erro.Message, "Erro");
            }
            //else
            //{
            //    Message("Não Foi Possível Cadastrar Novo Úsuario, Da Proxima Vez Verifique Se Os Dados Estão Corretos","Aviso");
            //}
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CarregaLogin()
        {
            try
            {
                dgv_Usuario.DataSource = loginDao.SelectLogin();
                dgv_Usuario.ClearSelection();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações Do Úsuario: " + Erro.Message, "Avsio");
            }
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UsuarioSelecionado.Text.Length > 0)
                {
                    frmCadastroLogin login = new frmCadastroLogin(UsuarioEnum.Alterar, JogaOTxtParaObjeto());
                    DialogResult dialogResult = login.ShowDialog();
                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        CarregaLogin();
                        limparTxt();
                    }
                }
                else
                {
                    Message("Não Existe Úsuario Selcionado", "Avsio");
                    limparTxt();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Chamar O Formulario: " + Erro.Message, "Erro");
            }
            //else
            //{
            //    Message("Não Foi Possível Alterar O Úsuario, Da Proxima Vez Verifique Se Os Dados Estão Corretos", "Aviso");
            //}
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UsuarioSelecionado.Text.Length > 0)
                {
                    frmCadastroLogin login = new frmCadastroLogin(UsuarioEnum.Deletar, JogaOTxtParaObjeto());
                    DialogResult dialogResult = login.ShowDialog();
                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        CarregaLogin();
                        limparTxt();
                    }
                }
                else
                {
                    Message("Não Existe Úsuario Selcionado", "Avsio");
                    limparTxt();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Chamar O Formulario: " + Erro.Message, "Erro");
            }


            //else
            //{
            //    Message("Não Foi Possível Deletar O Úsuario, Da Proxima Vez Verifique Se Os Dados Estão Corretos", "Aviso");
            //}
        }

        private void limparTxt()
        {
            txt_UsuarioSelecionado.Text = string.Empty;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void frmChamaCadastroLogin_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaLogin();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar O Formulario: " + Erro.Message, "Erro");
            }

            // txt_UsuarioSelecionado.Text = RetornaNomeSelecionado();
        }
        private Login JogaOTxtParaObjeto()
        {
            try
            {
                string nomeSelecionado = RetornaNomeSelecionado();
                Login login = loginDao.SelectILinhaPorNome(nomeSelecionado);
                return login;
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Selecionar Os Dados Do Úsuario: " + Erro.Message, "Erro");
                return null;
            }
        }

        private string RetornaNomeSelecionado()
        {
            string nomeSelecionado = dgv_Usuario.CurrentRow.Cells[1].Value.ToString();
            return nomeSelecionado;
        }

        private void dgv_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_UsuarioSelecionado.Text = RetornaNomeSelecionado();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Encontrar Nome Selecionado: " + Erro.Message, "Erro");
            }

        }

        private void frmChamaCadastroLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin show = new frmLogin();
            show.Show();
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

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja Fechar Esse Formulario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                this.Close();
            }
        }
    }
}
