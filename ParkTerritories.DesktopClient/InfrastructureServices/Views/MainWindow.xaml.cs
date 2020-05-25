using ParkTerritories.DesktopClient.InfrastructureServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;


namespace ParkTerritories.DesktopClient
{
    public class MultiLineConverter2 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //обезаю название для красивого вывода
            int foundS1 = ((string)value).IndexOf("»") + 1;
            int foundS2 = ((string)value).Length;

            if (foundS1 != foundS2 && foundS1 >= 0)
            {
                value = ((string)value).Remove(foundS1, foundS2 - foundS1);
                foundS1 = ((string)value).Length;
                if (foundS1 < foundS2)
                {
                    value = value + "...";//обозначаю, что видно не всё название объекта
                    foundS1 = ((string)value).IndexOf("–") + 1;
                    foundS2 = ((string)value).IndexOf("«");
                    if (foundS1 != foundS2 && foundS1 >= 0)
                    {
                        value = ((string)value).Remove(foundS1, foundS2 - foundS1);
                    }
                }
            }
            // перенос строки 
            return ((string)value)?.Replace('–', '\n');
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((string)value)?.Replace('\n', '–');
        }

    }

    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;            
        }
    }
}
