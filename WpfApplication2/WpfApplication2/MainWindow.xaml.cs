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
using WpfApplication2.Pages.Blanks;
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

       

        private void menu(object sender, RoutedEventArgs e)
        {
            object page;

            MenuItem mnu = (MenuItem)sender;
            var Name = mnu.Name;
            switch (Name)
            {
                case "AddNewClient":
                    page = new AddClientPage();
                    frame.NavigationService.Navigate(page);
                    break;
                case "ViewClients":
                    page = new ViewClientsPage();
                    frame.NavigationService.Navigate(page);
                    break;
                case "AddNewPolicy":
                    page = new AddPolicyPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "AddNewBlank":
                    page = new AddBlankPage();
                    frame.NavigationService.Navigate(page);
                    break;
                case "ViewBlanks":
                    page = new ViewBlankPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "AddNewAgent":
                    page = new AddAgentPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "ViewAgents":
                    page = new ViewAgentsPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "AddPayment":
                    page = new AddPaymentPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "ViewPayment":
                    page = new ViewPaymentPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "AddNewProduct":
                    page = new AddProductPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "ViewProducts":
                    page = new ViewProductsPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "AddNewCompany":
                    page = new AddCompanyPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "ViewCompanies":
                    page = new ViewCompanyPage();
                    frame.NavigationService.Navigate(page);
                    break;

                case "DueDateReport":
                    page = new DueDateReportPage();
                    frame.NavigationService.Navigate(page); ;
                    break;
                    //

                    //case "ViewIncomes":
                    //    page = new  ();
                    //    frame.NavigationService.Navigate(page);
                    //    break;
                    //
            }
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

