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
	public partial class ValueConverterExamplePage : ContentPage
	{
		public ValueConverterExamplePage ()
		{
			InitializeComponent ();
            var mylist = new List<FootballTeams>
            {
                new FootballTeams{teamName="Fenerbahçe",goalCount="87"},
                new FootballTeams{teamName="GalataSaray",goalCount="88"},
                new FootballTeams{teamName="TrabzonSpor",goalCount="89"},
                new FootballTeams{teamName="Beşiktaş",goalCount="90"},
                new FootballTeams{teamName="Fenerbahçe",goalCount="91"},
                new FootballTeams{teamName="GalataSaray",goalCount="92"},
                new FootballTeams{teamName="TrabzonSpor",goalCount="93"},
                new FootballTeams{teamName="Beşiktaş",goalCount="94"}
            };
            LstValue.ItemsSource = mylist;


        }
	}
}