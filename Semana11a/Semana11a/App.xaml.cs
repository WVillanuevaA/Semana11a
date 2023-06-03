using System;
using Semana11a.Services;
using Semana11a.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana11a
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Views.Operacions();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
