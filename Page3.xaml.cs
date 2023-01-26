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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //File.ReadAllText(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct\" + txtdate.Text + ".txt");
            String file = System.IO.Path.Combine(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct\", txtdate.Text + ".txt");
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
