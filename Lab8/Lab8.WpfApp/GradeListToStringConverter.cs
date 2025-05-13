using System.Globalization;
using System.Windows.Data;

namespace Lab8.WpfApp
{
    public class GradeListToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<Grade> grades)
            {
                return string.Join(", ", grades.Select(g => g.GradeValue.ToString("0.0")));
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}