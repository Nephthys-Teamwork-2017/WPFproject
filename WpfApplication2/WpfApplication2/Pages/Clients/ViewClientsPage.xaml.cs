using Data;
using Data.DTO;
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

namespace WpfApplication2.Pages.Clients
{
    /// <summary>
    /// Interaction logic for ViewClientsPage.xaml
    /// </summary>
    /// 
   
    public partial class ViewClientsPage : Page
    {
        bool isInsert = false;
        bool isEdit = false;
        BrokerDbContext context = new BrokerDbContext();
        public ViewClientsPage()
        {
            InitializeComponent();
            customerDTODataGrid.ItemsSource = CustomerStore.GetAllCustomers();
        }


        private void CustomerDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            isInsert = true;
        }

        private void CustomerDataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            isEdit = true;
        }


        private void CustomerDataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && !isEdit)
            {
                var grid = (DataGrid)sender;
                if (grid.SelectedItems.Count > 0)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this customer?", "Deleting Records", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

                    if (result == MessageBoxResult.Yes)
                    {
                        foreach (var row in grid.SelectedItems)
                        {
                            CustomerDTO customer = row as CustomerDTO;
                            var cust= context.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
                            cust.IsDeleted = true;
                        }
                        context.SaveChanges();
                        MessageBox.Show("Customer deleted sucessfully.", "Delete Customer", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                        customerDTODataGrid.ItemsSource = CustomerStore.GetAllCustomers();
                }
            }
        }

        private void CustomerDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Customer cust;

            CustomerDTO c = e.Row.DataContext as CustomerDTO;

            if (c != null)
            {
                if (c.Id > 0)
                {
                    isInsert = false;
                }
                else
                {
                    isInsert = true;
                }
            }

            if (!isInsert)
            {
                var InsertRecord = MessageBox.Show("Do you want to Update " + c.Name + "?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (InsertRecord == MessageBoxResult.Yes)
                {
                    cust = context.Customers.Where(x => x.Id == c.Id).FirstOrDefault();
                    cust.Email = c.Email;
                    cust.Address = c.Address;
                    cust.Name = c.Name;
                    cust.Phone = c.Name;
                    cust.Notes = c.Notes;

                    context.SaveChanges();

                    customerDTODataGrid.ItemsSource = CustomerStore.GetAllCustomers();
                }
                else
                    customerDTODataGrid.ItemsSource = CustomerStore.GetAllCustomers();
            }

        }


    }
}
