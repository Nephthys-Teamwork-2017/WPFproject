using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WpfApplication2.Data;
using WpfApplication2.Models;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Client client = new Client()
                {
                    Name = textBox.Text,
                    Address = textBox1.Text,
                    Phone=textBox2.Text,
                    Email=textBox3.Text,
                    Notes=textBox4.Text,
                    StatePersonalNumber=textBox5.Text
                     
                };

                context.Clients.Add(client);
                context.SaveChanges();

                MessageBox.Show("new Client Added!");
            }
        }
    }
}
