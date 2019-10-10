using Realms;
using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNote.Datas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote.RealmDBProjectPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpdatePopUpPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        string realEmployeeID;
		public UpdatePopUpPage (string employeeID)
		{
			InitializeComponent ();
            realEmployeeID = employeeID;
		}

        private async void BtnUpdateCountry_Clicked(object sender, EventArgs e)
        {
            var realmDB = Realm.GetInstance();
            var selectedEmployee = realmDB.All<Employees>().First(s => s.EmployeeId == Convert.ToInt32(realEmployeeID));

            try
            {
                using (var db = realmDB.BeginWrite())
                {
                    selectedEmployee.EmployeeCountry = updateCountry.Text;
                    db.Commit();
                }
                await DisplayAlert("Uyarı", "Db'ye yazıldı", "tamam");
                await Navigation.PopAllPopupAsync();

            }
            catch (Exception)
            {

                await DisplayAlert("Uyarı","Db'ye yazılamadı","tamam");
            }

           
        }
    }
}