using Data;
using Models;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static List<Customer> CustomerList = new List<Customer>();
        public MainWindow()
        {
            InitializeComponent();
            //Page1 p = new Page1();
            //frame.NavigationService.Navigate(p);

            using (var context = new BrokerDbContext())
            {
                CustomerList = context.Customers.ToList();
            }

        }

       

        private void mnuNewClient(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            frame.NavigationService.Navigate(p1);
        }

        private void mnuViewClient(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2();
            frame.NavigationService.Navigate(p2);
        }

        private void mnuNewPolicy(object sender, RoutedEventArgs e)
        {
            PolicyPage policyPage = new PolicyPage();
            frame.NavigationService.Navigate(policyPage);
        }

    }
}
