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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            File.WriteAllText(@"C:\\Users\\rubhi\\OneDrive\\Documents\\fileprjct1\" + txtdate.Text + ".txt", "GROCERIES   :" + txtgro.Text + "\n"  + "MEDICAL  :" + txtmed.Text + "\n"  + "TUTION FEE  :" + txtfee.Text + "\n" + "LOAN  :" + txtloan.Text + "\n"  + "KIDS   :" + txtkids.Text + "\n" + "OTHERS  :" + txtothers.Text);
           MessageBoxResult res=  MessageBox.Show("Saved Successfully", "success", MessageBoxButton.OK, MessageBoxImage.Information);
            if (res == MessageBoxResult.OK)
            {
                txtdate.Clear();
                txtgro.Clear();
                txtmed.Clear();
                txtfee.Clear();
                txtkids.Clear();
                txtloan.Clear();
                txtothers.Clear();
            }

        }

    }
}
