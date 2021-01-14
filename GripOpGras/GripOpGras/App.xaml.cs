using GripOpGras.Data;
using GripOpGras.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using SQLite;
Forms.SetFlags("CollectionView_Experimental")


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GripOpGras
{
    public partial class App : Application
    {
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
            //MainPage = new NavigationPage(new LoginPage(new Page1()));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase==null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }

   
    }
}
