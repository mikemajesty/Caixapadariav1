using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadastroDeCategoria : Form
    {
        Categoria CATEGORIA;
        ProdutoEnum ENUM;
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        public frmCadastroDeCategoria(Categoria categoria, ProdutoEnum enumerador)
        {
            if (categoria != null)
            {
                CATEGORIA = categoria;
            }
            ENUM = enumerador;

            InitializeComponent();
        }

        private void frmCadastroDeCategoria_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_NomeCategoria;
            if (ENUM.Equals(ProdutoEnum.Insert))
            {
                this.Text = "Inserir Categoria";
                btn_k_Confirmar.Text = "Salvar";
            }
            if (ENUM.Equals(ProdutoEnum.Delete))
            {
                this.Text = "Deletar Categoria";
                btn_k_Confirmar.Text = "Deletar";
                txt_NomeCategoria.Text = CATEGORIA.Nome;
                txt_NomeCategoria.Enabled = false;
            }
            if (ENUM.Equals(ProdutoEnum.Update))
            {
                this.Text = "Alterar Categoria";
                btn_k_Confirmar.Text = "Alterar";
                txt_NomeCategoria.Text = CATEGORIA.Nome;
            }
        }
        private void btn_k_Confirmar_Click(object sender, EventArgs e)
        {
            if (ENUM.Equals(ProdutoEnum.Insert))
            {
                try
                {
                    Categoria cate = new Categoria
                    {
                        Nome = txt_NomeCategoria.Text
                    };
                    if (cate.Nome.Length > 3)
                    {
                        if (categoriaDAO.InsertCategoria(cate))
                        {
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {
                            Message("Não Foi Possível Inserir A Categoria, Verifique Se o Nome Ja Existe", "Erro");
                        }
                    }
                    else
                    {
                        Message("Dados Não Correspondem, Insira Os Dados Corretamente","Aviso");
                        focoNotxt();
                    }
                }
                catch (Exception Erro)
                {
                    Message("Erro Ao Inserir A Categoria No Banco De Dados: " + Erro.Message, "Erro");
                }

            }
            if (ENUM.Equals(ProdutoEnum.Delete))
            {
                try
                {
                    if (categoriaDAO.DeleteCategoria(CATEGORIA.Id))
                    {
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        Message("Não Foi Possível Deletar A Categoria", "Erro");
                    }
                }
                catch (Exception Erro)
                {
                    Message("Erro Ao Deletar A Categoria No Banco De Dados: " + Erro.Message, "Erro");
                }
            }
            if (ENUM.Equals(ProdutoEnum.Update))
            {
                try
                {
                    CATEGORIA.Nome = txt_NomeCategoria.Text;

                    if (categoriaDAO.UpdateCategoria(CATEGORIA))
                    {
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                catch (Exception Erro)
                {
                    Message("Erro Ao Alterar A Categoria: " + Erro.Message, "Erro");
                }
            }

        }

        private void focoNotxt()
        {
            this.ActiveControl = txt_NomeCategoria;
        }
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_k_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
