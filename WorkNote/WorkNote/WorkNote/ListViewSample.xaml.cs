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
	public partial class ListViewSample : ContentPage
	{
		public ListViewSample ()
		{
			InitializeComponent ();

            //var myList = new List<string> {"Tarik","Murat","Ersin" };
            var myList = new List<Users>
            {
                new Users{Username="tarik",UserId="007",imageUrl="https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwi5_v7aqezkAhXC_aQKHXDyDhMQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.shutterstock.com%2Fcategory%2Fnature&psig=AOvVaw01-EsKVS4nOWIBQIOEcqZC&ust=1569513003898077" },
                new Users{Username="deneme",UserId="009",imageUrl="https://i.finansgundem.com/2/679/400//files/2019/8/18/1428970/1428970.jpg" }
            };
            myListView.ItemsSource = myList;
		}
	}
}