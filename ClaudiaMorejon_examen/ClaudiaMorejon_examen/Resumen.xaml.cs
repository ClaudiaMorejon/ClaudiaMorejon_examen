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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string totalPagar,string usuario)
        {
            Login login1 = new Login();
            InitializeComponent();
     
           //string usuario1 = lblUsuario.Text;
            lblUsuario.Text = usuario ;

            string nombre1 = lblNombre.Text;
            lblNombre.Text = nombre1 + nombre;

            string total1 = lblTotal.Text;
            lblTotal.Text = total1 + totalPagar;

        }


    }
}