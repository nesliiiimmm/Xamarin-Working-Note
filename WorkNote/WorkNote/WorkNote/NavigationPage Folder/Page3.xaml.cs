using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote.NavigationPage_Folder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Nereye gidiyorsun..", "Ahh gidecek yer mi kaldı kii...", "iyi gideyim ben");
            await Navigation.PopAsync();
        }
    }
}