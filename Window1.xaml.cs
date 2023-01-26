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
using System.IO;

namespace loginUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Page1 opage1;
        Page2 opage2;
        Page3 opage3;
        Page4 opage4;
        public Window1()
        {
            InitializeComponent();
            opage1 = new Page1();
            opage2 = new Page2();
            opage3 = new Page3();
            opage4 = new Page4();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frmmain.Content = opage4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           MessageBoxResult res= MessageBox.Show("ARE YOU SURE?","LOGOUT",MessageBoxButton.OKCancel,MessageBoxImage.Question);

            if (res == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }

        }
    }
}
