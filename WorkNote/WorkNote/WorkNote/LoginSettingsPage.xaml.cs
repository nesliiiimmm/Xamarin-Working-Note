using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginSettingsPage : ContentPage
    {
        public LoginSettingsPage()
        {
            InitializeComponent();
            userName.Text = Helper.Settings.GeneralSettings;
            passWord.Text = Helper.Settings.GeneralSettingsPass;
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                if (isRemembered.IsToggled == true)
                {
                    Helper.Settings.GeneralSettings = userName.Text;
                    Helper.Settings.GeneralSettingsPass = passWord.Text;
                }
                else
                {
                    Helper.Settings.GeneralSettings = string.Empty;
                    Helper.Settings.GeneralSettingsPass = string.Empty;
                }
                await Navigation.PushModalAsync(new LoginHelperPage());

            }
            else
            {
                await DisplayAlert("Uyarı", "İnternet bağlantınızı Aktifleştiriniz.", "Tamam");
            }

        }
    }
}