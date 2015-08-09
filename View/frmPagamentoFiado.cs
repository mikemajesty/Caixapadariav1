using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmPagamentoFiado : Form
    {
        public frmPagamentoFiado()
        {
            InitializeComponent();//int fiado
        }
        ClienteDAO clienteDao = new ClienteDAO();
        public static string Cpf;
        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_NomeCliente.Text != string.Empty)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Selecionar As Informações Do Cliente: " + Erro.Message, "Erro");
            }
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmPagamentoFiado_Load(object sender, EventArgs e)
        {
            try
            {
                if(clienteDao.SelectName().Rows.Count <=0)
                {
                    Message("Não Existem Clientes VIPS Cadastrados, Antes De Vender Fiado É Necessario Cadastrar Um Cliente","Aviso");
                    this.Close();
                }
                cbb_NomeCliente.DisplayMember = "Nome";
                cbb_NomeCliente.DataSource = clienteDao.SelectName();

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Informações Do Formulario: "+Erro.Message, "Erro");
            }
        }

        private void cbb_NomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Cpf = mtb_Cpf.Text;
               // Fiado.IdCliente = clienteDao.SelectIdPorCpf(Cpf);
                Fiado.IdCliente = clienteDao.SelectIdPorNome(cbb_NomeCliente.Text);
                int iD = Fiado.IdCliente;
                mtb_Cpf.Text = clienteDao.SelectCpfPorId(iD);
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Selecionar As Informações Do Cliente: " + Erro.Message, "Erro");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
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
