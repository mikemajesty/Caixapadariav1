using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmChamaCadastroComanda : Form
    {
        public frmChamaCadastroComanda()
        {
            InitializeComponent();
        }
        ComandaDAO comandaDao = new ComandaDAO();


        private void frmChamaCadastroComanda_Load(object sender, EventArgs e)
        {
            try
            {

                CarregarGrid();
                this.ActiveControl = btn_Novo;
                CarregaCodigoComanda();
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Informações Da Comanda: " + Erro, "Erro");
            }
        }

        private void CarregarGrid()
        {

            try
            {
                dgv_Comanda.DataSource = comandaDao.SelectFull();
                dgv_Comanda.ClearSelection();

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar As Informações Da Comanda: "+Erro.Message,"Erro");
            }
            
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Novo_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmCodigoDeBarra chama = new frmCodigoDeBarra(ComandaEnum.Novo, null);
                DialogResult dialog = chama.ShowDialog();
                if (dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    CarregarGrid();
                    LimparTxt();
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Caadastrar Uma Nova Comanda: " + Erro, "Erro");
            }
        }

        private void btn_Alterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_comandaSelecionada.Text.Length > 0)
                {
                    frmCodigoDeBarra chama = new frmCodigoDeBarra(ComandaEnum.Alterar, CarregaIDComanda());
                    DialogResult dialog = chama.ShowDialog();
                    if (dialog == System.Windows.Forms.DialogResult.Yes)
                    {
                        CarregarGrid();
                        LimparTxt();
                    }
                }
                else
                {
                    Message("Não É Possível Alterar Uma Comanda Antes De Selecionar", "Aviso");
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Alterar As Informações Da Comanda: " + Erro, "Erro");
            }
        }

        private void LimparTxt()
        {
            txt_comandaSelecionada.Text = string.Empty;
        }

        private void btn_deletar_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (txt_comandaSelecionada.Text.Length > 0)
                {

                    frmCodigoDeBarra chama = new frmCodigoDeBarra(ComandaEnum.Deletar, CarregaIDComanda());
                    DialogResult dialog = chama.ShowDialog();
                    if (dialog == System.Windows.Forms.DialogResult.Yes)
                    {
                        CarregarGrid();
                        LimparTxt();
                    }
                }
                else
                {
                    Message("Não É Possível Deletar Uma Comanda Antes De Selecionar", "Aviso");
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Deletar As Informações Da Comanda: " + Erro, "Erro");
            }
        }

        private void dgv_Comanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaCodigoComanda();
        }
        private Comanda CarregaIDComanda()
        {
            try
            {

                Comanda comanda = new Comanda();
                comanda.Id = Convert.ToInt32(dgv_Comanda.CurrentRow.Cells[0].Value);
                comanda.Codigo = dgv_Comanda.CurrentRow.Cells[1].Value.ToString();
                return comanda;

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Selecionar O Código Da Comanda: " + Erro.Message, "Erro");
                return null;
            }
        }
        private void CarregaCodigoComanda()
        {
            try
            {
                if (comandaDao.SelectFull().Rows.Count > 0)
                {
                    string Codigo = dgv_Comanda.CurrentRow.Cells[1].Value.ToString();
                    txt_comandaSelecionada.Text = Codigo;

                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Selecionar O Código Da Comanda: " + Erro.Message, "Erro");
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
