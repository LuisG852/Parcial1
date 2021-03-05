using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPEX1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage   
    {
        
        public TabbedPage1()
        {
            InitializeComponent();
        }
        public void B1(object sender, EventArgs e)
        {
            var lol = int.Parse(en1.Text);

            int res, dia, fecha, A;

            string Total = "", namemes = "";
            A = (lol - 365);
            res = A;
            dia = res / 100;
            fecha = res % 100;
            Total = "Usted nacio el dia " + dia + " y  el  mes " + fecha + "(" + namemes + ")";

            DisplayAlert("La Respueta es:",
                Total,
                "");
        }
        private void B2(object sender, EventArgs e)
        {

            var sis = int.Parse(en2.Text);
            int x, resul;
            x = sis / 10;
            resul = x - 4;
            string Total = "";
            Total = "El numero que estabas pensado es : " + resul;
            DisplayAlert("Resultado", Total, "");
        }
    }
}