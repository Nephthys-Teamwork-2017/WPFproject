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
using Data.DTO;

namespace WpfApplication2.Pages.Due_Date_Report
{
    /// <summary>
    /// Interaction logic for AgentsByPolicyCount.xaml
    /// </summary>
    public partial class AgentsByPolicyCount : Page
    {
        private BrokerDbContext context = new BrokerDbContext();
        public AgentsByPolicyCount()
        {
            InitializeComponent();
            List<AgentsByPoliciesDTO> output = new List<AgentsByPoliciesDTO>();
            foreach (var agent in context.Agents)
            {
                AgentsByPoliciesDTO dto = new AgentsByPoliciesDTO(context, agent);
                output.Add(dto);
            }

            agentsByPoliciesDTODataGrid.ItemsSource = output;
        }
    }
}
