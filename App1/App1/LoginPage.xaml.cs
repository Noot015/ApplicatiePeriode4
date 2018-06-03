using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void OnClickRegister(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegisterPage();
        }

        public void OnClickHub(object sender, EventArgs e)
        {
            App.Current.MainPage = new HubPage();
        }

    }
}
