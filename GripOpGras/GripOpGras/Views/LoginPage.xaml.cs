using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GripOpGras.Models;


namespace GripOpGras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {


        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LogInIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Username.Completed += (s, e) => SignInProcedure(s, e);
        }
        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Succes", "Oke");
                App.UserDatabase.SaveUser(user);
                


            }
            else
            {
                DisplayAlert("Login", "Login not correct", "Oke");
            }
            
        }
    }
}


