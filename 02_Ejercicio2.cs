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
    }
}
