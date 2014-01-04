using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_area_altura_volumen_de_un_cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Cilindro()
        {
            //Declararemos 5 variables de tipo double
            double altura, area, radio, radio2, volumen;
            //Condición que valida los TextBox si  estos están vacío 
            if (TextBox_Altura.Text == "")
            {
                MessageBox.Show("Ingrese una altura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Coloca el Focus en el TextBox_Altura
                TextBox_Altura.Focus();
            }
            else
            {
                //Condición que valida los TextBox si  estos están vacío 
                if (TextBox_Radio.Text == "")
                {
                    MessageBox.Show("Ingrese un radio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Coloca el Focus en el TextBox_Radio
                    TextBox_Radio.Focus();
                }
                else
                {
                    /* Funciones que convierte en un tipo double el valor que se ingrese por 
                        los TextBox y lo almacena en las variables radio,altura  */
                    altura = Convert.ToDouble(TextBox_Altura.Text);
                    radio= Convert.ToDouble(TextBox_Radio.Text);
                    //Metodo para calcular el área del cilindro
                    area = (2 * Math.PI * radio * (altura + radio));
                    /* Eleva al cuadrado el dato almacenado en las variable 
                          radio y lo almacena  en la variable radio2  */
                    radio2 = Math.Pow(radio, 2);
                    //Método para calcular el volumen del cilindro
                    volumen = (Math.PI * radio2 * altura);
                    //Mostrar los resultados en la label
                    Label_Area.Text = area.ToString();
                    Label_Volumen.Text = volumen.ToString();
                }
            }
        }

        private void Button_Limpiar_Click(object sender, EventArgs e)
        {
            //Restablecer los controles 
            TextBox_Altura.Text = ""	;
            TextBox_Radio.Text = "";
            Label_Area.Text = "0";
            Label_Volumen.Text = "0";
            TextBox_Altura.Focus();
        }

        private void Button_Calcular_Click(object sender, EventArgs e)
        {
            Cilindro();
        }
     }
}

 
 