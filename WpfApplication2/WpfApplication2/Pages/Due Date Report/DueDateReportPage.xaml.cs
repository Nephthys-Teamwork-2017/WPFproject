using Data;
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

namespace WpfApplication2.Pages.Due_Date_Report
{
    /// <summary>
    /// Interaction logic for DueDateReportPage.xaml
    /// </summary>
    public partial class DueDateReportPage : Page
    {
        public DueDateReportPage()
        {
            InitializeComponent();

            using (var context = new BrokerDbContext())
            {
                dueDateReportDTODataGrid.ItemsSource = PaymentStore.DueDateReport(context);

            }

            
        }
    }
}
