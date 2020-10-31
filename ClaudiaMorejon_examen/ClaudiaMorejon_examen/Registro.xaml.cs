using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClaudiaMorejon_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        
        public Registro(string user)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
            
        }

        private  void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                double montoInicial = Double.Parse(txtMonto.Text);
                if (nombre != null && montoInicial != null)
                {
                    DisplayAlert("Notificación", "Datos guardados", "OK");
                }
                else
                {
                    DisplayAlert("Notificación", "Error", "OK");
                }

            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", "Error" + ex.Message, "OK");
            }
         
           
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                string nombre = txtNombre.Text;
                double montoInicial = Double.Parse(txtMonto.Text);
                double resta;
                double cuotaSinPorcentaje;
                double total;
                double pagoMensual;

                if (montoInicial < 1800 && nombre!=null && montoInicial!=null && montoInicial>0)
            {
               
                    resta = 1800 - montoInicial;
                    cuotaSinPorcentaje = resta / 3;
                    pagoMensual = cuotaSinPorcentaje * 1.05;
                    total = pagoMensual * 3;
                    lblPago.Text = pagoMensual.ToString();
                    string totalPagar = total.ToString();
                    await Navigation.PushAsync(new Resumen(nombre, totalPagar, lblUser.Text));
                
            }
            else
            {
                await DisplayAlert("Alerta", "Ingrese un monto menor a 1800", "OK");
            }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Alerta", "Error" + ex.Message, "OK");
            }

        }
    }
}