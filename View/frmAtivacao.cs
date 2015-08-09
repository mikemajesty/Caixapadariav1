using System;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class frmAtivacao : Form
    {
        public frmAtivacao()
        {
            InitializeComponent();
        }

        private void btn_Ativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Validacao.Text.Length > 0)
                {
                    decimal resultado = ((Convert.ToDecimal(lbl_Numero.Text) * Convert.ToDecimal(3.5)) + 666) / 5;
                    if (resultado.ToString() == txt_Validacao.Text)
                    {
                        KeyGenDAO keigen = new KeyGenDAO();
                        keigen.DeleteDatas();
                        frmLogin login = new frmLogin();
                        //this.Hide();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta");
                        LimparTxt();
                    }
                }
            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void LimparTxt()
        {
            txt_Validacao.Text = string.Empty;
        }

        private void frmAtivacao_Load(object sender, EventArgs e)
        {
            try
            {
                Random ramdom = new Random();
                lbl_Numero.Text = ramdom.Next(100000000, 900000000).ToString(); ;

            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }
    }
}
