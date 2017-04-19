using Data;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for PolicyPage.xaml
    /// </summary>
    /// 
  
    public partial class PolicyPage : Page
    {
        public PolicyPage()
        {
            InitializeComponent();
            


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            using (var context = new BrokerDbContext())
            {
                Policy policy = new Policy()
                {
                    Number = "12",
                    ProductId = 1,
                    IssueDate = new DateTime(2001, 1, 1),
                    StartDate = new DateTime(1999, 2, 2),
                    EndDate = new DateTime(2007, 3, 3),
                    PolicyPremium = 1912.12m,
                    Tax = 1912,
                    Price = 1913,
                    InsuredId = 1,
                    CustomerId = 1,
                    AgentId = 1,
                    Notes = "tralala",
                    CompanyId = 1
=======
            //using (var context = new BrokerDbContext())
            //{
            //    Policy policy = new Policy()
            //    {
            //        Number = 12,
            //        ProductId = 1,
            //        IssueDate = new DateTime(2001, 1, 1),
            //        StartDate = new DateTime(1999, 2, 2),
            //        EndDate = new DateTime(2007, 3, 3),
            //        PolicyPremium = 1912.12m,
            //        Tax = 1912,
            //        Price = 1913,
            //        InsuredId = 1,
            //        CustomerId = 1,
            //        AgentId = 1,
            //        Notes = "tralala",
            //        CompanyId = 1
>>>>>>> fcda2c698a90b5c0a366e49a965fd6d2e7d20866


            //    };

            //    context.Policies.Add(policy);
            //    context.SaveChanges();

            //    MessageBox.Show("policy added");

            //}

        }
    }
}
