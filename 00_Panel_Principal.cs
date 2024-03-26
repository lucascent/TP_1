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
    public partial class Form_Panel_Principal : Form
    {
        public Form_Panel_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Ejercicio_1_Click(object sender, EventArgs e)
        {
            Form_Ejercicio_1 Ejercicio1 = new Form_Ejercicio_1(this);
            Ejercicio1.Show();
            this.Hide();
        }
    }
}
