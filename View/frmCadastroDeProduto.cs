using Controller;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace View
{
    public partial class frmCadastroDeProduto : Form
    {
        ProdutoEnum ENUM;
        Produto PROD;
        int ValorEstoque;
        public frmCadastroDeProduto(ProdutoEnum enumerador, Produto prod, int Quantidade/*,TipoDeVendaDeProdutoEnum EnumTipo*/)
        {
            if (prod != null)
            {
                PROD = prod;
            }
            ENUM = enumerador;

            if (Quantidade != 0)
            {

                ValorEstoque = Quantidade;
            }

            InitializeComponent();
        }

        ProdutoDAO produtoDAO = new ProdutoDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja Fechar Esse Formulario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                this.Close();
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
        private void Message(string value, string title)
        {
            MessageBox.Show(value, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {

                this.ActiveControl = txt_CodigoProduto;
                if (categoriaDAO.SelectCategoriaFull().Rows.Count > 0)
                {
                    try
                    {
                        DataTable tabela = categoriaDAO.SelectCategoriaFull();

                        if (tabela != null)
                        {
                            cbb_k_Categoria.DisplayMember = "Nome";
                            cbb_k_Categoria.DataSource = tabela;
                        }


                    }
                    catch (Exception Erro)
                    {

                        Message("Não Foi Possível Carregar O ComboBox Com As Categorias: " + Erro, "Erro");
                    }



                    if (ENUM.Equals(ProdutoEnum.Insert))
                    {
                        this.Text = "Salvar Produto";
                        btn_k_Confirmar.Text = "Salvar";
                        gpb_Produto.Visible = true;
                        CheckBoxValidaCampos();
                        // Message("Antes De Cadastrar Vefirique Se A Categoria Do Produto A Ser Cadastrado Já Foi Inserida Na Categoria", "Aviso");

                    }
                    if (ENUM.Equals(ProdutoEnum.Update))
                    {
                        try
                        {
                            txt_k_QtdEstoque.Enabled = false;
                            this.Text = "Alterar Produto";
                            btn_k_Confirmar.Text = "Alterar";
                            DesapareceTipoVenda();
                            if (PROD.PrecoCompra == 0 && PROD.PrecoVenda == 0)
                            {

                                gpb_Estoque.Visible = false;
                                gpb_Porcentagem.Visible = true;
                            }
                            else
                            {
                                //gpb_Estoque.Enabled = false;
                                lbl_AlterarEstoque.Visible = true;
                                lbl_QuantidadeEstoque.Visible = true;
                                txt_k_QtdEstoque.Visible = true;
                                txt_k_QtdEstoque.Enabled = true;
                                txt_QuantidadeMinima.Visible = true;
                                txt_QuantidadeMaxima.Visible = true;
                                label7.Visible = true;
                                label8.Visible = true;
                                //-----------------------//                                
                                gpb_Estoque.Visible = true;
                                gpb_Porcentagem.Visible = false;

                            }
                            JogaParaOTxt();

                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Jogar Valores Para Os Campos: " + Erro, "Erro");
                        }
                    }
                    if (ENUM.Equals(ProdutoEnum.Delete))
                    {
                        this.Text = "Deletar Produto";
                        btn_k_Confirmar.Text = "Deletar";
                        DesabilitaCampos();
                        if (PROD.PrecoCompra == 0 && PROD.PrecoVenda == 0)
                        {
                            gpb_Estoque.Visible = false;
                            gpb_Porcentagem.Visible = true;
                            /* lbl_QuantidadeEstoque.Visible = false;
                             txt_k_QtdEstoque.Visible = false;
                             lbl_AlterarEstoque.Visible = false;
                             gpb_Estoque.Visible = false;*/
                            //JogaParaOTxt();
                        }
                        else
                        {
                            gpb_Estoque.Enabled = false;
                            gpb_Estoque.Visible = true;
                            gpb_Porcentagem.Visible = false;
                            /*
                            gpb_Porcentagem.Visible = false;
                            lbl_QuantidadeEstoque.Visible = true;
                            txt_k_QtdEstoque.Visible = true;
                            lbl_AlterarEstoque.Visible = true;
                            gpb_Estoque.Enabled = true;*/
                        }
                        JogaParaOTxt();
                        DesapareceTipoVenda();
                        gpb_Produto.Visible = true;

                    }
                }
                else
                {
                    Message("Antes De Cadastrar Um Produto É Necessario Uma Categoria, Cadastre Uma Categoria E Retorne", "Aviso");
                    this.Close();
                }
            }
            catch (Exception Erro)
            {
                Message("Erro AO Carregar Os Dados Para O Cadastro: " + Erro, "Erro");
            }

        }

        private void EscondeEstoque()
        {
            txt_k_QtdEstoque.Visible = false;
            lbl_AlterarEstoque.Visible = false;
            txt_QuantidadeMaxima.Visible = false;
            txt_QuantidadeMinima.Visible = false;
        }

        private void DesapareceTipoVenda()
        {
            lblTipoVenda.Visible = false;
            cbbTipoDeCadastro.Visible = false;
        }

        private void DesabilitaCampos()
        {
            txt_k_NomeProd.Enabled = false;
            txt_k_Descricao.Enabled = false;
            txt_CodigoProduto.Enabled = false;
            txt_k_PrecoCompra.Enabled = false;
            txt_k_PrecoVenda.Enabled = false;
            cbb_k_Categoria.Enabled = false;
            txt_k_QtdEstoque.Enabled = false;
            txt_Porcentagem.Enabled = false;
            //  gpb_Porcentagem.Enabled = false;


        }

        private void JogaParaOTxt()
        {
            try
            {
                if (PROD.PrecoVenda > 0 && PROD.PrecoCompra > 0)
                {
                    txt_k_NomeProd.Text = PROD.Nome;
                    txt_k_Descricao.Text = PROD.Descricao;
                    txt_CodigoProduto.Text = PROD.Codigo;
                    txt_k_PrecoCompra.Text = PROD.PrecoCompra.ToString();
                    txt_k_PrecoVenda.Text = PROD.PrecoVenda.ToString();
                    cbb_k_Categoria.Text = SelecionaCategoriaPeloId(PROD.Categoria);
                    txt_k_QtdEstoque.Text = PROD.Quantidade.ToString()/*ValorEstoque.ToString()*/;
                    txt_QuantidadeMaxima.Text = PROD.QtdMaxima.ToString();
                    txt_QuantidadeMinima.Text = PROD.QtdMinima.ToString();
                }
                else
                {
                    txt_k_NomeProd.Text = PROD.Nome;
                    txt_k_Descricao.Text = PROD.Descricao;
                    txt_CodigoProduto.Text = PROD.Codigo;
                    cbb_k_Categoria.Text = SelecionaCategoriaPeloId(PROD.Categoria);
                    txt_Porcentagem.Text = PROD.Porcentagem.ToString();
                }
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Carregar Os Produtos: " + Erro, "Erro");
            }

        }

        private string SelecionaCategoriaPeloId(int ID)
        {
            try
            {

                DataRow linhaCategoria = categoriaDAO.SelectcategoriaPorId(ID).Rows[0];
                return linhaCategoria["Nome"].ToString();
            }
            catch (Exception Erro)
            {

                Message("Erro Ao Selecionar A Categoria: " + Erro, "Erro");
                return null;
            }


        }
        private void btn_k_Confirmar_Click(object sender, EventArgs e)
        {
            if (cbbTipoDeCadastro.Text.Equals("Unidade") || cbbTipoDeCadastro.Visible == false)
            {

                if (txt_k_QtdEstoque.Text.Length > 0 && txt_k_PrecoVenda.Text.Length > 0
       && cbb_k_Categoria.Text != null && txt_k_PrecoCompra.Text.Length > 0
       && txt_k_NomeProd.Text.Length > 0 || cbbTipoDeCadastro.Visible == false)
                {
                    if (ENUM.Equals(ProdutoEnum.Insert))
                    {
                        try
                        {
                            if (produtoDAO.InsertProduto(JogaParaOObjeto()))
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                Message("Não Foi Possível Cadastrar O Produto, Verifique Se OS Campos Estão Corretos", "Erro");
                            }

                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Ao Salvar O Produto: " + Erro.Message, "Erro");
                        }
                    }
                    else if (ENUM.Equals(ProdutoEnum.Update))
                    {
                        try
                        {
                            if (produtoDAO.UpdateProduto(JogaParaOObjeto()))
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                Message("Não Foi Possível Alterar O Produto, Verifique Se Os Dados Inseridos Estão Corretos", "Erro");
                            }
                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Ao Alterar O Produto: " + Erro.Message, "Erro");
                        }
                    }
                    else if (ENUM.Equals(ProdutoEnum.Delete))
                    {
                        try
                        {
                            if (produtoDAO.DeleteProduto(PROD.Id))
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                throw new System.ArgumentException(new Exception().Message, "original");
                            }
                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Ao Excluir O Produto: " + Erro.Message, "Erro");
                        }
                    }

                }
                else
                {

                    Message("Os Campos Com * São Obrigatorios", "Aviso");
                    return;
                }
            }
            else if (cbbTipoDeCadastro.Text.Equals("Peso") || cbbTipoDeCadastro.Visible == false)
            {



                if (cbb_k_Categoria.Text != null
             && txt_k_NomeProd.Text.Length > 0)
                {

                    if (ENUM.Equals(ProdutoEnum.Insert))
                    {
                        try
                        {
                            /*if (cbbTipoDeCadastro.Text.Equals("Peso") && cbbTipoDeCadastro.Visible == true && txt_Porcentagem.Text.Length > 0)
                            {
                                if (produtoDAO.InsertProduto(JogaParaOObjeto()))
                                {
                                    this.DialogResult = DialogResult.Yes;
                                }
                                else
                                {
                                    Message("Não Foi Possível Cadastrar O Produto, Verifique Se OS Campos Estão Corretos", "Erro");
                                }
                            }
                            else
                            {*/
                            if (produtoDAO.InsertProduto(JogaParaOObjeto()))
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                Message("Não Foi Possível Cadastrar O Produto, Verifique Se OS Campos Estão Corretos", "Erro");
                            }
                            //}


                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Ao Salvar O Produto: " + Erro.Message, "Erro");
                        }
                    }
                    if (ENUM.Equals(ProdutoEnum.Update))
                    {
                        try
                        {
                            if (produtoDAO.UpdateProduto(JogaParaOObjeto()))
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                Message("Não Foi Possível Alterar O Produto, Verifique Se Os Dados Inseridos Estão Corretos", "Erro");
                            }
                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Ao Alterar O Produto: " + Erro.Message, "Erro");
                        }
                    }
                    if (ENUM.Equals(ProdutoEnum.Delete))
                    {
                        try
                        {
                            if (produtoDAO.DeleteProduto(PROD.Id))
                            {
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {
                                throw new System.ArgumentException(new Exception().Message, "original");
                            }
                        }
                        catch (Exception Erro)
                        {

                            Message("Erro Ao Excluir O Produto: " + Erro.Message, "Erro");
                        }
                    }
                }

                else
                {
                    Message("Os Campos Com * São Obrigatorios", "Aviso");
                    return;
                }
            }
            else
            {
                Message("Para Cadastrar Um Produto É Necessario Escolher O Tipo De Venda", "Aviso");
            }
        }





        private bool ValidaCampoPorUnidade()
        {
            bool retornar = false;
            if (txt_k_QtdEstoque.Text.Length > 0 && txt_k_PrecoVenda.Text.Length > 0
          && cbb_k_Categoria.Text != null && txt_k_PrecoCompra.Text.Length > 0
          && txt_k_NomeProd.Text.Length > 0 && cbbTipoDeCadastro.Text.Equals("Unidade"))
            {
                retornar = true;
            }
            else if (cbb_k_Categoria.Text != null
          && txt_k_NomeProd.Text.Length > 0 && cbbTipoDeCadastro.Text.Equals("Peso"))
            {
                retornar = false;
            }
            return retornar;
        }

        private Produto JogaParaOObjeto()
        {
            Produto produto = new Produto();
            if (ENUM != ProdutoEnum.Insert)
            {
                produto.Id = PROD.Id;
            }
            if (cbbTipoDeCadastro.Text.Equals("Unidade") || gpb_Porcentagem.Visible == false)
            {
                produto.Codigo = txt_CodigoProduto.Text;
                produto.Nome = txt_k_NomeProd.Text;
                produto.PrecoCompra = double.Parse(txt_k_PrecoCompra.Text);
                produto.PrecoVenda = double.Parse(txt_k_PrecoVenda.Text);
                produto.Descricao = txt_k_Descricao.Text;
                produto.Categoria = Convert.ToInt32(categoriaDAO.selectCategoriaNomePorId(cbb_k_Categoria.Text))/*Convert.ToInt32(lbl_IdCategoria.Text);*/ ;
                produto.Quantidade = int.Parse(txt_k_QtdEstoque.Text);
                produto.QtdMinima = Convert.ToInt32(txt_QuantidadeMinima.Text);
                produto.QtdMaxima = Convert.ToInt32(txt_QuantidadeMaxima.Text);
            }
            else if (cbbTipoDeCadastro.Text.Equals("Peso") || txt_Porcentagem.Text.Length > 0)
            {

                produto.Codigo = txt_CodigoProduto.Text;
                produto.Nome = txt_k_NomeProd.Text;
                // produto.PrecoCompra = 0;
                // produto.PrecoVenda = 0;
                produto.Descricao = txt_k_Descricao.Text;
                produto.Porcentagem = Convert.ToDecimal(txt_Porcentagem.Text);
                produto.Categoria = Convert.ToInt32(categoriaDAO.selectCategoriaNomePorId(cbb_k_Categoria.Text))/*Convert.ToInt32(lbl_IdCategoria.Text);*/ ;
                // Estoque.Quantidade = 0;
            }

            return produto;
        }
        private void btn_k_Cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void cbb_k_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtribuiIdDaCategoriaParaLabel();

        }

        private void AtribuiIdDaCategoriaParaLabel()
        {
            try
            {
                // lbl_IdCategoria.Text = categoriaDAO.selectCategoriaNomePorId(cbb_k_Categoria.Text).ToString();

            }
            catch (Exception Erro)
            {

                Message("Não Foi Possível Selecionar O Nome Da Categoria: " + Erro, "Erro");
            }
        }

        private void txt_k_PrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txt_k_PrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btn_GotoCadastroCad_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroDeCategoria categoria = new frmCadastroDeCategoria(null, ProdutoEnum.Insert);

                if (categoria.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {

                    if (categoriaDAO.SelectCategoriaFull().Rows.Count > 0)
                    {
                        try
                        {

                            DataTable tabela = categoriaDAO.SelectCategoriaFull();

                            if (tabela != null)
                            {
                                cbb_k_Categoria.DisplayMember = "Nome";
                                cbb_k_Categoria.DataSource = tabela;
                                Message("Categoria Cadstrada Com Sucesso!", "Aviso");
                            }


                        }
                        catch (Exception Erro)
                        {

                            Message("Não Foi Possível Carregar O ComboBox Com As Categorias: " + Erro, "Erro");
                        }

                    }
                }
                /*
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
                newForm.Show();*/
            }
            catch (Exception Erro)
            {

                Message("Não Foi Possível Ir Para A Tela De Cadastro: " + Erro, "Erro");
            }
        }

        private void cbbTipoDeCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBoxValidaCampos();
            }
            catch (Exception Erro)
            {

                Message("Não Foi Possível Mudar Para Esse Tipo De Pagamento: " + Erro, "Erro");
            }
        }

        private void CheckBoxValidaCampos()
        {
            if (cbbTipoDeCadastro.Text.Equals(""))
            {
                gpb_Produto.Visible = false;

            }
            if (cbbTipoDeCadastro.Text.Equals("Unidade"))
            {
                if (gpb_Precos.Visible == false)
                {
                    gpb_Precos.Visible = true;
                    gpb_Produto.Visible = true;
                    gpb_Porcentagem.Visible = false;
                    gpb_Estoque.Visible = true;
                    mostraQuantidadeNoEstoque();
                    focoNotxtCodigo();

                }
            }
            else if (cbbTipoDeCadastro.Text.Equals("Peso"))
            {
               
                gpb_Produto.Visible = true;
                gpb_Porcentagem.Visible = true;
                gpb_Estoque.Visible = false;
               /// naoMostraQuantidadeNoEstoque();
                focoNotxtCodigo();
                gpb_Precos.Visible = false;
            }
            else
            {
                gpb_Produto.Visible = false;
            }
        }

        private void focoNotxtCodigo()
        {
            this.ActiveControl = txt_CodigoProduto;
        }

        private void mostraQuantidadeNoEstoque()
        {
            lbl_AlterarEstoque.Visible = true;
            txt_k_QtdEstoque.Visible = true;
            lbl_QuantidadeEstoque.Visible = true;

        }
        private void naoMostraQuantidadeNoEstoque()
        {
            lbl_AlterarEstoque.Visible = false;
            txt_k_QtdEstoque.Visible = false;
            lbl_QuantidadeEstoque.Visible = false;

        }

        private void txt_k_QtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txt_Porcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txt_k_QtdEstoque_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txt_QuantidadeMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }

        }

        private void txt_QuantidadeMaxima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }





    }
}
