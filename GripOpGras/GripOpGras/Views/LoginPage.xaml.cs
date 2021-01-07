using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GripOpGras.Models;


namespace GripOpGras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        

        public LoginPage ()
		{
			InitializeComponent ();
		}

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Succes", "Oke");
            }
            else
            {
                DisplayAlert("Login", "Login not correct", "Oke");
            }
            }
        }
    }


