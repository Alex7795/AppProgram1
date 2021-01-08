using Plugin.Messaging;
using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProg1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Contacts()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Email(object sender, EventArgs e)
        {
            var email = CrossMessaging.Current.EmailMessenger;
            if (email.CanSendEmail)
                email.SendEmail("NotARealAdress@fake.dumb", "Angående portfolio", "Sendt fra appen: Min portfolio");
        }

        private void Call(object sender, EventArgs e)
        {
            var phone = CrossMessaging.Current.PhoneDialer;
            if (phone.CanMakePhoneCall)
                phone.MakePhoneCall("+4588888888", "Alexander C.");
        }

        private void Message(object sender, EventArgs e)
        {
            var message = CrossMessaging.Current.SmsMessenger;
            if (message.CanSendSms)
                message.SendSms("+4588888888", "Besked sendt fra appen Min Portfolio");
        }
    }
}