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

namespace Vista_Practica2doPLUG
{
    public partial class TextBox_Id_Y_Direccion : UserControl
    {
        public TextBox_Id_Y_Direccion()
        {
            InitializeComponent();
        }

        bool textBoxId_Valido;
        bool textBoxDireccion_Valido;
        string textId;
        string textDireccion;

        public bool TextBoxId_Valido { get => textBoxId_Valido; set => textBoxId_Valido = value; }
        public bool TextBoxDireccion_Valido { get => textBoxDireccion_Valido; set => textBoxDireccion_Valido = value; }
        public string TextId { get => textId; set => textId = value; }
        public string TextDireccion { get => textDireccion; set => textDireccion = value; }

        private void TextBox_Id_Y_Direccion_Load(object sender, EventArgs e)
        {
            TextBoxId_Valido = false;
            TextBoxDireccion_Valido = false;
            textId = "";
            textDireccion = "";
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            TextId = textBoxId.Text;
            ControlID();
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            TextDireccion = textBoxDireccion.Text;
            ControlDireccion();
        }

        private void ControlID()
        {
            Regex regexID = new Regex(@"[A-Z]{3}-\d{3}");
            Match resultadoId = regexID.Match(textBoxId.Text);
            if (resultadoId.Success == true)
            {
                TextBoxId_Valido = true;
            }
            else
            {
                TextBoxId_Valido = false;
            }
        }

        private void ControlDireccion()
        {
            Regex regexDireccion = new Regex(@"[a-zA-Z]{1,}\s\d{4}");
            Match resultadoDireccion = regexDireccion.Match(textBoxDireccion.Text);
            if (resultadoDireccion.Success == true)
            {
                TextBoxDireccion_Valido = true;
            }
            else
            {
                TextBoxDireccion_Valido = false;
            }
        }


    }
}
