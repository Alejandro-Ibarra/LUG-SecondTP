using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    class Val_Nro_Cont : TextBox
    {
        public Boolean validar()
        {
            if (Regex.IsMatch(base.Text, @"^[0-9]{8}$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Formato de telefono incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //return Regex.IsMatch(base.Text, @"^[a-zA-Z]+$");
        }
    }
}
