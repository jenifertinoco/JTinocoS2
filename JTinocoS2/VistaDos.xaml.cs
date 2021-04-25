using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JTinocoS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaDos : ContentPage
    {
        public VistaDos(string usuario, string clave)
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            //capturar excepciones
            try
            {

                double dato1 = Convert.ToDouble(txtseg1.Text);
                double dato2 = Convert.ToDouble(txtexa1.Text);
                double dato3 = Convert.ToDouble(txtseg2.Text);
                double dato4 = Convert.ToDouble(txtexa2.Text);

                double suma1 = ((dato1 * 0.3) + (dato2 * 0.2));
                double suma2 = ((dato3 * 0.3) + (dato4 * 0.2));
                double suma = suma1 + suma2;

                txtResultadonp1.Text = suma1.ToString();
                txtResultadonp2.Text = suma2.ToString();
                txtResultadof.Text = suma.ToString();

                if (suma >= 7)
                {
                    DisplayAlert("Mensaje", "APROBADO", "Gracias");
                }
                else if (suma < 7)
                {
                    DisplayAlert("Mensaje", "REROBADO", "Gracias");
                }

                if (suma >= 5 && suma <= 6.9)
                {
                    DisplayAlert("Mensaje", "COMPLEMENTARIO", "Gracias");
                }
            }

            catch (Exception ex)
            {
                //Mensaje de erro capturado por el catch
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        
        }

    }
}