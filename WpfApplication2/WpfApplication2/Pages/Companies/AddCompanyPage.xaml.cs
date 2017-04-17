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

namespace WpfApplication2.Pages.Companies
{
    /// <summary>
    /// Interaction logic for AddCompanyPage.xaml
    /// </summary>
    public partial class AddCompanyPage : Page
    {
        public AddCompanyPage()
        {
            InitializeComponent();
            
        }

        private void AddCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new BrokerDbContext())
            {
                Company company = new Company() { Address = AddressTextBox.Text, Email = EmailTextBox.Text, Name = NameTextBox.Text, Notes = NotesTextBox.Text, Phone = PhoneTextBox.Text };

                bool result= CompanyStore.AddCompany(context,company);
                if (result == true)
                    MessageBox.Show($"{NameTextBox.Text} Company Added");
                
            }
        }
    }
}
