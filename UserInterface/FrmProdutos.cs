using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using Model;
using Presenter;


namespace View
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos(AcaoTelaProdutos acaoTelaProdutos)
        {
            InitializeComponent();

            if (acaoTelaProdutos == AcaoTelaProdutos.Familia)
            {
                this.Text = "Cadastro Produto - Famíla";
                ControleFormularios presenterCadastros = new ControleFormularios();
                presenterCadastros.esconderControlesForm(btnLimpa, lblDesc, txtDesc, grbPreco);               

            }
            else if (acaoTelaProdutos == AcaoTelaProdutos.Formato)
            {
               this.Text = "Cadastro Produto - Formato";
               ControleFormularios presenterCadastros = new ControleFormularios();
               presenterCadastros.esconderControlesForm(btnLimpa, lblDesc, txtDesc, grbPreco);
            }
            else if (acaoTelaProdutos == AcaoTelaProdutos.Grupo)
            {
                this.Text = "Cadastro Produto - Grupo";
                ControleFormularios presenterCadastros = new ControleFormularios();
                presenterCadastros.esconderControlesForm(btnLimpa, lblDesc, txtDesc, grbPreco); 
            }
            else if (acaoTelaProdutos == AcaoTelaProdutos.Tipo)
            {
                this.Text = "Cadastro Produto - Tipo";
                ControleFormularios presenterCadastros = new ControleFormularios();
                presenterCadastros.esconderControlesForm(btnLimpa, lblDesc, txtDesc, grbPreco);
            }
            else if (acaoTelaProdutos == AcaoTelaProdutos.Produto)
            {
                //LigarCamposForm();
                ControleFormularios presenterCadastros = new ControleFormularios();
                presenterCadastros.mostrarTodosControlesForm(this);
                this.Text = "Cadastro Produto - Produto";
            }
            else
            {
                MessageBox.Show("Não foi possível realizar o cadastro!", "CADASTRO PRODUTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxTipo_Load(object sender, EventArgs e)
        {

        }
       
        private void LigarCamposForm()
        {
            //labels
            this.lblCodRom.Visible = true;
            this.lblData.Visible = true;
            this.lblDesc.Visible = true;
            this.lblFam.Visible = true;
            this.lblFormato.Visible = true;
            this.lblGrupo.Visible = true;
            this.lblTipo.Visible = true;
            //textboxs
            this.txtCodRom.Visible = true;
            this.txtDesc.Visible = true;
            //comboboxs
            this.cbxFam.Visible = true;
            this.cbxFormato.Visible = true;
            this.cbxGrupo.Visible = true;
            this.cbxTipo.Visible = true;
            //datepicker
            this.dtpDataCad.Visible = true;
        }
        private void DesligarGroupBox()
        {
            this.grbPreco.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            if (this.Text == "Cadastro Produto - Famíla")
            {
                //VERIFICACAO SE O CAMPOS ESTÃO PREENCHIDOS                
                    if (txtDesc.Text == "")
                    {
                        MessageBox.Show("Preencha o campo Descrição", "CADASTRO DE PRODUTOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;                  
                    }
              
                //CRIAR O OBJETO
                ProdutoFamilia produtoFamilia = new ProdutoFamilia();
                produtoFamilia.Descricao = txtDesc.Text;

                //INVOCAR REGRA DE NEGOCIO
                CadastrarProdutoFamilia cadastrarProdutoFamilia = new CadastrarProdutoFamilia();
                String retorno = cadastrarProdutoFamilia.ProdutoGrupoInserir(produtoFamilia);
                try
                {
                    int IDProdFamilia = Convert.ToInt32(retorno);
                    MessageBox.Show("Família cadastrada com sucesso!\n Código:" + IDProdFamilia + "", "CADASTRO FAMÍLIA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos limpa = new LimparCampos();
                    limpa.ClearFields(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Text == "Cadastro Produto - Formato")
            {
                ProdutoFormato produtoFormato = new ProdutoFormato();
                produtoFormato.Descricao = txtDesc.Text;
                //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                ValidarCampos validaCampos = new ValidarCampos();
                validaCampos.checaCamposVazios(this);

                CadastrarProdutoFormato cadastrarProdutoFormato = new CadastrarProdutoFormato();
                String retorno = cadastrarProdutoFormato.ProdutoFormatoInserir(produtoFormato);
                try
                {
                    int IDProdFomato = Convert.ToInt32(retorno);
                    MessageBox.Show("Formato cadastrado com sucesso!\n Código:" + IDProdFomato + "", "CADASTRO FORMATO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos limpa = new LimparCampos();
                    limpa.ClearFields(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Text == "Cadastro Produto - Grupo")
            {
                ProdutoGrupo produtoGrupo = new ProdutoGrupo();
                produtoGrupo.Descricao = txtDesc.Text;
                //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                ValidarCampos validaCampos = new ValidarCampos();
                validaCampos.checaCamposVazios(this);
                CadastrarProdutoGrupo cadastrarProdutoGrupo = new CadastrarProdutoGrupo();
                String retorno = cadastrarProdutoGrupo.ProdutoGrupoInserir(produtoGrupo);
                try
                {
                    int IDProdGrupo = Convert.ToInt32(retorno);
                    MessageBox.Show("Formato cadastrado com sucesso!\n Código:" + IDProdGrupo + "", "CADASTRO FORMATO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos limpa = new LimparCampos();
                    limpa.ClearFields(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Text == "Cadastro Produto - Tipo")
            {
                ProdutoTipo produtoTipo = new ProdutoTipo();
                produtoTipo.DescricaoProdutoTipo = txtDesc.Text;
                //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                ValidarCampos validaCampos = new ValidarCampos();
                validaCampos.checaCamposVazios(this);

                CadastrarProdutoTipo cadastrarProdutoTipo = new CadastrarProdutoTipo();
                String retorno = cadastrarProdutoTipo.ProdutoTipoInserir(produtoTipo);
                try
                {
                    int IDProdTipo = Convert.ToInt32(retorno);
                    MessageBox.Show("Tipo cadastrado com sucesso!\n Código:" + IDProdTipo + "", "CADASTRO TIPO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos limpa = new LimparCampos();
                    limpa.ClearFields(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Text == "Cadastro Produto - Produto")
            {
                //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                ValidarCampos validaCampos = new ValidarCampos();
                validaCampos.checaCamposVazios(this);
                //CRIA NOVO OBJETO PRODUTO
                Produto produto = new Produto();
                produto.CodRomanel = Convert.ToInt32(txtCodRom.Text);
                produto.DataCadastro = dtpDataCad.Value;
                produto.DescricaoDetalhada = txtDesc.Text;
                produto.ProdFamila.IdProdutoFamilia = Convert.ToInt32(cbxFam.Text);
                produto.ProdFormato.IdProdutoFormato = Convert.ToInt32(cbxFormato.Text);
                produto.ProdGrupo.IdProdutoGrupo = Convert.ToInt32(cbxGrupo.Text);
                produto.ProdTipo.IDProdutoTipo = Convert.ToInt32(cbxTipo.Text);
                produto.PrecocomrpaVenda.PrecoCompra = Convert.ToDecimal(txtVlrComp.Text);
                produto.PrecocomrpaVenda.PercentualLucroCompra = Convert.ToDecimal(txtPercLuc.Text);
                produto.PrecocomrpaVenda.PrecoDeVenda = Convert.ToDecimal(txtVlrVenda.Text);
                //INVOCA A REGRA DE NEGOCIO PARA CADASTRAR PRPDUTO
                CadastrarProduto cadastrarProduto = new CadastrarProduto();
                String retorno = cadastrarProduto.ProdutoInserir(produto);
                try
                {
                    int IDProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto cadastrado com sucesso!\n Código:" + IDProduto + "", "CADASTRO Produto",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos limpa = new LimparCampos();
                    limpa.ClearFields(this);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não foi possível realizar o cadastro!", "CADASTRO PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVlrComp_TextChanged(object sender, EventArgs e)
        {
            FormatacaoTextBox formatacao = new FormatacaoTextBox();
            formatacao.Moeda(ref txtVlrComp);
        }

        private void txtVlrVenda_TextChanged(object sender, EventArgs e)
        {
            FormatacaoTextBox formatacao = new FormatacaoTextBox();
            formatacao.Moeda(ref txtVlrVenda);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            return;
        }

        private void txtVlrVenda_Click(object sender, EventArgs e)
        {
            Decimal vlrCompra = Convert.ToDecimal(txtVlrComp.Text);
            Decimal porcLucro = Convert.ToDecimal(txtPercLuc.Text);
            Decimal total = CalculaPorcentagem(vlrCompra, porcLucro);
            txtVlrVenda.Text = (total).ToString();

        }
        public Decimal CalculaPorcentagem(Decimal valorEntrada, Decimal Porcentagem)
        {
            decimal total;
            total = (valorEntrada + (Math.Round(valorEntrada * (Porcentagem / 100), 2)));
            return total;
        }

        private void txtPercLuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbPreco_Enter(object sender, EventArgs e)
        {

        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do cadastro?", "CADASTRO PRODUTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimparCampos limpa = new LimparCampos();
                limpa.ClearFields(this);
                Close();
            }
            else
            {
                return;
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            LimparCampos limpa = new LimparCampos();
            limpa.ClearFields(this);
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

