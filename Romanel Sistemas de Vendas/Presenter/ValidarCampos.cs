using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public class ValidarCampos
    {
        //METODO CHECA SE CAMPOS ESTÃO VAZIOS
        public void checaCamposVazios(Control control)
        {
            foreach (Control verifica in control.Controls)
            {
                if (verifica.GetType().Equals(typeof(TextBox)) && verifica.Text == "" ||
                    verifica.GetType().Equals(typeof(MaskedTextBox)) && verifica.Text == "" ||
                    verifica.GetType().Equals(typeof(ComboBox)) && verifica.Text == "" ||
                    verifica.GetType().Equals(typeof(GroupBox)) && verifica.Text == "")
                {
                    MessageBox.Show("O campo " + verifica.AccessibleName + " está vazio! Deseja Continuar?", "CADASTRO PRODUTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }                
            }
            
        }
    }
}
