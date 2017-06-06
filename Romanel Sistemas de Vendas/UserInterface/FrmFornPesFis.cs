using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DTO;

namespace View
{
    public partial class FrmFornPesFis : Form
    {
        public FrmFornPesFis()
        {
            InitializeComponent();
           
        }

        private void GrbTipoPessoa_Enter(object sender, EventArgs e)
        {
            
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
           
        }

        private void rdBtnPesFis_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CRIA O OBJETO PESSOAFORNECEDOR
            PessoaFornecedor pessoaFornecedorFis = new PessoaFornecedor();
            pessoaFornecedorFis.IDPessoaTipo = 1;
            pessoaFornecedorFis.Nome = txtNome.Text;
            pessoaFornecedorFis.Cpf = txtCpf.Text;
            pessoaFornecedorFis.Endereco = txtEndereco.Text;
            pessoaFornecedorFis.NumEndereco = Convert.ToInt32(txtNumEnd.Text);
            pessoaFornecedorFis.Complemento = txtCompEnd.Text;
            pessoaFornecedorFis.Bairro = txtBairro.Text;
            pessoaFornecedorFis.Cidade = txtCidade.Text;
            pessoaFornecedorFis.Estado = txtEstado.Text;

            pessoaFornecedorFis.NomeFantasia = null;
            pessoaFornecedorFis.RazaoSocial = null;
            pessoaFornecedorFis.Cnpj = null;
            pessoaFornecedorFis.InscricaoEstadual = null;
            pessoaFornecedorFis.DataFundacao = null;

            //INVOCA A REGRA DE NEGÓCIO PARA INSERIR O CLIENTE NO BANCO
            CadastrarPessoaFornecedor cadastrarPessoaFornecedor = new CadastrarPessoaFornecedor();
            String retorno = cadastrarPessoaFornecedor.InserirFornecedor(pessoaFornecedorFis);

            try
            {
                int IDFornecedor = Convert.ToInt32(retorno);
                MessageBox.Show("Fornecedor " + pessoaFornecedorFis.Nome.ToUpper() + " cadastrado com sucesso", "CADASTRO FORNECEDOR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                DialogResult result = MessageBox.Show("Deseja cadastrar um novo FORNECEDOR?", "CADASTRO FORNECEDOR", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    LimparCampos limparCampos = new LimparCampos();
                    limparCampos.ClearFields(this);
                    txtNome.Focus();
                }
                else
                {
                    Close();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não pode ser cadastrado" + retorno + "", "ERRO", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair do Cadastro?", "CADASTRO FORNECEDOR", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimparCampos limparCampos = new LimparCampos();
                limparCampos.ClearFields(this);
                Close();
            }
            else
            {
                btnCadastrar.Focus();
            }
        }
    }
}
