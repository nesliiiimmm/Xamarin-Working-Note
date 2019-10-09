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
	public partial class CSharpDesignPage : ContentPage
	{
		public CSharpDesignPage ()
		{
			InitializeComponent ();

            var myButton = new Button
            {
                Text = "Push Me..",
                TextColor = Color.AliceBlue,
                BackgroundColor=Color.Bisque
            };
            var stacklay = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            //stacklay.Children.Add(myButton);  I dont know why is not working....
           // Content = stacklay;
            
		}
	}
}