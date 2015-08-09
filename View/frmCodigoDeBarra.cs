using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmCodigoDeBarra : Form
    {
        ComandaEnum ENUM;
        Comanda COMANDA;
        public frmCodigoDeBarra(ComandaEnum Enum, Comanda Comanda)
        {
            if (Comanda != null)
            {
                COMANDA = Comanda;
            }
            ENUM = Enum;
            InitializeComponent();
        }
        ComandaDAO comandaDAO = new ComandaDAO();

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ENUM.Equals(ComandaEnum.Novo))
                {
                    //if (txt_CodigoComanda.Text.Length > 0)
                    //{
                    Comanda comanda = new Comanda
                    {
                        Codigo = txt_CodigoComanda.Text
                    };

                    if (comanda.Codigo.Length > 0)
                    {
                        if (comandaDAO.InsertComanda(comanda))
                        {
                            Message("Comanda Inserida Com Sucesso", "Aviso");
                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        }
                        else
                        {
                            Message("Não Foi Possível Inserir Uma Nova Comanda, Verifique Se Os Dados São Validos", "Aviso");
                            LimpaTxt();
                        }
                    }
                    //}
                    else
                    {
                        Message("Todos Os Campos Devem Ser Preenchidos", "Aviso");
                        focoNoTxt();
                    }

                }
                else if (ENUM.Equals(ComandaEnum.Alterar))
                {
                    // SetaValoresNoTxt();
                    COMANDA.Codigo = txt_CodigoComanda.Text;
                    if (comandaDAO.UpdateComanda(COMANDA))
                    {
                        Message("Comanda Alterada Com Sucesso", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {
                        Message("Não Foi Possível Alterar Uma Comanda, Verifique Se Os Dados São Validos", "Aviso");

                    }

                }
                else if (ENUM.Equals(ComandaEnum.Deletar))
                {

                    if (comandaDAO.DeleteComanda(COMANDA))
                    {
                        Message("Comanda Deletar Com Sucesso", "Aviso");
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    else
                    {
                        Message("Não Foi Possível Deletar Uma Nova Comanda, Verifique Se Os Dados São Validos", "Aviso");
                        //LimpaTxt();
                    }
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }
        }

        private void focoNoTxt()
        {
            this.ActiveControl = txt_CodigoComanda;
        }

        private void LimpaTxt()
        {
            txt_CodigoComanda.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCodigoDeBarra_Load(object sender, EventArgs e)
        {
            try
            {
                if (ENUM.Equals(ComandaEnum.Novo))
                {
                    this.Text = "Cadastrar Comanda";
                    btn_Confirmar.Text = "Salvar";
                }
                else if (ENUM.Equals(ComandaEnum.Alterar))
                {
                    this.Text = "Alterar Comanda";
                    btn_Confirmar.Text = "Alterar";
                    SetaValoresNoTxt();
                }
                else if (ENUM.Equals(ComandaEnum.Deletar))
                {
                    this.Text = "Alterar Comanda";
                    btn_Confirmar.Text = "Deletar";
                    txt_CodigoComanda.Enabled = false;
                    SetaValoresNoTxt();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações: " + Erro.Message, "Erro");
            }

        }

        private void SetaValoresNoTxt()
        {
            txt_CodigoComanda.Text = COMANDA.Codigo;
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
