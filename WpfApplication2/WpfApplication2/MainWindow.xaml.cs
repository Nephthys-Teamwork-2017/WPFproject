using Data;
using Data.AutoMapperConfiguration;
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
using WpfApplication2;
using WpfApplication2.Pages.Companies;
using WpfApplication2.Pages.Due_Date_Report;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        public MainWindow()
        {

            AutoMapperConfiguration.Configure();

            InitializeComponent();
           

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

        private void mnuSearchByName(object sender, RoutedEventArgs e)
        {
            ClientNameSearchExample searchClientPage = new ClientNameSearchExample();
            frame.NavigationService.Navigate(searchClientPage);
        }
       

        private void mnuDueDateReport(object sender, RoutedEventArgs e)
        {
            DueDateReportPage report = new DueDateReportPage();
            frame.NavigationService.Navigate(report);
        }

        private void mnuAddNewCompany(object sender, RoutedEventArgs e)
        {
            AddCompanyPage page = new AddCompanyPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuViewCompanies(object sender, RoutedEventArgs e)
        {
            ViewCompanyPage page = new ViewCompanyPage();
            frame.NavigationService.Navigate(page);
        }



        private void InitDB(object sender, RoutedEventArgs e)
        {
            using (var context = new BrokerDbContext())
            {
                context.Database.Initialize(true);
                MessageBoxResult result = MessageBox.Show("Database Initialized!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

            }

        }
    }
}

