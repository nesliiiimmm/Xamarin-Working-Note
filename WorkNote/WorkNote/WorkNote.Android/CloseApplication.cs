using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using WorkNote.Helper;
using Xamarin.Forms.Platform.Android;
using WorkNote.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(CloseApplication))]

namespace WorkNote.Droid
{
    public class CloseApplication: ICloseApplication
    {
        void ICloseApplication.CloseApplication()
        {
            var Activity = (Activity)Forms.Context;
            Activity.Finish();
        }
    }
}