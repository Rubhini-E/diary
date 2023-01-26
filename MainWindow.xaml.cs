using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Resources;

namespace loginUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtmail.Text;
            string password = txtpsd.Password;

            properties.Settings1 settings = new properties.Settings1();
            if ((email == settings.email) && (password == settings.password))
            {
                Window1 up = new Window1();
                up.lblcontent.Content = $"{txtmail.Text}";
                up.lblname.Content= $"{txtname.Text}";
                up.Show();
                this.Close();
            }
            else
            {
                ResourceManager rm = new ResourceManager("loginUI.properties.Resource1", Assembly.GetExecutingAssembly());
                MessageBox.Show(rm.GetString("text1"), "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text;
            string mail = txtmail1.Text;
            string password = txtpsd1.Password;
            

            properties.Settings1 settings = new properties.Settings1();
            settings.name = txtname.Text;
            settings.email = txtmail1.Text;
            settings.password = txtpsd1.Password.ToString();
            settings.Save();

            ResourceManager rm = new ResourceManager("loginUI.properties.Resource1", Assembly.GetExecutingAssembly());

            if ((txtname.Text != "") && (txtmail1.Text != "") && (txtpsd1.Password != ""))
            {

                MessageBox.Show(rm.GetString("text2"), "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
                // MessageBox.Show("REGISTERED SUCCESSFULLY","REGISTER" ,MessageBoxButton.OK, MessageBoxImage.Information);
                txtname.Clear();
                txtmail1.Clear();
                txtpsd1.Clear();
            }
            else
            {
                MessageBox.Show(rm.GetString("text3"), "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                //MessageBox.Show("ERROR!!!!!ENTER ALL DETAILS","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
