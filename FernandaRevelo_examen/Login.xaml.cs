using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FernandaRevelo_examen
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if ((user == "Fernanda") && (pass == "mariafer"))
            {
                await Navigation.PushAsync(new Registro(user, pass));

            }
            else
            {
                DisplayAlert("Alerta", "Sus credenciales están incorrectas, inténtelo nuevamente", "cerrar");
            }

        }
    }
}
