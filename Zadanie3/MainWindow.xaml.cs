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

namespace Zadanie3
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
            double c = double.Parse(Vodd.Text);



            Otvet.Text = $"{"Ответ:" + RootCount(a, b, c)}";
        }
        private int RootCount (double a, double b, double c)
        {
            double disc = b * b - 4 * a * c;
            if (disc <0 )
            {
                return 0;
            }
            else if (disc == 0)
            {
                return 1;

            }
            else
            {
                return 2;
            }

        }
    }
}
