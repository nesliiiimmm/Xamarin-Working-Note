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
	public partial class DeletePopUpPage : Rg.Plugins.Popup.Pages.PopupPage
	{
        string realEmployeeID;
        public DeletePopUpPage (string employeeId)
		{
			InitializeComponent ();
            realEmployeeID = employeeId;
        }

        private async void BtnDeleteCountry_Clicked(object sender, EventArgs e)
        {
            var realmDB = Realm.GetInstance();
            var selectedEmployee = realmDB.All<Employees>().First(s => s.EmployeeId == Convert.ToInt32(realEmployeeID));

            try
            {
                using (var db = realmDB.BeginWrite())
                {
                    realmDB.Remove(selectedEmployee);
                    db.Commit();
                }

                await DisplayAlert("Uyarı", "Db'den silindi", "tamam");
                await Navigation.PopPopupAsync();
            }
            catch (Exception)
            {

                await DisplayAlert("Uyarı", "Db'den silinemedi", "tamam");
            }
        }
    }
}