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
    public partial class FrmCliPesFis : Form
    {
        public FrmCliPesFis()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você que Sair?", "FECHAR CADASTRO CLIENTE",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimparCampos limpar = new LimparCampos();
                limpar.ClearFields(this);
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos limparCampos = new LimparCampos();
            limparCampos.ClearFields(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CRIA UM NOVO CLIENTE
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = txtNome.Text;
            pessoaFisica.CPF = txtCpf.Text;
            pessoaFisica.Telefone = txtTelefone.Text;
            pessoaFisica.Endereco = txtEndereco.Text;
            pessoaFisica.NumEndereco = Convert.ToInt32(txtNumEnd.Text);
            pessoaFisica.Complemento = txtCompEnd.Text;
            pessoaFisica.Bairro = txtBairro.Text;
            pessoaFisica.Cidade = txtCidade.Text;
            pessoaFisica.Estado = txtEstado.Text;

            //INVOCA A REGRA DE NEGOCIO PARA INSERIR O CLIENTE NO BANCO
            CadastrarPessoaFisica cadastrarPessoaFisica = new CadastrarPessoaFisica();
            String retorno = cadastrarPessoaFisica.InserirPessoaFisica(pessoaFisica);

            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show(" O Cliente " + pessoaFisica.Nome + " foi cadastrado com suscesso", "CADASTRO CLIENTE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparCampos limpaCampos = new LimparCampos();
                limpaCampos.ClearFields(this);
                
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não pode ser cadastrado" + retorno + "","ERRO",MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Exclamation);                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos limparCampos = new LimparCampos();
            limparCampos.ClearFields(this);
        }
    }
}