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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            if (user == "estudiante2020" && password == "uisrael2020")
            {

                await Navigation.PushAsync(new Registro(user));
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                await DisplayAlert("Alerta", "Ha ingresado el usuario o la contraseña de forma incorrecta", "OK");
                txtUser.Text = "";
                txtPassword.Text = "";
            }
               
        }
    }
}