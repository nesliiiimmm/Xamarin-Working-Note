﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkNote
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackLayout : ContentPage
	{
		public StackLayout ()
		{
			InitializeComponent ();
		}

        public object VerticalOptions { get; internal set; }
        public LayoutOptions HorizontalOptions { get; internal set; }
    }
}