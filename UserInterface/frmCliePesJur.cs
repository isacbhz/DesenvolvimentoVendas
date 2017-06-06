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
    public partial class FrmCliePesJur : Form
    {
        public FrmCliePesJur()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos limparCampos = new LimparCampos();
            limparCampos.ClearFields(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair?", "SAIR CADASTRO", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimparCampos limparCampos = new LimparCampos();
                limparCampos.ClearFields(this);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos limparCampos = new LimparCampos();
            limparCampos.ClearFields(this);
            Close();
                
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CRIA UM NOVO OBJETO PESSOA JURIDICA
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.NomeFantasia = txtNomeFantasia.Text;
            pessoaJuridica.RazaoSocial = txtRazSoc.Text;
            pessoaJuridica.CNPJ = txtCnpj.Text;
            pessoaJuridica.Telefone = txtTelefone.Text;
            pessoaJuridica.Endereco = txtEndereco.Text;
            pessoaJuridica.NumEndereco = Convert.ToInt32(txtNumEnd.Text);
            pessoaJuridica.Complemento = txtCompEnd.Text;
            pessoaJuridica.Bairro = txtBairro.Text;
            pessoaJuridica.Cidade = txtBairro.Text;
            pessoaJuridica.Estado = txtCidade.Text;
            pessoaJuridica.InscricaoEstadual = txtInscEst.Text;
            pessoaJuridica.DataFundacao = dtpFund.Value;

            //INVOCA A REGRA DE NEGOCIO
            CadastrarPessoaJuridica cadastrarPessoaJuridica = new CadastrarPessoaJuridica();
            String retorno = cadastrarPessoaJuridica.InserirPessoaJuririca(pessoaJuridica);

            try
            {
                int idPessoaJuridica = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente " + pessoaJuridica.NomeFantasia + " cadastrado com sucesso", "CADASTRO CLIENTE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparCampos limparCampos = new LimparCampos();
                limparCampos.ClearFields(this);
            }   
            catch (Exception)
            {
                MessageBox.Show("O Cliente não pode ser cadastrado" + retorno + "", "ERRO", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Exclamation);
                throw;
            }
        }
    }
}
