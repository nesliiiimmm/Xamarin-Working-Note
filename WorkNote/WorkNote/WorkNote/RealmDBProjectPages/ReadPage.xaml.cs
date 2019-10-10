using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNote.Datas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote.RealmDBProjectPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReadPage : ContentPage
	{
        Realm realmDB = Realm.GetInstance();
        public ReadPage ()
		{
			InitializeComponent ();
            var myItemSource = realmDB.All<Employees>().ToList();
            LstRead.ItemsSource = myItemSource;
		}

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new UpdatePage());
        }
    }
}