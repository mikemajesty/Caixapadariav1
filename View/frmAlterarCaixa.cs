using Controller;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmAlterarCaixa : Form
    {
        public frmAlterarCaixa()
        {
            InitializeComponent();
        }
        VendaDAO vendaDao = new VendaDAO();

        private void frmAlterarCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txt_InserirCaixa;

                if (vendaDao.SelectValorCaixa().Rows.Count > 0)
                {
                    lbl_ValorCaixa.Values.ExtraText = CarregarCaixa();
                }
                else
                {
                    lbl_ValorCaixa.Values.ExtraText = "00.00";
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar O Valor Do Caixa: " + Erro.Message, "Erro");
            }

        }

        private string CarregarCaixa()
        {
            try
            {
                decimal valor = Convert.ToDecimal(vendaDao.SelectValorCaixa().Rows[0]["Valor"]);
                return valor.ToString("C");

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar O Valor Do Caixa: " + Erro.Message, "Erro");
                return "00.00";
            }
        }

        private void btn_Saia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RetiraCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txt_InserirCaixa;
                if (txt_InserirCaixa.Text.Length > 0)
                {
                    if (Convert.ToDouble(txt_InserirCaixa.Text) < Convert.ToDouble(lbl_ValorCaixa.Values.ExtraText.Substring
                        (2, lbl_ValorCaixa.Values.ExtraText.Length - 2)))
                    {


                        decimal valor = Convert.ToDecimal(txt_InserirCaixa.Text);

                        if (vendaDao.UpdateValorCaixa(valor, "-", 1))
                        {
                            Message("Caixa Alterado Com Sucesso", "Aviso");
                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        }
                        else
                        {
                            Message("Não Foi Possível Alterar O Caixa, Verifique Os Dados", "Aviso");
                            //this.DialogResult = System.Windows.Forms.DialogResult.No;
                        }
                    }
                    else
                    {
                        Message("Você Não Pode Zerar O Caixa Ou Retirar Um Valor Maior Do Que Há No Caixa", "Aviso");
                    }
                }
                else
                {
                    Message("É Necessario Inserir Um Valor No Caixa","Aviso");
                    this.ActiveControl = txt_InserirCaixa;
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Alterar O Estoque: " + Erro, "Erro");
            }
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_IncluirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = Convert.ToDecimal(txt_InserirCaixa.Text);
                this.ActiveControl = txt_InserirCaixa;

                if (vendaDao.UpdateValorCaixa(valor, "+", 1))
                {
                    Message("Caixa Alterado Com Sucesso", "Aviso");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                else
                {
                    Message("Não Foi Possível Alterar O Caixa, Verifique Os Dados", "Aviso");
                    //        this.DialogResult = System.Windows.Forms.DialogResult.No;
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Alterar O Estoque: " + Erro, "Erro");
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

        private void txt_InserirCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
