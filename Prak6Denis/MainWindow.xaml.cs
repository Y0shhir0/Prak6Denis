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

namespace Prak6Denis
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

            double a = double.Parse(Vvod.Text);
            double b = double.Parse(Vod.Text);

            double maxValue = double.MinValue;
            double maxp = 0;

            for (double x=a; x<=b;x+=0.1)
            {
                double value = F(x);
                if (value>maxValue)
                {
                    maxValue = value;
                    maxp = x;
                }
            }
            Otvet.Text = $"Макс значение:{maxValue}\n" +
                $"Точка: {maxp}";
        }
        private double F(double x) 
        {
            return Math.Pow(x, 3) - Math.Sin(x);
        }
    }
}
