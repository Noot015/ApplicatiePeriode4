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
            DisplayAlert("Alert", "You have been alerted once", "OK");
            new RegisterPage();
        }

    }
}
