using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNote.Datas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewSample2 : ContentPage
	{
        List<Users> myRealList = new List<Users>();
		public ListViewSample2 ()
		{
			InitializeComponent ();
            var myList = new List<Users>
            {
                new Users{Username="tarik",UserId="007",imageUrl="https://i.finansgundem.com/2/679/400//files/2019/8/18/1428970/1428970.jpg" },
                new Users{Username="deneme",UserId="009",imageUrl="https://i.finansgundem.com/2/679/400//files/2019/8/18/1428970/1428970.jpg" }
            };
            myListView.ItemsSource = myList;
            myRealList = myList;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            myRealList.Add(new Users { Username = "Ahmet", UserId = "00012", imageUrl = "https://i.finansgundem.com/2/679/400//files/2019/8/18/1428970/1428970.jpg" });
            myListView.ItemsSource = null;
            myListView.ItemsSource = myRealList;
        }

        private void OnDelete_Clicked(object sender, EventArgs e)
        {
            var myMenuItem = (MenuItem)sender;
            var UserID = myMenuItem.CommandParameter.ToString();
            myRealList.RemoveAll(r => r.UserId == UserID);
            myListView.ItemsSource = null;
            myListView.ItemsSource = myRealList;
        }

        private async void MyListView_Refreshing(object sender, EventArgs e)
        {
            myListView.IsRefreshing = true;
            await Task.Delay(4000);
            myListView.IsRefreshing = false;
        }
    }
}