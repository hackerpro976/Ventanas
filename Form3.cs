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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String condicion = "";
            String caja1 = txtn1.Text;
            String caja2 = txtn2.Text;
            int caja3 = Convert.ToInt32(txtn3.Text);
            int caja4 = Convert.ToInt32(txtn4.Text);
            int caja5 = Convert.ToInt32(txtn5.Text);

            double prom = (double) (caja3 + caja4 + caja5) / 3;
            lbPromedio.Text = prom.ToString();
            if (prom >= 18 )
            {
                condicion = "Aprobado";
                lbCondicion.Text = condicion;
            }
            else if (prom <= 15)
            {
                condicion = "Proceso";
                lbCondicion.Text= condicion;
            }
            else if (prom <= 10)
            {
                condicion = "Desaprobado";
                lbCondicion.Text = condicion;
            }


            String nombre = txtn1.Text;
            lbNombre.Text = nombre;
            String curso = txtn2.Text;
            lbCurso.Text = curso;
            int nota1 = Convert.ToInt32(txtn3.Text);
            lbNota1.Text = nota1.ToString();
            int nota2 = Convert.ToInt32(txtn4.Text);
            lbNota2.Text = nota2.ToString();
            int nota3 = Convert.ToInt32(txtn5.Text);
            lbNota3.Text = nota3.ToString();
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtn4.Text = "";
            txtn5.Text = " ";
            lbNombre.Text = "";
            lbCurso.Text = "";
            lbNota1.Text = "";
            lbNota2.Text = "";
            lbNota3.Text = " ";
            lbPromedio.Text = " ";
            lbCondicion.Text = " ";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form2 vent2 = new Form2();
            this.Hide();
            vent2.Show();
        }

        private void lbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form4 vent4 = new Form4();
            this.Hide();
            vent4 .Show();
        }
    }
}
