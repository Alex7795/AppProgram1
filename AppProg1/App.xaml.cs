using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProg1
{
    public partial class App : Application
    {
        public NavigationPage About { get; set; }
        public NavigationPage Skills { get; set; }
        public NavigationPage Education { get; set; }
        public NavigationPage Contacts { get; set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            About = new NavigationPage(new About());
            Skills = new NavigationPage(new Skills());
            Education = new NavigationPage(new Education());
            Contacts = new NavigationPage(new Contacts());
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
