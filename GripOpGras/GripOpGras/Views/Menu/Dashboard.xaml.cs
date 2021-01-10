using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GripOpGras.Models;


namespace GripOpGras.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }

        async void SelectedScreen1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoScreen1());
        }
    }
}