using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
            InitializeComponent();
		}

        public void OnClickLogin(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }

        public void OnClickHub(object sender, EventArgs e)
        {
            App.Current.MainPage = new HubPage();
        }


    }
}