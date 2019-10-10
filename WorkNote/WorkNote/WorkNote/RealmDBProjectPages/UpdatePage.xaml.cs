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
	public partial class UpdatePage : ContentPage
	{
		public UpdatePage ()
		{
			InitializeComponent ();
            var realmDB = Realm.GetInstance();
            var myEmployees = realmDB.All<Employees>().ToList();
            LstUpdate.ItemsSource = myEmployees;

        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DeletePage());
        }

        private async void LstRead_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem==null)
            {
                return;
            }
            var selectedEmployee = (Employees)e.SelectedItem;
            var lv = (ListView)sender;

            await Navigation.PushModalAsync(new UpdatePopUpPage(selectedEmployee.EmployeeId.ToString()));
            lv.SelectedItem = null;
        }
    }
}