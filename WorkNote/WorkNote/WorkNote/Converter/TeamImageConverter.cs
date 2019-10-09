using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace WorkNote.Converter
{
    public class TeamImageConverter : IValueConverter
    {
        public string fenerbahce { get; set; }
        public string galatasaray { get; set; }
        public string besiktas { get; set; }
        public string trabzonspor { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string teamName = (string)value;
            if (teamName== "Beşiktaş")
            {
                return besiktas;
            }
            else if (teamName == "Fenerbahçe")
            {
                return fenerbahce;
            }
            else if (teamName == "GalataSaray")
            {
                return galatasaray;
            }
            else if (teamName == "TrabzonSpor")
            {
                return trabzonspor;
            }
            else
            {
                return "Bonboşşş";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
