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
    public partial class Form_Ejercicio_3 : Form
    {
        Form_Panel_Principal Principal;
        public Form_Ejercicio_3(Form_Panel_Principal Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
            CHE_Puesto.Items.Add("Data Entry");
            CHE_Puesto.Items.Add("Operador de PC");
            CHE_Puesto.Items.Add("Operador");
            CHE_Puesto.Items.Add("Reparador de PC");
            CHE_Puesto.Items.Add("Tester");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_Ejercicio_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal.Show();
        }

        private void BTN_Borrar_Click(object sender, EventArgs e)
        {
            lblTask.Text = "";
            RAD_Femenino.Checked = true;
            RAD_Casado.Checked = true;

            foreach (int  item in CHE_Puesto.CheckedIndices)
            {
                CHE_Puesto.SetItemCheckState(((short)item), 0);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTask.Text = "";
            if (RAD_Femenino.Checked) lblGender.Text = "Sexo: Femenino";
            else lblGender.Text = "Sexo: Masxulino";
            if (RAD_Casado.Checked) lblIsMarried.Text = "Estado Civil: Casado";
            else lblIsMarried.Text = "Estado Civil: Soltero";
            foreach (var item in CHE_Puesto.CheckedItems)
            {
                lblTask.Text += item+"\n";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
  
        }
    }
}
