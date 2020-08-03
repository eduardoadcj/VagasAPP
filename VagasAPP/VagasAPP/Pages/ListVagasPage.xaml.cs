using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasAPP.Database.Dao;
using VagasAPP.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasAPP.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListVagasPage : ContentPage {

        private VagaRepository repository;

        public ListVagasPage() {
            InitializeComponent();
            repository = new VagaRepository();
            LoadList();
        }

        private void LoadList() {
            var list = new List<Vaga>();
            if (SearchFieldVagas.Text == null || SearchFieldVagas.Text.Length == 0) {
                list = repository.ListAll();
                ListViewVagas.ItemsSource = list;
                CountLabel.Text = list.Count + " vagas listadas";
            } else {
                list = repository.SearchNome(SearchFieldVagas.Text);
                ListViewVagas.ItemsSource = list;
                CountLabel.Text = list.Count + " vagas listadas";
            }
        }

        private void GoCadastro(object sender, EventArgs args) {
            Navigation.PushAsync(new AddVagaPage());
        }

        private void GoMinhasVagas(object sender, EventArgs args) {
            Navigation.PushAsync(new ListEditVagasPage());
        }

        private void OnDetalhesClicked(object sender, EventArgs args) {
            var vaga = (((Label)sender).GestureRecognizers[0] as TapGestureRecognizer).CommandParameter as Vaga;
            Navigation.PushAsync(new ViewVagaPage(vaga));
        }

        private void OnSearch(object sender, TextChangedEventArgs args) {
            LoadList();
        }

    }
}