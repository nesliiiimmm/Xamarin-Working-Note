using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XamarinElementPage : ContentPage
	{
		public XamarinElementPage ()
		{
			InitializeComponent ();
		}

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            myEntry.Text = "Welcome to XamarinForms:)";
            myLabel.Text = "Welcome to XamarinForms too :):)";
            mySlider.Value = 0.50;
            myDatapicker.Date = new DateTime(2017, 7, 18);
            myTimePicker.Time = new TimeSpan(4, 45, 34);
            mySwitch.IsToggled = true;
            myButton.Text = "OMG you pushed me !!!";

            var myList = new List<string>();
            myList.Add("First Item");
            myList.Add("Second Item");
            myList.Add("Third Item");
            myList.Add("Forth Item");

            myPicker.ItemsSource = myList;
        }

        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            myEntry.Text = myPicker.SelectedItem.ToString();
        }
    }
}