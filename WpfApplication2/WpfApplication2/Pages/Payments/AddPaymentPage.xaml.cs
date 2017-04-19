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

namespace WpfApplication2.Pages.Payments
{
    /// <summary>
    /// Interaction logic for AddPaymentPage.xaml
    /// </summary>
    public partial class AddPaymentPage : Page
    {
         
        public AddPaymentPage()
        {
            InitializeComponent();

            

            CompanyComboBox.ItemsSource = CompanyStore.GetAllCompanies().Select(x=>x.Name);

            AgentComboBox.ItemsSource = AgentStore.GetAllAgents().Select(x => x.Name);

            PolicyNumberTextBox.ItemsSource = PolicyStore.GetAllPolicyNumbers();

            BlankNumberTextBox.ItemsSource = BlankStore.GetAllBlankNumbers();

        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                BlankNumberTextBox.IsEnabled = true;
            }
            else
                BlankNumberTextBox.IsEnabled = false;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int? blankId=null;
            if(checkBox.IsChecked==true)
            {
                blankId = BlankStore.GetBlankIdByNumber(BlankNumberTextBox.Text);
            }

            Payment payment = new Payment()
            {
                DateOfPayment = DateTime.Parse(DateOfPaymentPicker.Text),
                DueDate = DateTime.Parse(DueDatePicker.Text),
                AgentId= AgentStore.GetAgentId(AgentComboBox.SelectedValue.ToString()),
                CompanyId=CompanyStore.GetCompanyId(CompanyComboBox.SelectedValue.ToString()),
                PolicyId=PolicyStore.GetAllPolicyIdByNumber(PolicyNumberTextBox.Text),
                FinalPrice=decimal.Parse(FinalPriceTextBox.Text),
                Premium=decimal.Parse(PremiumTextBox.Text),
                Price=decimal.Parse(PriceTextBox.Text),
                Tax=decimal.Parse(TaxTextBox.Text),
                Status=StatusTextBox.Text,
                BlankId=blankId
                
            };

            bool result=PaymentStore.AddPayment(payment);

            if (result == true)
                MessageBox.Show("Payment Added!");


        }
    }
}
