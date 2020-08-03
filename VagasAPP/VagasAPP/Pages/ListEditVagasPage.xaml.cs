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
    public partial class ListEditVagasPage : ContentPage {

        private VagaRepository _repository;

        public ListEditVagasPage() {
            InitializeComponent();
            _repository = new VagaRepository();
            LoadList();
        }

        private void LoadList() {
            var list = new List<Vaga>();
            if (SearchFieldVagas.Text == null || SearchFieldVagas.Text.Length == 0) {
                list = _repository.ListAll();
                ListViewVagas.ItemsSource = list;
                CountLabel.Text = list.Count + " vagas listadas";
            } else {
                list = _repository.SearchNome(SearchFieldVagas.Text);
                ListViewVagas.ItemsSource = list;
                CountLabel.Text = list.Count + " vagas listadas";
            }
        }

        private void OnSearch(object sender, TextChangedEventArgs args) {
            LoadList();
        }

        private void OnEditClicked(object sender, EventArgs args) {
            var tapGest = ((Label)sender).GestureRecognizers[0] as TapGestureRecognizer;
            var vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new AddVagaPage(vaga));
        }

        private void OnDeleteClicked(object sender, EventArgs args) {
            var tapGest = ((Label)sender).GestureRecognizers[0] as TapGestureRecognizer;
            var vaga = tapGest.CommandParameter as Vaga;
            _repository.Delete(vaga);
            LoadList();
        }

    }
}