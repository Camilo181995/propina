using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace propina
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Conversion de variables
            double total = Convert.ToInt32(Etotal.Text);
            double propina = Convert.ToInt32(Epropina.Text);
            int numeropersonas = Convert.ToInt32(Enpersonas.Text);

            double Respropina = (total * propina) / 100;
            double Restotal = Respropina + total;
            double ResPrope = Respropina / numeropersonas;
            double Restoper = Restotal / numeropersonas;

            //set de text
            Rpropina.Detail = "$" + Respropina;
            Rtotal.Detail = "$" + Restotal;
            Rprper.Detail = "$" + ResPrope;
            Rtotalpers.Detail = "$" + Restoper;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
