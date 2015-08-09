using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmFiado : Form
    {
        EnumModificaFiado ENUM;
        public frmFiado(EnumModificaFiado Enum)
        {
            InitializeComponent();
            ENUM = Enum;
        }

        private static int IdSelected = 0;
        ClienteDAO clientedAO = new ClienteDAO();
        FiadoDAO fiadoDao = new FiadoDAO();

        private void frmFiado_Load(object sender, EventArgs e)
        {

            if (ENUM == EnumModificaFiado.Pagamento)
            {
                btn_Novo.Visible = false;
                btn_deletar.Visible = false;
                btn_Alterar.Visible = false;
                //this.Size = new Size(656, 500);
                gpb_Pagamento.Visible = true;
                LoadDataClienteWithValue();
                dgv_cliente.ClearSelection();
                this.Text = "Pagamento De Contas Em Aberto";
            }
            else if (ENUM == EnumModificaFiado.Consulta)
            {
                //this.Size = new Size(450,500);             
                gpb_Pagamento.Visible = false;
                LoadDataClienteNotValue();
            }
        }

        private void LoadDataClienteWithValue()
        {
            try
            {
                if (clientedAO.selectClienteComValor() != null)
                {
                    dgv_cliente.DataSource = clientedAO.selectClienteComValor();

                }

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Informoções Do Cliente No Formulario: " + Erro.Message, "Erro");
            }
        }
        private void LoadDataClienteNotValue()
        {
            try
            {
                if (clientedAO.selectClienteComValor() != null)
                {
                    dgv_cliente.DataSource = clientedAO.selectClienteSemValor();

                }

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Informoções Do Cliente No Formulario: " + Erro.Message, "Erro");
            }
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroDeCliente show = new frmCadastroDeCliente(null, ClienteEnum.Novo);
                DialogResult dialog = show.ShowDialog();
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    LoadDataClienteNotValue();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Salvar Cliente: " + Erro.Message, "Erro");
            }
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //private Cliente ReturnValueCliente(Cliente Cliente)
        //{
        //    try
        //    {


        //    }
        //    catch (Exception Erro)
        //    {
        //        Message("Erro Ao Obter Informoções Do Cliente: " + Erro.Message, "Erro");
        //        return null;
        //    }
        //}
        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_clienteSelecionado.Text.Length > 0)
                {
                    frmCadastroDeCliente show = new frmCadastroDeCliente(clientedAO.SelectForId(IdSelected), ClienteEnum.Alterar);
                    DialogResult dialog = show.ShowDialog();
                    if (dialog == System.Windows.Forms.DialogResult.Yes)
                    {
                        LoadDataClienteNotValue();
                    }
                }
                else
                {
                    Message("Para Alterar Um Cliente É Necessario Selecionar O Mesmo", "Aviso");
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Alterar Cliente: " + Erro.Message, "Erro");
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_clienteSelecionado.Text.Length > 0)
                {
                    frmCadastroDeCliente show = new frmCadastroDeCliente(clientedAO.SelectForId(IdSelected), ClienteEnum.Deletar);
                    DialogResult dialog = show.ShowDialog();
                    if (dialog == System.Windows.Forms.DialogResult.Yes)
                    {
                        LoadDataClienteNotValue();
                    }
                }
                else
                {
                    Message("Para Deletar Um Cliente É Necessario Selecionar O Mesmo", "Aviso");
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Deletar Cliente: " + Erro.Message, "Erro");
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
        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_cliente.Rows.Count > 0)
                {


                    IdSelected = Convert.ToInt32(dgv_cliente.CurrentRow.Cells[0].Value);
                    txt_clienteSelecionado.Text = dgv_cliente.CurrentRow.Cells[1].Value.ToString();

                    if (ENUM == EnumModificaFiado.Pagamento)
                    {
                        //this.Size = new Size(656,500);
                        txt_TotalDivida.Text = dgv_cliente.CurrentRow.Cells[4].Value.ToString();
                    }
                    else if (ENUM == EnumModificaFiado.Consulta)
                    {
                        //this.Size = new Size(656, 400);
                    }
                }

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Selecioanr O Id Do Cliente: " + Erro.Message, "Erro");
            }
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            try
            {

                double totalDivida = Convert.ToDouble(txt_TotalDivida.Text), totalPago = Convert.ToDouble(txt_ValorPago.Text);
                if (txt_TotalDivida.Text.Length > 0 && txt_ValorPago.Text.Length > 0)
                {
                    if (totalPago > totalDivida)
                    {
                        Message("É Necessario Iserir Um Valor Menor Ou Igual A Divida", "Aviso");
                        txt_ValorPago.Text = string.Empty;
                    }
                    else
                    {
                        if (fiadoDao.alterarFiado(IdSelected, Convert.ToDouble(txt_ValorPago.Text)))
                        {
                            Message("Valor Pago Com Sucesso", "Aviso");
                            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        }
                        else
                        {
                            Message("Não Foi Possível Pagar, Verifique Se Os Numeros São Validos", "Aviso");
                            CleanValuePay();
                        }
                    }
                }
                else
                {
                    Message("Existem Compos Em Branco, Para Concluir O Pagamento É Necessario Inserir Valores", "Aviso");
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Pagar A Conta Do Cliente: " + Erro.Message, "Erro");
                CleanValuePay();
            }
        }

        private void CleanValuePay()
        {
            txt_ValorPago.Text = string.Empty;
            txt_TotalDivida.Text = string.Empty;
            txt_clienteSelecionado.Text = string.Empty;
            dgv_cliente.ClearSelection();
        }

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void k_panelCabecalho_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
