using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Exerc_Sec2_Aula20_Udemy_xamarin_form
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exerc_Sec2_Aula20_Udemy_xamarin_form.QuotesPage();
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
    }
}
