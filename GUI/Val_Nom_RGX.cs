using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    class Val_Nom_RGX : TextBox
    {
        public Boolean validar()
        {
            if (Regex.IsMatch(base.Text, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Formato Incorrecto, deben ser solo caracteres alfabeticos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
