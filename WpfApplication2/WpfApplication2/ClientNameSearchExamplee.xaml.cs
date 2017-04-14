using Data;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for ClientNameSearchExample.xaml
    /// </summary>
    public partial class ClientNameSearchExample : Page
    {
        public ClientNameSearchExample()
        {
            InitializeComponent();
            using (var context = new BrokerDbContext())

            {
                this.DataContext = context.Customers.ToList();

            }



        }

        private void DatePicker_SelectedDateChanged(object sender,
       SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(AutoCompleteName.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DatePicker.SelectedDate.ToString());
        }
    }
}
