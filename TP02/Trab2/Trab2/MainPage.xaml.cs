using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trab2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Padrao_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Padrao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Dinamico_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Dinamico());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Trigger_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new TriggersView());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Simples_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new Simples());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = "Kaue",
                Idade = 21,
                Profissao = "Desenvolvedor",
                Pais = "Brasil"
            };

            var detalhePage = new Home();
            detalhePage.BindingContext = contato;

            try
            {
                await Navigation.PushAsync(detalhePage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }


        private async void Produto_Clicked(object sender, EventArgs e)
        {


            try
            {
                await Navigation.PushAsync(new Produto());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
    }
}
