using System;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace RestaurantManager.Extensions
{
    public class BooleanToColorConverter : IValueConverter
    {
        public Color TrueColor { get; set; }
        public Color FalseColor { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value ? TrueColor : FalseColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
