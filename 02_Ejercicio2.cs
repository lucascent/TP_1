using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class Form_Ejercicio_2 : Form
    {
        Form_Panel_Principal Principal;
        public Form_Ejercicio_2(Form_Panel_Principal Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
        }

        private void Form_Ejercicio_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {

            if ((TXT_Nombre.Text.Trim() != "") & (TXT_Apellido.Text.Trim() != ""))

            {
                LST_Elementos.Items.Add(TXT_Nombre.Text.Trim() + " " + TXT_Apellido.Text.Trim());
                TXT_Nombre.Text = "";
                TXT_Apellido.Text = "";
                LST_Elementos.Sorted = true;
                TXT_Nombre.Focus();
            }
            else
            {
                MessageBox.Show("Los campos Nombre y Apellido no pueden estar vacíos");
                TXT_Nombre.Text = "";
                TXT_Apellido.Text = "";
                TXT_Nombre.Focus();

            }
        }

        private void LST_Elementos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BTN_Borrar_Click(object sender, EventArgs e)
        {
           if(LST_Elementos.SelectedItem != null)
            {
            LST_Elementos.Items.Remove(LST_Elementos.SelectedItem);
            }
           else
            {
                MessageBox.Show("Seleccione el elemento que desea Borrar");
            }
        }
    }
}
