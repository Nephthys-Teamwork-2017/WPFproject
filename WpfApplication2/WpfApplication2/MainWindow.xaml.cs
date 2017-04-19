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
using WpfApplication2.Pages.Agents;
using WpfApplication2.Pages.Clients;
using WpfApplication2.Pages.Companies;
using WpfApplication2.Pages.Due_Date_Report;
using WpfApplication2.Pages.Payments;
using WpfApplication2.Pages.Policies;
using WpfApplication2.Pages.Products;

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
            AddClientPage page = new AddClientPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuViewClient(object sender, RoutedEventArgs e)
        {
            ViewClientsPage page = new ViewClientsPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuNewPolicy(object sender, RoutedEventArgs e)
        {
            AddPolicyPage page = new AddPolicyPage();
            frame.NavigationService.Navigate(page);
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

        private void mnuAddNewAgent(object sender, RoutedEventArgs e)
        {
            AddAgentPage page = new AddAgentPage();
            frame.NavigationService.Navigate(page);
        }
        

        private void mnuAddNewProduct(object sender, RoutedEventArgs e)
        {
            AddProductPage page = new AddProductPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuAddPayment(object sender, RoutedEventArgs e)
        {
            AddPaymentPage page = new AddPaymentPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuViewPayment(object sender, RoutedEventArgs e)
        {
            ViewPaymentPage page = new ViewPaymentPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuViewProduct(object sender, RoutedEventArgs e)
        {
            ViewProductsPage page = new ViewProductsPage();
            frame.NavigationService.Navigate(page);
        }

        private void mnuViewAgents(object sender, RoutedEventArgs e)
        {
            ViewAgentsPage page = new ViewAgentsPage();
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

