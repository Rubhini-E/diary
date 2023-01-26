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
using System.IO;

namespace loginUI
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String file = System.IO.Path.Combine(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct1\", txtdate.Text + ".txt");
            String all = File.ReadAllText(file);

            txtcontent.Text = all;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtdate.Clear();
            txtcontent.Clear();
        }
    }
}
