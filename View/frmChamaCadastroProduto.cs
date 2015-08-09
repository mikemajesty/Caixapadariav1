using Controller;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class frmChamaCadastroProduto : Form
    {
        public frmChamaCadastroProduto()
        {
            InitializeComponent();
        }
        ProdutoDAO produtoDao = new ProdutoDAO();
        private void frmChamaCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {

                this.ActiveControl = txt_produto;

                if (NomeLoginGlobal.Permicao.Equals("CAIXA"))
                {
                    btn_Alterar.Visible = false;
                    btn_deletar.Visible = false;
                    btn_Novo.Visible = false;
                }
                if (NomeLoginGlobal.Permicao.Equals("RESTRITO"))
                {
                    btn_Alterar.Visible = false;
                    btn_deletar.Visible = false;
                    btn_Novo.Visible = false;

                }
                if (CarregaGrid() != true)
                {
                    Message("Não Foi Possível Caaregar As Informações Do Produto", "Erro");
                }
                //dgv_produto.ClearSelection();
                //dgv_produto.TabStop = false;

            }
            catch (Exception Erro)
            {

                Message("Não Foi Possível Carregar As Informações Do Produto: " + Erro, "Erro");
            }

        }

        private bool CarregaGrid()
        {

            try
            {
                DataTable tabela = produtoDao.selectFullProdutoPorCodigoComEstoque();
                if (tabela != null)
                {
                    dgv_produto.DataSource = tabela;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Erro)
            {

                throw new Exception(Erro.Message);
            }


        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroDeProduto caprod = new frmCadastroDeProduto(ProdutoEnum.Insert, null, 0);
                DialogResult dialogResult = caprod.ShowDialog();
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Message("Produto Cadastrado Com Sucesso", "Aviso");
                    CarregaGrid();
                }

            }
            catch (Exception Erro)
            {

                Message("Erro Ao Abrir O Formulario De Cadastro: " + Erro, "Erro");
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {

                int IdProduto = SelecionaALinhaDoGrid();
                if (IdProduto > 0)
                {
                    Produto prod = new Produto();
                    DataRow Linha = SelecionaUmaLinhaDoBancoEstoque(IdProduto);
                    if (Linha != null)
                    {
                        JogaDeUmaLinhaParaOObjeto(prod, Linha);
                    }
                    if (prod != null)
                    {
                        frmCadastroDeProduto caprod = new frmCadastroDeProduto(ProdutoEnum.Update, prod, Estoque.Quantidade);
                        DialogResult dialogResult = caprod.ShowDialog();
                        if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            Message("Produto Alterado Com Sucesso", "Aviso");
                            CarregaGrid();
                        }
                    }

                }
                else
                {
                    Message("Não Há Produtos Com Esse Nome Ou Não Existe Registros Do Mesmo", "Aviso");
                    CarregaGrid();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Selecionar O Cliente: " + Erro, "Erro");

            }

        }

        private DataRow SelecionaUmaLinhaDoBancoEstoque(int Id)
        {

            return produtoDao.selectFullProdutoPorIDComEstoque(Id, "Pes").Rows[0];
        }

        private int SelecionaALinhaDoGrid()
        {
            if (dgv_produto.Rows.Count > 0)
            {


                int ID = Convert.ToInt32(dgv_produto.CurrentRow.Cells[0].Value);
                if (ID != 0)
                {
                    return ID;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }

        private void JogaDeUmaLinhaParaOObjeto(Produto prod, DataRow Linha)
        {
            if (Convert.ToDouble(Linha["PrecoCompra"]) > 0 && Convert.ToDouble(Linha["PrecoVenda"]) > 0)
            {
                prod.Id = Convert.ToInt32(Linha["ID"]);
                prod.Codigo = Linha["Codigo"].ToString();
                prod.Nome = Linha["Nome"].ToString();
                prod.Categoria = Convert.ToInt32(Linha["Categoria"]);
                prod.PrecoCompra = Convert.ToDouble(Linha["PrecoCompra"]);
                prod.PrecoVenda = Convert.ToDouble(Linha["PrecoVenda"]);
                prod.Descricao = Linha["Descricao"].ToString();
                prod.QtdMaxima = Convert.ToInt32(Linha["QTDMAX"]);
                prod.QtdMinima = Convert.ToInt32(Linha["QTDMIN"]);
                prod.Quantidade = Convert.ToInt32(Linha["Quantidade"]);
            }
            else
            {
                prod.Id = Convert.ToInt32(Linha["ID"]);
                prod.Codigo = Linha["Codigo"].ToString();
                prod.Nome = Linha["Nome"].ToString();
                prod.Categoria = Convert.ToInt32(Linha["Categoria"]);
                prod.Porcentagem = Convert.ToDecimal(Linha["Porcentagem"]);
                prod.Descricao = Linha["Descricao"].ToString();
            }

        }


        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdProduto = SelecionaALinhaDoGrid();
                if (IdProduto > 0)
                {
                    Produto prod = new Produto();
                    DataRow Linha = SelecionaUmaLinhaDoBancoEstoque(IdProduto);
                    if (Linha != null)
                    {
                        JogaDeUmaLinhaParaOObjeto(prod, Linha);
                    }
                    if (prod != null)
                    {
                        frmCadastroDeProduto caprod = new frmCadastroDeProduto(ProdutoEnum.Delete, prod, Estoque.Quantidade);
                        DialogResult dialogResult = caprod.ShowDialog();
                        if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            Message("Produto Excluido Com Sucesso", "Aviso");
                            CarregaGrid();
                        }
                    }
                }
                else
                {
                    Message("Não Há Produtos Selecionados Ou Não Existe O Registro Do Mesmo","");
                    CarregaGrid();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Excluir O Produto: " + Erro, "Erro");

            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_produto.Text.Length > 2)
                {
                    DataTable tabela = produtoDao.selectProdutoPorNome(txt_produto.Text);
                    if (tabela != null)
                    {


                        if (tabela.Rows.Count > 0)
                        {
                            dgv_produto.DataSource = tabela;
                            return;
                        }
                        if (tabela.Rows.Count == 0)
                        {
                            Message("Não Existe Produto Com Esse Nome", "Erro");
                            LimparTxtDePesquisa();
                        }
                        else
                        {
                            Message("O Nome Pesquisado Não Corresponde A Um Registro No Banco", "Erro");
                            LimparTxtDePesquisa();
                        }
                    }
                    else
                    {
                        Message("O Nome Pesquisado Não Corresponde A Um Registro No Banco", "Erro");
                        LimparTxtDePesquisa();
                    }
                }
                else
                {
                    Message("Não É Possível Pesquisar Produtos Com Menos De 2 Letras", "Aviso");
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Pesquisa O Produto: " + Erro, "Erro");

            }
        }

        private void LimparTxtDePesquisa()
        {
            txt_produto.Text = string.Empty;
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_produto_TextChanged(object sender, EventArgs e)
        {
            if (txt_produto.Text.Length <= 2)
            {
                CarregaGrid();
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

        private void txt_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btn_Pesquisar_Click(sender, e);
            }
        }




    }
}
