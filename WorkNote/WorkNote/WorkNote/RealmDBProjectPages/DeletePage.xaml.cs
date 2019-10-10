using Realms;
using Rg.Plugins.Popup.Extensions;
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
	public partial class DeletePage : ContentPage
	{
        Realm realmDB = Realm.GetInstance();
		public DeletePage ()
		{
            InitializeComponent();
           
            var myEmployees = realmDB.All<Employees>().ToList();
            LstDelete.ItemsSource = myEmployees;
            
		}


        private async void LstDelete_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedEmployee = (Employees)e.SelectedItem;
            var lv = (ListView)sender;

            await Navigation.PushPopupAsync(new DeletePopUpPage(selectedEmployee.EmployeeId.ToString()));
            lv.SelectedItem = null;
        }
    }
}