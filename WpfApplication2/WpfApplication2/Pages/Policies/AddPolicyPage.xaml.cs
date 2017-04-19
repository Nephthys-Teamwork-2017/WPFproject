using Data;
using Data.Store;
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

namespace WpfApplication2.Pages.Policies
{
    /// <summary>
    /// Interaction logic for AddPolicyPage.xaml
    /// </summary>
    /// 
    public class ComboBoxPairs
    {
        public string _Key { get; set; }
        public string _Value { get; set; }

        public ComboBoxPairs(string _key, string _value)
        {
            _Key = _key;
            _Value = _value;
        }


    }



    public partial class AddPolicyPage : Page
    {
        public AddPolicyPage()
        {

            InitializeComponent();


            CompaniesComboBox.ItemsSource = CompanyStore.GetAllCompanies().Select(x => x.Name);

            
            List<string> listStatus = new List<string>();
            
            listStatus.Add("Active");
            listStatus.Add("Inactive");
            listStatus.Add("Cancelled");
            
            StatusComboBox.ItemsSource = listStatus;

            InsuredName.ItemsSource = CustomerStore.GetAllCustomers();

            EGNClientName.ItemsSource = CustomerStore.GetAllCustomers().Select(x => x.StatePersonalNumber);

            AgentComboBox.ItemsSource = AgentStore.GetAllAgents().Select(x => x.Name);
        }

        private void LoadProducts(object sender, SelectionChangedEventArgs e)
        {
            string company = CompaniesComboBox.SelectedValue.ToString();

            ProductsComboBox.ItemsSource = ProductStore.getAllProductsByCompany(company).Select(x => x.Name);



        }

        private void AddPolicyButton_Click(object sender, RoutedEventArgs e)
        {
            string companyName = CompaniesComboBox.SelectedValue.ToString();

            string AgentName = AgentComboBox.SelectedValue.ToString();

            string CustomerPersonalNumber = EGNClientName.Text;

            string InsuredPerson = InsuredName.Text;

            string productName = ProductsComboBox.SelectedValue.ToString();

            using (var context = new BrokerDbContext())
            {
                int companyId = context.Companies.Where(x => x.Name == companyName).FirstOrDefault().Id;

                int agentId = context.Agents.Where(x => x.Name == AgentName).FirstOrDefault().Id;

                int customerId = context.Customers.Where(x => x.StatePersonalNumber == CustomerPersonalNumber).FirstOrDefault().Id;

                int insuredId=context.Customers.Where(x => x.Name == InsuredPerson).FirstOrDefault().Id;

                int productId = context.Products.Where(x => x.Name == productName).FirstOrDefault().Id;

                Policy policy = new Policy()
                {
                    Number = PolicyNumberTextBox.Text,
                    ProductId = productId,
                    IssueDate = DateTime.Parse(issueDatePicker.Text),
                    StartDate = DateTime.Parse(startDatePicker.Text),
                    EndDate =   DateTime.Parse(endDatePicker.Text),
                    PolicyPremium = decimal.Parse(PremiumTextBox.Text),
                    Tax = decimal.Parse(TaxTextBox.Text),
                    Price = int.Parse(PriceTextBox.Text),
                    InsuredId = insuredId,
                    CustomerId =customerId,
                    AgentId = agentId,
                    Notes = NotesTextBox.Text,
                    CompanyId = companyId,
                    Status=(Status)StatusComboBox.SelectedIndex
                };

                bool result=PolicyStore.AddPolicy(policy);

                if (result == true)
                    MessageBox.Show($"Policy Added!");

            }


        }
    }
}
