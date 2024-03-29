using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class Form_Ejercicio_1 : Form
    {
      Form_Panel_Principal Principal;
        public Form_Ejercicio_1(Form_Panel_Principal Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
        }

        private void Form_Ejercicio_1_Load(object sender, EventArgs e)
        {

        }

        private void Form_Ejercicio_1_FormClosed(object sender, FormClosedEventArgs e)
        {
               Principal.Show();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (TXT_NombreYApellido.Text.Trim() != "")
            {
                LST_Lista1.Items.Add(TXT_NombreYApellido.Text.Trim());
                TXT_NombreYApellido.Text = "";
            }
            else
            {
                MessageBox.Show("Debe ingresar un Nombre y Apellido");
            }
        }

        private void BTN_Flecha_Click(object sender, EventArgs e)
        {
            LST_Lista2.Items.Add(LST_Lista1.SelectedItem);
        }
    }
}
