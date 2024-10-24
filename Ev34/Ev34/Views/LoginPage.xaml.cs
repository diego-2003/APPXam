using Ev34.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ev34.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
            //this.BindingContext = new LoginViewModel();
        }

        private async void Ingresar_Clicked(object sender, EventArgs e)
        {
            string username = TxtUsuario.Text;
            string password = Txtpassword.Text;

            if (IsValidDate(username, password))
            {
                await DisplayAlert("Logrado", "Inicio Exitoso", "Ok");

                await Navigation.PushAsync(new MenuPrincipalPage());
            }
            else
            {
                await DisplayAlert("Error", "Datos Incorrectos", "Ok");
            }

        }

        private bool IsValidDate(string username, string password)
        {
            return username == "1" && password == "1234";
        }
    }
}