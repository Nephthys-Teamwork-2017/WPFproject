using Data;
using Models;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication2.Pages.Clients
{
    public partial class AddClientPage : Page
    {
        public AddClientPage()
        {
            InitializeComponent();
        }

      

        private void AddClientButtonClick(object sender, RoutedEventArgs e)
        {
            using (var context = new BrokerDbContext())
            {
                Customer customer = new Customer()
                {
                    Name = NameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Email = EmailTextBox.Text,
                    Notes = NotesTextBox.Text,
                    StatePersonalNumber = PersonalNumberTextBox.Text

                };

                context.Customers.Add(customer);
                context.SaveChanges();

                MessageBox.Show("new Client Added!");
            }
        }
    }
}



