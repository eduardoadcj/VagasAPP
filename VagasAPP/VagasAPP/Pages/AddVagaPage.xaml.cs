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

        private Vaga _oldVaga { get; set; }

        public AddVagaPage(Vaga vaga = null) {
            InitializeComponent();
            if (vaga != null) {
                _oldVaga = vaga;
                LoadForm();
            }
        }

        private void LoadForm() {
            Nome.Text = _oldVaga.Nome;
            Quantidade.Text = _oldVaga.Quantidade.ToString();
            Salario.Text = _oldVaga.Salario.ToString();
            Empresa.Text = _oldVaga.Empresa;
            Cidade.Text = _oldVaga.Cidade;
            Descricao.Text = _oldVaga.Descricao;
            Tipo.IsToggled = _oldVaga.Tipo.Equals("PJ");
            Telefone.Text = _oldVaga.Telefone;
            Email.Text = _oldVaga.Email;
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

            if(_oldVaga == null) {
                Save(vaga);
                App.Current.MainPage = new NavigationPage(new ListVagasPage());
            } else {
                vaga.id = _oldVaga.id;
                Update(vaga);
                App.Current.MainPage = new NavigationPage(new ListEditVagasPage());
            }

        }

        private void Save(Vaga vaga) {
            new VagaRepository().Add(vaga);
        }

        private void Update(Vaga vaga) {
            new VagaRepository().Update(vaga);
        }

    }
}