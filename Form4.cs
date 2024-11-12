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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            String caja1 = (txtn1.Text);
            int caja2 = Convert.ToInt32(txtn2.Text);
            int caja3 = Convert.ToInt32(txtn3.Text);

            double subtotal = caja2 * caja3;
            lbSubtotal.Text = subtotal.ToString();
            double igv =(double) subtotal * 0.18;
            double neto =(double) subtotal * 1.18;
            lbIgv.Text = igv.ToString();
            lbNeto.Text = neto.ToString();

            String nombre = txtn1.Text;
            lbProducto .Text = nombre;
           int  precio = Convert.ToInt32(txtn2.Text);
            lbPrecio .Text = precio.ToString();
            int cantidad = Convert.ToInt32(txtn3.Text);
            lbCantidad .Text = cantidad.ToString();

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            lbProducto.Text = "";
            lbPrecio.Text = "";
            lbCantidad.Text = "";
            lbNeto.Text = "";
            lbIgv.Text = "";
            lbSubtotal.Text = "";
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            Form3 vent3 = new Form3();
            this.Hide();
            vent3.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();  
            this.Hide();
            form5.Show();
        }
    }
}
