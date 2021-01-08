using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppProg1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void About_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new About());
        }

        private void Skills_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Skills());
        }

        private void Education_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Education());
        }

        private void Contacts_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Contacts());
        }
    }
}
