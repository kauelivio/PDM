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
	public partial class Padrao : ContentPage
	{
		public Padrao ()
		{
			InitializeComponent ();
		}

        private async void Voltar_Clicked(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
    }
}