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
		public ListViewSample2 ()
		{
			InitializeComponent ();
            var myList = new List<Users>
            {
                new Users{Username="tarik",UserId="007",imageUrl="https://i.finansgundem.com/2/679/400//files/2019/8/18/1428970/1428970.jpg" },
                new Users{Username="deneme",UserId="009",imageUrl="https://i.finansgundem.com/2/679/400//files/2019/8/18/1428970/1428970.jpg" }
            };
            myListView.ItemsSource = myList;
        }
	}
}