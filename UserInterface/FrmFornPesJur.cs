using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Model;

namespace View
{
    public partial class FrmFornPesJur : Form
    {
        public FrmFornPesJur()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos limparCampos = new LimparCampos();
            limparCampos.ClearFields(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CRIA O OBJETO FORNECEDOR
            PessoaFornecedor pessoaFornecedorJur = new PessoaFornecedor();
            pessoaFornecedorJur.IDPessoaTipo = 2;
            pessoaFornecedorJur.NomeFantasia = txtNomeFantasia.Text;
            pessoaFornecedorJur.RazaoSocial = txtRazSoc.Text;
            pessoaFornecedorJur.Cnpj = txtCnpj.Text;
            pessoaFornecedorJur.Endereco = txtEndereco.Text;
            pessoaFornecedorJur.NumEndereco = Convert.ToInt32(txtNumEnd.Text);
            pessoaFornecedorJur.Complemento = txtCompEnd.Text;
            pessoaFornecedorJur.Bairro = txtBairro.Text;
            pessoaFornecedorJur.Cidade = txtCidade.Text;
            pessoaFornecedorJur.Estado = txtEstado.Text;
            pessoaFornecedorJur.InscricaoEstadual = txtInscEst.Text;
            pessoaFornecedorJur.DataFundacao = dtpFund.Value;

            pessoaFornecedorJur.Nome = null;
            pessoaFornecedorJur.Cpf = null;

            //INVOCA REGRA DE NEGÓCIOS E INSERE OS DADOS NO BANCO
            CadastrarPessoaFornecedor cadastrarPessoaFornecedor = new CadastrarPessoaFornecedor();
            String retorno = cadastrarPessoaFornecedor.InserirFornecedor(pessoaFornecedorJur);
           
            try
            {
                int IDPessoaFornecedor = Convert.ToInt32(retorno);
                MessageBox.Show("Fornecedor " + pessoaFornecedorJur.NomeFantasia.ToUpper()+ " cadastrado com sucesso", "CADASTRO FORNECEDOR", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                DialogResult result = MessageBox.Show("Deseja cadastrar um novo FORNECEDOR?", "CADASTRO FORNECEDOR", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    LimparCampos limparCampos = new LimparCampos();
                    limparCampos.ClearFields(this);
                    txtNomeFantasia.Focus();
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
    }
}
