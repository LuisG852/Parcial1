using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APPEX
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {

            InitializeComponent();
        }
        private void cal(object sender, EventArgs e)
        {
            var z = Double.Parse(SS.Text);
            var x, resultado;
            x = z / 10;
            resultado = x - 4;
            string Total = "";
            Total = "El numero que estabas pensado es : " + resultado;
            DisplayAlert("Resultado", Total, "GOO");
        }
        private void LL(object sender, EventArgs e)
        {
            int resultado, dia, fecha, X;
            var Z = int.Parse(.Text);
            string Total = "", namemes = "";
            X = (Z - 365);
            resultado = X;
            dia = resultado / 100;
            fecha = resultado % 100;
            Total = "Usted nacio el dia " + dia + " y  el  mes " + fecha + "(" + namemes + ")";
           
        }
}
