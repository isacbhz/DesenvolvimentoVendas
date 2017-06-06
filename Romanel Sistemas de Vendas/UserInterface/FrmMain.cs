using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair da Aplicação", "SAIR DO PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.cadastroToolStripMenuItem1.Select();
            }
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliPesFis frmCadPesFis = new FrmCliPesFis();
            frmCadPesFis.ShowDialog();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliePesJur frmCliePesJur = new FrmCliePesJur();
            frmCliePesJur.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFornPesFis frmFornPesFis = new FrmFornPesFis();
            frmFornPesFis.ShowDialog();
        }

        private void pessoaJurídicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFornPesJur frmFornPesJur = new FrmFornPesJur();
            frmFornPesJur.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void familiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos(AcaoTelaProdutos.Familia);
            frmProdutos.Show();
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos(AcaoTelaProdutos.Formato);
            frmProdutos.Show();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos(AcaoTelaProdutos.Grupo);
            frmProdutos.Show();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos(AcaoTelaProdutos.Tipo);
            frmProdutos.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos(AcaoTelaProdutos.Produto);
            frmProdutos.Show();
        }
    }
}
