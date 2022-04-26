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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string user,string fin)
        {
            InitializeComponent();

            lbluser.Text = user;
            lbluser1.Text = nombre;
            txtFinal.Text = fin.ToString();



        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {

        }
    }
}