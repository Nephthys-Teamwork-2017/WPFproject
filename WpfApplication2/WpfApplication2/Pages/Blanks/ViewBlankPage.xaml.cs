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

namespace WpfApplication2.Pages.Blanks
{
    /// <summary>
    /// Interaction logic for ViewBlankPage.xaml
    /// </summary>
    public partial class ViewBlankPage : Page
    {
        public ViewBlankPage()
        {
            InitializeComponent();
            blankDTODataGrid.ItemsSource = BlankStore.GetAllBlanks();

        }
    }
}
