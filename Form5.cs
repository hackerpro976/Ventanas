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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
          
            int caja1 = Convert.ToInt32(txtn1.Text);
            int caja2 = Convert.ToInt32(txtn2.Text);

            int suma = caja1  + caja2 ;
            lbRespuesta.Text = suma.ToString();

            
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            int caja1 = Convert.ToInt32(txtn1.Text);
            int caja2 = Convert.ToInt32(txtn2.Text);

            int resta = caja1 - caja2 ;
            lbRespuesta.Text = resta.ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            int caja1 = Convert.ToInt32(txtn1.Text) ;
            int caja2 = Convert.ToInt32(txtn2.Text) ;

            int resta = caja1 * caja2;
            lbRespuesta.Text = resta.ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            String condicion = " ";
            int caja1 = Convert.ToInt32(txtn1.Text);
            int caja2 = Convert.ToInt32(txtn2.Text);

          
            if (caja2 == 0)
            {
                condicion = "no se puede dividir entre 0";
                 lbRespuesta.Text = condicion;
            }
            else
            {
                double divi =(double) caja1 / caja2;
                lbRespuesta.Text = divi.ToString();
            }
        }
    }
}
