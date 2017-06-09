using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
namespace Presenter
{
    public class ControleFormularios : Form
    {
        //METODO PARA AJUSTAR OS CONTROLES DO FORMULARIO DE PRODUTOS
        public void esconderControlesForm(Button botao, Label label, TextBox textBox, GroupBox grbBox)
        {
            botao.Text = "Limpa";
            label.Visible = true;
            label.Text = label.Text;
            label.Location = new Point(12, 18);
            textBox.Visible = true;
            textBox.Location = new Point(12, 38);
            textBox.Size = new Size(320, 140);
            grbBox.Visible = false;
        }

        public void mostrarTodosControlesForm(Form form)
        {
            foreach (Control item in form.Controls)
            {
                item.Visible = true;
            }
        }

        /* FrmProdutos frmProdutos = new FrmProdutos(AcaoTelaProdutos.Produto);
         public void CadastroFrmProdCadTipoGrp()
         {
             if (frmProdutos.Text == "Cadastro Produto - Famíla")
             {
                 //VERIFICACAO SE O CAMPOS ESTÃO PREENCHIDOS                
                 if (frmProdutos.txtDesc.Text == "")
                 {
                     MessageBox.Show("Preencha o campo Descrição", "CADASTRO DE PRODUTOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     return;
                 }

                 //CRIAR O OBJETO
                 ProdutoFamilia produtoFamilia = new ProdutoFamilia();
                 produtoFamilia.Descricao = frmProdutos.txtDesc.Text;

                 //INVOCAR REGRA DE NEGOCIO
                 CadastrarProdutoFamilia cadastrarProdutoFamilia = new CadastrarProdutoFamilia();
                 String retorno = cadastrarProdutoFamilia.ProdutoGrupoInserir(produtoFamilia);
                 try
                 {
                     int IDProdFamilia = Convert.ToInt32(retorno);
                     MessageBox.Show("Família cadastrada com sucesso!\n Código:" + IDProdFamilia + "", "CADASTRO FAMÍLIA",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                     LimparCampos limpa = new LimparCampos();
                     limpa.ClearFields(frmProdutos);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             else if (frmProdutos.Text == "Cadastro Produto - Formato")
             {
                 ProdutoFormato produtoFormato = new ProdutoFormato();
                 produtoFormato.Descricao = frmProdutos.txtDesc.Text;
                 //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                 ValidarCampos validaCampos = new ValidarCampos();
                 validaCampos.checaCamposVazios(frmProdutos);

                 CadastrarProdutoFormato cadastrarProdutoFormato = new CadastrarProdutoFormato();
                 String retorno = cadastrarProdutoFormato.ProdutoFormatoInserir(produtoFormato);
                 try
                 {
                     int IDProdFomato = Convert.ToInt32(retorno);
                     MessageBox.Show("Formato cadastrado com sucesso!\n Código:" + IDProdFomato + "", "CADASTRO FORMATO",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                     LimparCampos limpa = new LimparCampos();
                     limpa.ClearFields(frmProdutos);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             else if (frmProdutos.Text == "Cadastro Produto - Grupo")
             {
                 ProdutoGrupo produtoGrupo = new ProdutoGrupo();
                 produtoGrupo.Descricao = frmProdutos.txtDesc.Text;
                 //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                 ValidarCampos validaCampos = new ValidarCampos();
                 validaCampos.checaCamposVazios(frmProdutos);
                 CadastrarProdutoGrupo cadastrarProdutoGrupo = new CadastrarProdutoGrupo();
                 String retorno = cadastrarProdutoGrupo.ProdutoGrupoInserir(produtoGrupo);
                 try
                 {
                     int IDProdGrupo = Convert.ToInt32(retorno);
                     MessageBox.Show("Formato cadastrado com sucesso!\n Código:" + IDProdGrupo + "", "CADASTRO FORMATO",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                     LimparCampos limpa = new LimparCampos();
                     limpa.ClearFields(frmProdutos);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             else if (frmProdutos.Text == "Cadastro Produto - Tipo")
             {
                 ProdutoTipo produtoTipo = new ProdutoTipo();
                 produtoTipo.DescricaoProdutoTipo = frmProdutos.txtDesc.Text;
                 //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                 ValidarCampos validaCampos = new ValidarCampos();
                 validaCampos.checaCamposVazios(frmProdutos);

                 CadastrarProdutoTipo cadastrarProdutoTipo = new CadastrarProdutoTipo();
                 String retorno = cadastrarProdutoTipo.ProdutoTipoInserir(produtoTipo);
                 try
                 {
                     int IDProdTipo = Convert.ToInt32(retorno);
                     MessageBox.Show("Tipo cadastrado com sucesso!\n Código:" + IDProdTipo + "", "CADASTRO TIPO",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                     LimparCampos limpa = new LimparCampos();
                     limpa.ClearFields(frmProdutos);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             else if (frmProdutos.Text == "Cadastro Produto - Produto")
             {
                 //VERIFICACAO SE OS CAMPOS ESTÃO PREENCHIDOS
                 ValidarCampos validaCampos = new ValidarCampos();
                 validaCampos.checaCamposVazios(frmProdutos);
                 //CRIA NOVO OBJETO PRODUTO
                 Produto produto = new Produto();
                 produto.CodRomanel = Convert.ToInt32(frmProdutos.txtCodRom.Text);
                 produto.DataCadastro = frmProdutos.dtpDataCad.Value;
                 produto.DescricaoDetalhada = frmProdutos.txtDesc.Text;
                 produto.ProdFamila.IdProdutoFamilia = Convert.ToInt32(frmProdutos.cbxFam.Text);
                 produto.ProdFormato.IdProdutoFormato = Convert.ToInt32(frmProdutos.cbxFormato.Text);
                 produto.ProdGrupo.IdProdutoGrupo = Convert.ToInt32(frmProdutos.cbxGrupo.Text);
                 produto.ProdTipo.IDProdutoTipo = Convert.ToInt32(frmProdutos.cbxTipo.Text);
                 produto.PrecocomrpaVenda.PrecoCompra = Convert.ToDecimal(frmProdutos.txtVlrComp.Text);
                 produto.PrecocomrpaVenda.PercentualLucroCompra = Convert.ToDecimal(frmProdutos.txtPercLuc.Text);
                 produto.PrecocomrpaVenda.PrecoDeVenda = Convert.ToDecimal(frmProdutos.txtVlrVenda.Text);
                 //INVOCA A REGRA DE NEGOCIO PARA CADASTRAR PRPDUTO
                 CadastrarProduto cadastrarProduto = new CadastrarProduto();
                 String retorno = cadastrarProduto.ProdutoInserir(produto);
                 try
                 {
                     int IDProduto = Convert.ToInt32(retorno);
                     MessageBox.Show("Produto cadastrado com sucesso!\n Código:" + IDProduto + "", "CADASTRO Produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                     LimparCampos limpa = new LimparCampos();
                     limpa.ClearFields(frmProdutos);
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
     }*/

    }
}
