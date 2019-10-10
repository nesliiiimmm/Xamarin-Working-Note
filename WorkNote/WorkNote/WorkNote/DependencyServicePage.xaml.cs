using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNote.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DependencyServicePage : ContentPage
    {
        public DependencyServicePage()
        {
            InitializeComponent();
        }

        private void KillMe_Clicked(object sender, EventArgs e)
        {
            var appcloser = DependencyService.Get<ICloseApplication>();
            appcloser.CloseApplication();
        }
    }
}