using Rg.Plugins.Popup.Extensions;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopUpRootPage : ContentPage
	{
		public PopUpRootPage ()
		{
			InitializeComponent ();
		}

        private async void BtnPopUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new PopUpRealPage());
        }
    }
}