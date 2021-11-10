//Kauê de Jesus Livio CB3005461
//Pedro Paulo dos Reis Faria CB3007278

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trab2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dinamico : ContentPage
	{

        public Dinamico()
		{
			InitializeComponent();
            data.Text = DateTime.Now.ToString();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                data.Text = DateTime.Now.ToString();
                return true;
            });
        }
    }
}