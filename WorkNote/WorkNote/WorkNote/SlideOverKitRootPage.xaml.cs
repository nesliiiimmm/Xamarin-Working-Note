using SlideOverKit;
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
    public partial class SlideOverKitRootPage : MenuContainerPage
    {
        public SlideOverKitRootPage()
        {
            InitializeComponent();

            Onay.Clicked += (sender, e) =>
            {

                this.ShowMenu();

            };

            this.SlideMenu = new SlideMenuView()
            {

            };
        }
    }
}