using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VL
{
    public partial class ControlFechaDeNacimiento : UserControl
    {
        public ControlFechaDeNacimiento()
        {
            InitializeComponent();
        }
        public bool ComprobarFechaDeNacimiento()
        {
            Regex regex = new Regex("[0-9]{2}/[0-9]{2}/[0-9]{4}");
            if (regex.IsMatch(textBoxFechaDeNacimiento.Text))
            {
                DateTime dateTime = DateTime.Now;
                if(DateTime.TryParse(textBoxFechaDeNacimiento.Text, out dateTime) == false) return false;
                if (dateTime > DateTime.Now) return false;
                return true;
                        
            }
            return false;            
        }
    }
}
