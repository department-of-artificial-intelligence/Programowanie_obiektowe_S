using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Lab8.BLL
{
    public class GradesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is List<Grade> grades)
            {
                var gradeStringList = new List<string>();
                foreach(var grade in grades)
                {
                    gradeStringList.Add(grade.Subject + ": " + grade.Value);
                }
                return string.Join("; ", gradeStringList);
            }
            return null!;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string stringValue)
            {
                var gradeArray = stringValue.Split(';');
                var gradeList = new List<Grade>();
                foreach(var gradeString in gradeArray)
                {
                    var subjectValueArray = gradeString.Trim().Split(':');

                    if (decimal.TryParse(subjectValueArray[1].Trim().ToLower(), out decimal gradeValue))
                    {
                        gradeList.Add(new Grade(subjectValueArray[0].Trim(), gradeValue));
                    }
                }
                return gradeList;
            }
            return null!;
        }
    }
}
