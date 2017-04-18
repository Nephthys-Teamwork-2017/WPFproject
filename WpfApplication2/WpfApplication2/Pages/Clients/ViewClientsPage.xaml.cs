using Data.Store;
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
    public partial class ViewClientsPage : Page
    {
        public ViewClientsPage()
        {
            InitializeComponent();
            customerDTODataGrid.ItemsSource = CustomerStore.GetAllCustomers();
        }
    }
}
