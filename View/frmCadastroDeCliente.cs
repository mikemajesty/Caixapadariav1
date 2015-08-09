using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadastroDeCliente : Form
    {
        Cliente CLI = new Cliente();
        ClienteEnum ENUM;

        public frmCadastroDeCliente(Cliente prod, ClienteEnum cliEnum)
        {
            if (prod != null)
            {
                CLI = prod;
            }
            ENUM = cliEnum;

            InitializeComponent();
        }
        ClienteDAO clienteDao = new ClienteDAO();

        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GetValueTxtForObject()
        {
            try
            {
                CLI.Nome = txt_Nome.Text;
                CLI.CPF = mtb_Cpf.Text;
                CLI.Celular = mtb_Celular.Text;
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações Do Cliente: " + Erro.Message, "Erro");

            }
        }
        public Cliente ReturnValueCliente()
        {
            try
            {
                txt_Nome.Text = CLI.Nome;
                mtb_Celular.Text = CLI.Celular;
                mtb_Cpf.Text = CLI.CPF;
                return CLI;
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações Do Cliente: " + Erro.Message, "Erro");
                return null;
            }
        }
        private void frmCadastroDeCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (ENUM == ClienteEnum.Novo)
                {
                    this.Text = "Novo Cliente";
                    btn_k_Confirmar.Text = "Salvar";

                }
                else if (ENUM == ClienteEnum.Alterar)
                {
                    this.Text = "Alterar Cliente";
                    btn_k_Confirmar.Text = "Alterar";
                    ReturnValueCliente();
                }
                else if (ENUM == ClienteEnum.Deletar)
                {
                    DisableTxt();
                    ReturnValueCliente();
                    btn_k_Confirmar.Text = "Deletar";
                    this.Text = "Deletar Cliente";
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações Do Cliente: " + Erro.Message, "Erro");
            }
        }

        private void DisableTxt()
        {
            txt_Nome.Enabled = false;
            mtb_Celular.Enabled = false;
            mtb_Cpf.Enabled = false;
        }
        private void btn_k_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ENUM == ClienteEnum.Novo)
                {
                    if (txt_Nome.Text.Length >= 3 && mtb_Celular.Text.Length >= 8 && mtb_Cpf.Text.Length >= 8)
                    {
                        GetValueTxtForObject();
                        if (clienteDao.InsertCliente(CLI))
                        {
                            Message("Cliente Inserido Com Sucesso", "Aviso");
                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        }
                        else
                        {
                            Message("Não Foi Possível Inserir O Cliente", "Aviso");
                            this.DialogResult = System.Windows.Forms.DialogResult.No;
                        }

                    }
                    else
                    {
                        Message("Todos Os Campos Devem Ser Preenchidos Corretamente", "Aviso");
                        FocoNotxt();
                    }
                }
                else if (ENUM == ClienteEnum.Alterar)
                {
                    GetValueTxtForObject();
                    if (clienteDao.UpdateCliente(CLI))
                    {
                        Message("Cliente Alterado Com Sucesso", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {
                        Message("Não Foi Possível Alterar O Cliente", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                }
                else if (ENUM == ClienteEnum.Deletar)
                {
                    if (clienteDao.DeleteCliente(CLI))
                    {
                        Message("Cliente Excluido Com Sucesso", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {
                        Message("Não Foi Possível Alterar O Cliente", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Confirmar A Operação: " + Erro.Message, "Erro");
                FocoNotxt();
                LimparTxt();
            }
        }

        private void FocoNotxt()
        {
            this.ActiveControl = txt_Nome;
        }

        private void LimparTxt()
        {
            txt_Nome.Text = string.Empty;
            mtb_Cpf.Text = string.Empty;
            mtb_Celular.Text = string.Empty;
        }

        private void btn_k_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Cancelar A Operação: " + Erro.Message, "Erro");
            }
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
