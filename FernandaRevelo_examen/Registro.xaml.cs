using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FernandaRevelo_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();

            lbluser.Text = "Usuario Conectado: " + user;

        }

        private void btnCuota_Clicked(object sender, EventArgs e)
        {
            float montoInicial = 1800;
            float interes;
            float restante;

            try
            {
                string nombre = Convert.ToString(lbluser1.Text);
                double monto = Convert.ToDouble(txtMonto.Text);
                double cuota = Convert.ToDouble(txtCuota.Text);
                double fin=Convert.ToDouble(txtFinal.Text);

                if (monto < montoInicial)
                {
                    restante = (float)(montoInicial - monto);

                    interes = (float)(montoInicial * 0.05);

                    cuota = (restante / 3) + interes;
                    fin = (float)((monto) + (cuota * 3));
                    txtCuota.Text = cuota.ToString();
                    txtFinal.Text = fin.ToString();

                }
                else
                {
                    monto = 0;
                    txtCuota.Text = monto.ToString();
                }

            }
            catch (Exception ex)
            {

                DisplayAlert("Error", ex.Message, "Cerrar");
            }

        }

        private async void btnResumen_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Datos guardados con éxito ", "cerrar");
            string nombre = lbluser1.Text;
            string user = lbluser.Text;
            string fin = txtFinal.Text;
            await Navigation.PushAsync(new Resumen(nombre, user, fin));
        }
    }
}