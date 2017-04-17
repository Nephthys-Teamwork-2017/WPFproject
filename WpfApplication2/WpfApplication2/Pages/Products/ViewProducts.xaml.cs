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
using Data;

namespace WpfApplication2.Pages.Products
{
    /// <summary>
    /// Interaction logic for ViewProducts.xaml
    /// </summary>
    public partial class ViewProducts : Page
    {
        private BrokerDbContext context = new BrokerDbContext();

        public ViewProducts()
        {
            InitializeComponent();
            productsDataGrid.ItemsSource = context.Products.ToList();
        }
    }
}
