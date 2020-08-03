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
    public partial class AddVagaPage : ContentPage {
        public AddVagaPage() {
            InitializeComponent();
        }

        private void AttemptSave(object sender, EventArgs args) {
            //TODO: Validações
            Vaga vaga = new Vaga();
            vaga.Nome = Nome.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.Tipo = Tipo.IsToggled ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;
            Save(vaga);
            App.Current.MainPage = new NavigationPage(new ListVagasPage());
        }

        private void Save(Vaga vaga) {
            new VagaRepository().Add(vaga);
        }

    }
}