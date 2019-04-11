/* Peter McEwen
* April 11, 2019
*program shows specific months, and summary of business
*/
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
using System.Net;

namespace _313616_Sales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public int monthValue = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn2017_Checked(object sender, RoutedEventArgs e)
        {
            WebClient webclient = new WebClient();
            string download = webclient.DownloadString("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2017.txt");
            string[] Sales2017 = download.Split('\r');

            if (rbIsSum.IsChecked == true)
            {
                decimal[] MonthlySales = new decimal[12];
                decimal Total = 0;
                for (int i = 1; i <= 12; i++)
                {
                    decimal.TryParse(Sales2017[i], out MonthlySales[i - 1]);

                    Total += MonthlySales[i - 1];
                }

                decimal Average = Total / 12;
                decimal Max = MonthlySales.Max();
                decimal Min = MonthlySales.Min();

                lblOutput.Content = "Total Annual Sales:\t" + Total.ToString()
                    + "\nAverage Monthly Sales:\t" + Math.Round(Average, 2).ToString()
                    + "\nMaximum Monthly Sales:\t" + Max.ToString()
                    + "\nMinimum Monthly Sales:\t" + Min.ToString();
                rbIsSum.IsChecked = false;
            }

            else
            {
                MonthPicker MP = new MonthPicker();
                MP.ShowDialog();

                lblOutput.Content = Sales2017[monthValue];
            }
        }

        private void btn2018_Checked(object sender, RoutedEventArgs e)
        {
            WebClient webclient = new WebClient();
            string download = webclient.DownloadString("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2018.txt");
            string[] Sales2018 = download.Split('\r');

            if (rbIsSum.IsChecked == true)
            {
                decimal[] MonthlySales = new decimal[12];
                decimal Total = 0;
                for (int i = 1; i <= 12; i++)
                {
                    decimal.TryParse(Sales2018[i], out MonthlySales[i - 1]);

                    Total += MonthlySales[i - 1];
                }

                decimal Average = Total / 12;
                decimal Max = MonthlySales.Max();
                decimal Min = MonthlySales.Min();

                lblOutput.Content = "Total Annual Sales:\t" + Total.ToString()
                    + "\nAverage Monthly Sales:\t" + Math.Round(Average,2).ToString()
                    + "\nMaximum Monthly Sales:\t" + Max.ToString()
                    + "\nMinimum Monthly Sales:\t" + Min.ToString();
                rbIsSum.IsChecked = false;
            }

            else
            {
                MonthPicker MP = new MonthPicker();
                MP.ShowDialog();

                lblOutput.Content = Sales2018[monthValue];
            }
            
        }
    }
}
