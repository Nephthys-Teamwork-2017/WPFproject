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
using Models;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for BlanksPage.xaml
    /// </summary>
    public partial class BlanksPage : Page
    {

        public static List<Blank> BlankList = new List<Blank>();
        public BlanksPage()
        {
            InitializeComponent();


            using (var context = new BrokerDbContext())
            {
                BlankList = context.Blanks.ToList();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new BrokerDbContext())
            {
                Blank blank = new Blank()
                {
                   Number = textBox.Text,
                   Status = textBox3.Text,
                   TakenDate = DateTime.Now,
                   

                };

                context.Blanks.Add(blank);
                context.SaveChanges();

                MessageBox.Show("Blank Added!");
            }
        }

        private void mnuNewBlank(object sender, RoutedEventArgs e)
        {
            //Page1 p1 = new Page1();
           
        }

        private void mnuViewBlanks(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2();
           
        }

        private void mnuNewPolicy(object sender, RoutedEventArgs e)
        {
            PolicyPage policyPage = new PolicyPage();
            
        }

    }
}
