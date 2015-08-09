using System;
using System.Data;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class frmChamaCadastroCategoria : Form
    {
        CategoriaDAO categoriaDao = new CategoriaDAO();
        public frmChamaCadastroCategoria()
        {
            InitializeComponent();
        }
        private void frmChamaCadastroCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = txt_Categoria;
                CarregaGrid();
            }
            catch (Exception Erro)
            {
                Message("Não Foi Possível Carregar Os Dados Da Categoria: " + Erro, "Erro");

            }
        }
        private void CarregaGrid()
        {
            try
            {
                dgv_categoria.DataSource = categoriaDao.SelectCategoriaFull();


            }
            catch (Exception Erro)
            {
                Message("Não Foi Possível Carregar Os Dados Da Categoria: " + Erro, "Erro");

            }


        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroDeCategoria cadCategoria = new frmCadastroDeCategoria(null, ProdutoEnum.Insert);
                DialogResult dialogResult = cadCategoria.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    Message("Categoria Cadastrada Com Sucesso", "Aviso");
                    CarregaGrid();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Inserir Uma Categoria No Banco De Dados: " + Erro, "Erro");
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdCategoria = JogaoIndexDoGrid();

                if (IdCategoria != 0)
                {
                    DataRow Linha = CarregaLinhaDoGrid(IdCategoria);

                    if (Linha != null)
                    {
                        frmCadastroDeCategoria cadCategoria = new frmCadastroDeCategoria(JogaParaOObjetoUmaLinha(Linha), ProdutoEnum.Update);
                        DialogResult dialogResult = cadCategoria.ShowDialog();
                        if (dialogResult == DialogResult.Yes)
                        {
                            Message("Categoria Alterada Com Sucesso", "Erro");
                            CarregaGrid();
                        }
                    }
                }
                else
                {
                    Message("Não Existe Categoria Seleciona, Ou Não Há Registro Da Mesma", "Erro");
                    CarregaGrid();
                }

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Alterar A Categoria: " + Erro, "Erro");
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdCategoria = JogaoIndexDoGrid();
                if (IdCategoria != 0)
                {
                    if (IdCategoria != 0)
                    {
                        DataRow Linha = CarregaLinhaDoGrid(IdCategoria);

                        if (Linha != null)
                        {
                            frmCadastroDeCategoria cadCategoria = new frmCadastroDeCategoria(JogaParaOObjetoUmaLinha(Linha), ProdutoEnum.Delete);
                            DialogResult dialogResult = cadCategoria.ShowDialog();
                            if (dialogResult == DialogResult.Yes)
                            {
                                Message("Categoria Excluida Com Sucesso", "Erro");
                                CarregaGrid();
                            }
                        }
                    }
                }
                else
                {
                    Message("Não Existe Categoria Seleciona, Ou Não Há Registro Da Mesma", "Erro");
                    CarregaGrid();
                }

            }
            catch (Exception Erro)
            {
                Message("Erro Ao Deletar A Categoria No Banco De Dados: " + Erro, "Erro");
            }
        }

        private Categoria JogaParaOObjetoUmaLinha(DataRow Linha)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    Id = Convert.ToInt32(Linha["ID"]),
                    Nome = Linha["Nome"].ToString()
                };
                return categoria;
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Uma Categoria Do Banco De Dados: " + Erro, "Erro");
                return null;
            }

        }

        private DataRow CarregaLinhaDoGrid(int Id)
        {
            try
            {
                return categoriaDao.SelectcategoriaPorId(Id).Rows[0];
            }
            catch (Exception Erro)
            {
                Message("Erro Ao Carregar Uma Categoria Do Banco De Dados: " + Erro, "Erro");
                return null;
            }

        }

        private int JogaoIndexDoGrid()
        {
            if (dgv_categoria.Rows.Count > 0)
            {
                int ID = Convert.ToInt32(dgv_categoria.CurrentRow.Cells[1].Value);
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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Categoria.Text.Length >= 2)
                {
                    DataTable tabela = categoriaDao.selectCategoriaFullPorNome(txt_Categoria.Text);
                    if (tabela.Rows.Count > 0)
                    {
                        dgv_categoria.DataSource = tabela;
                    }
                    else
                    {
                        Message("Não Existe Categoria Com Esse Nome: ", "Aviso");
                        LimpaTxt();
                        CarregaGrid();
                    }
                }
                else
                {
                    Message("Não É Possível Pesquisar Uma Categoria Com Menos Menos De 3 Letras: ", "Aviso");
                    LimpaTxt();
                }


            }
            catch (Exception Erro)
            {
                Message("Erro Ao Selecionar A Categoria: " + Erro, "Erro");

            }
        }

        private void LimpaTxt()
        {
            txt_Categoria.Text = string.Empty;
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

        private void txt_Categoria_TextChanged(object sender, EventArgs e)
        {
            if (txt_Categoria.Text.Length <= 2)
            {
                CarregaGrid();
            }
        }

        private void txt_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btn_Pesquisar_Click(sender,e);
            }

        }


    }
}
