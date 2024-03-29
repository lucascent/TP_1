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
    }
}
