using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasAPP.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasAPP.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewVagaPage : ContentPage {
        public ViewVagaPage(Vaga vaga) {
            InitializeComponent();
            BindingContext = vaga;
        }
    }
}