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
using System.Windows.Shapes;

namespace _313616_Sales
{
    /// <summary>
    /// Interaction logic for MonthPicker.xaml
    /// </summary>
    public partial class MonthPicker : Window
    {
        public MonthPicker()
        {
            InitializeComponent();
            string[] Months = new string[12] {"January,1", "February,2", "March,3", "April,4", "May,5", "June,6", "July,7", "August,8", "Spetember,9", "October,10","November,11", "December,12" };
            for (int i = 0; i < Months.Length; i++)
            {
                Button btnMonth = new Button();
                btnMonth.Content = Months[i];
                btnMonth.Click += BtnMonth_Click;
                stackpanel.Children.Add(btnMonth);
            }
        }

        private void BtnMonth_Click(object sender, RoutedEventArgs e)
        {
            string[] tempValue = ((Button)sender).Content.ToString().Split(',');
            int.TryParse(tempValue[1], out MainWindow.monthValue);
            Close();
        }
    }
}
