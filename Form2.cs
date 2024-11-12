using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTANAS_FULL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double area;
            
            int caja1 = Convert.ToInt32(txtn1.Text);
            int caja2 = Convert.ToInt32(txtn2.Text);
            area = (caja1 * caja2) / 2;

            lbRespuesta.Text = area + "cm² ".ToString(); 
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = " ";
            lbRespuesta.Text = "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form3 Vent3 = new Form3();
            this.Hide();    
            Vent3.Show();

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Form1 Vent3 = new Form1();
            this.Hide();
            Vent3.Show();
        }

        private void lbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
