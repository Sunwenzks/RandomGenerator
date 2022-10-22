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

namespace RandomGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int minValue, maxValue;
            if (!int.TryParse(min.Text, out minValue))
            {
                MessageBox.Show("Min не число");
                return;
            }

            if (!int.TryParse(max.Text, out maxValue))
            {
                MessageBox.Show("Max не число");
                return;
            }
 
            var random = new Random();
            var sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += random.Next(minValue, maxValue);
            }

            MessageBox.Show((sum / 3).ToString());
        }
    }
}
