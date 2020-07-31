using System;
using VagasAPP.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasAPP {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new ListVagasPage());
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
