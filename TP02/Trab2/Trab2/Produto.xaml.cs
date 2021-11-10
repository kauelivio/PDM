//Kauê de Jesus Livio CB3005461
//Pedro Paulo dos Reis Faria CB3007278

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trab2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Produto : ContentPage
	{
		public Produto ()
		{
           
			InitializeComponent ();

        }

        private async void Res_Clicked(object sender, EventArgs e)
        {

            Prod produto = new Prod
            {
                Id = 1,
                Descricao = desc.Text,
                Categoria = cat.Text,
                Quantidade = int.Parse(quant.Text),
                Preco = decimal.Parse(preco.Text)
            };

            var detalhePage = new ProdutoResultado();
            detalhePage.BindingContext = produto;

            try
            {
                await Navigation.PushAsync(detalhePage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
    }
}