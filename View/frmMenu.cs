using Controller;
using Model;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {

            InitializeComponent();

        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {

                KeyGenDAO keygenDao = new KeyGenDAO();
               
                if (keygenDao.selectQuantidadeData() > 30)
                {
                    MessageBox.Show("Seu perido de ativação acabou","Aviso");
                    frmAtivacao mostra = new frmAtivacao();
                    mostra.Show();
                    this.Close();
                }

            

                //----------------------------------------------------------------------
                //                      CÓDIGO NOVO
                int x = Screen.PrimaryScreen.Bounds.Size.Width;
                int y = Screen.PrimaryScreen.Bounds.Size.Height;
                this.Size = new System.Drawing.Size(x, y);
                this.Location = new System.Drawing.Point(0,0);
                //this.StartPosition = FormStartPosition.CenterParent;
                //----------------------------------------------------------------------
                //----------------------------------------------------------------------
                                CarregarRelogio();
                NomeUsuario.Text += NomeLoginGlobal.Nome + " - Permissão: " + NomeLoginGlobal.Permicao;

                if (NomeLoginGlobal.Permicao.Equals("INTERMEDIARIO"))
                {
                    btn_Cadastro.Visible = false;
                    //btn_Venda.Visible = false;
                    btn_Cadastro.Visible = false;
                    btn_CadastroCategoria.Visible = false;
                }
               
                else if (NomeLoginGlobal.Permicao.Equals("CAIXA"))
                {
                    btn_Estoque.Visible = false;
                    btn_Caixa.Visible = false;
                    btn_CadastroCategoria.Visible = false;
                    btn_PesquisarProdutos.Visible = false;
                }
                else if (NomeLoginGlobal.Permicao.Equals("RESTRITO"))
                {
                    btn_Estoque.Visible = false;
                    btn_CadastroCategoria.Visible = false;
                    btn_Estoque.Visible = false;
                    btn_Venda.Visible = false;
                    btn_PesquisarProdutos.Visible = false;
                    btn_Caixa.Visible = false;
                    btn_ChamaCadastroComanda.Visible = false;
                    btnCadastroCliente.Visible = false;
                }
              
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar As Informações Do Formulario: " + Erro.Message, "Erro");
            }


        }
        private void CarregarRelogio()
        {
            timer1.Start();
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCalculador_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Abrir A Calculadora Do Windows: " + Erro, "Erro");
            }
        }

        private void btn_BlocoNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Abrir O Bloco De Notas: " + Erro, "Erro");
            }
        }

      
        private void btn_Venda_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmVendas))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmVendas();
            newForm.MdiParent = this;
            newForm.Show();

            //frmVendas venda = new frmVendas();
            //venda.MdiParent = this;
            //venda.Show();
        }

        private void btn_Caixa_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmFluxoDeCaixa))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmFluxoDeCaixa();
            newForm.MdiParent = this;
            newForm.Show();

            //frmFluxoDeCaixa fluxoDeCaixa = new frmFluxoDeCaixa();
            //fluxoDeCaixa.MdiParent = this;
            //fluxoDeCaixa.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Relogio.Text = DateTime.Now.ToString();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmChamaCadastroProduto))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmChamaCadastroProduto();
            newForm.MdiParent = this;
            newForm.Show();

            //frmChamaCadastroProduto cadastroProduto = new frmChamaCadastroProduto();
            //cadastroProduto.MdiParent = this;
            //cadastroProduto.Show();
        }

        private void btn_PesquisarProdutos_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmConsultaProdutos))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmConsultaProdutos();
            newForm.MdiParent = this;
            newForm.Show();

            //frmConsultaProdutos consultar = new frmConsultaProdutos();
            //consultar.MdiParent = this;
            //consultar.Show();
        }

        private void btn_CadastroCategoria_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmChamaCadastroCategoria))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmChamaCadastroCategoria();
            newForm.MdiParent = this;
            newForm.Show();

            //frmChamaCadastroCategoria cadCategoria = new frmChamaCadastroCategoria();
            //cadCategoria.MdiParent = this;
            //cadCategoria.Show();
        }


        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAlterarEstoque))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmAlterarEstoque();
            newForm.MdiParent = this;
            newForm.Show();

            //frmAlterarEstoque alteraEstoque = new frmAlterarEstoque();
            //alteraEstoque.MdiParent = this;
            //alteraEstoque.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {


            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btn_ChamaCadastroComanda_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmChamaCadastroComanda))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmChamaCadastroComanda();
            newForm.MdiParent = this;
            newForm.Show();
            //frmChamaCadastroComanda chama = new frmChamaCadastroComanda();
            //chama.MdiParent = this;
            //chama.Show();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmFiado))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new frmFiado(EnumModificaFiado.Consulta);
            newForm.MdiParent = this;
            newForm.Show();
            //frmFiado chama = new frmFiado(EnumModificaFiado.Consulta);
            //chama.MdiParent = this;
            //chama.Show();
        }

        



    }
}
