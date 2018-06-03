using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            DisplayAlert("Hello", "This is the HomePage", "Ok");
            base.OnAppearing();
        }

        private void AddOffer_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new AddOffer();
        }
    }
}