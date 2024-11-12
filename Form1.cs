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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //caja1 es el nombre del repositorio donde se guardara el primer dato ingresado.
            int caja1 = Convert.ToInt32(txtn1.Text);

            int area = caja1 * caja1;
            
            lbRespuesta.Text =area + " cm²".ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            lbRespuesta.Text = "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 Vent2 = new Form2();
            this.Hide();
            Vent2.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Form1_Load(object sender , EventArgs e )
        {

        }

        private void btVentana3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            this.Hide();
            form3.Show();
        }
    }
}
