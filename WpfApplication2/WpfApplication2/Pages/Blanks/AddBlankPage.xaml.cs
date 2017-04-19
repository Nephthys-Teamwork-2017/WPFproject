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

namespace WpfApplication2.Pages.Blanks
{
    /// <summary>
    /// Interaction logic for AddBlankPage.xaml
    /// </summary>
    public partial class AddBlankPage : Page
    {
        public AddBlankPage()
        {
            InitializeComponent();

            CompanyComboBox.ItemsSource = CompanyStore.GetAllCompanies().Select(x => x.Name);

            AgentComboBox.ItemsSource = AgentStore.GetAllAgents().Select(x => x.Name);

            PolicyNumberTextBox.ItemsSource = PolicyStore.GetAllPolicyNumbers();

            List<string> listStatus = new List<string>();

            listStatus.Add("Аvailable");
            listStatus.Add("Used");
            listStatus.Add("Cancelled");

            StatusComboBox.ItemsSource = listStatus;
        }

        private void LoadProducts(object sender, SelectionChangedEventArgs e)
        {
            string company = CompanyComboBox.SelectedValue.ToString();

            ProductComboBox.ItemsSource = ProductStore.getAllProductsByCompany(company).Select(x => x.Name);
        }

        private void AddBlankButton_Click(object sender, RoutedEventArgs e)
        {
            Blank blank = new Blank()
            {
                 AgentId= AgentStore.GetAgentId(AgentComboBox.SelectedValue.ToString()),
                 CompanyId= CompanyStore.GetCompanyId(CompanyComboBox.SelectedValue.ToString()),
                 ProductId=ProductStore.getProductIdByName(ProductComboBox.SelectedValue.ToString()),
                 Number=PolicyNumberTextBox.Text,
                 IssueDate=DateTime.Parse(IssueDatePicker.Text),
                 TakenDate=DateTime.Parse(TakenDatePicker.Text),
                 Status = (StatusB)StatusComboBox.SelectedIndex,
                 PolicyId = PolicyStore.GetAllPolicyIdByNumber(PolicyNumberTextBox.Text)

            };

            bool result = BlankStore.AddBlank(blank);

            if (result == true)
                MessageBox.Show("Blank Added!");
        }
    }
}
