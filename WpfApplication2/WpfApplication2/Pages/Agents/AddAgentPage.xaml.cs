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

namespace WpfApplication2.Pages.Agents
{
    /// <summary>
    /// Interaction logic for AddAgentPage.xaml
    /// </summary>
    public partial class AddAgentPage : Page
    {
        public AddAgentPage()
        {
            InitializeComponent();
        }

        private void AddAgentButton_Click(object sender, RoutedEventArgs e)
        {
            Agent agent = new Agent()
            {
               Code=CodeTextBox.Text,
               Email=EmailTextBox.Text,
               Name=NameTextBox.Text,
               Phone=PhoneTextBox.Text
            };

            using (var context = new BrokerDbContext())
            {
                bool result = AgentStore.AddAgent(context, agent);

                if (result == true)
                    MessageBox.Show($"{NameTextBox.Text} was added");
            }


        }
    }
}
