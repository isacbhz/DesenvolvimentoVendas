using System.Windows.Forms;

namespace View
{
    class LimparCampos
    {
        public void ClearFields(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Items.Clear();
                }
            }
        }
    }
}
