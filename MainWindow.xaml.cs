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

namespace WpfApp83
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
            double p = double.Parse(Boxp.Text) / 100;
            double a = double.Parse(Boxa.Text);
            double s = 1000;
            int m = 0;
            while (s < a)
            {
                s += s * p;
                m++;
            }
            txtOtv.Text = $"Через {m} месяцев размер вклада будет равен {s} ₽";
        }
    }
}
