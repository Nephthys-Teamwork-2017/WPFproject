using Data;
using Data.Store;
using Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication2.Pages.Products
{
    /// <summary>
    /// Interaction logic for AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();

            CompanyComboBox.ItemsSource = CompanyStore.GetAllCompanies().Select(x=>x.Name);
        
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            
            using (var context = new BrokerDbContext())
            {
                int companyId = context.Companies.Where(x => x.Name == CompanyComboBox.Text).FirstOrDefault().Id;


                Product product = new Product()
                {
                    Name = NameTextBox.Text,
                    Code = CodeTextBox.Text,

                };

                context.Products.Add(product);

                context.SaveChanges();


                CompanyProdCom cpc = new CompanyProdCom()
                {
                    Comission = decimal.Parse(ComissionTextBox.Text),
                    ProductId = context.Products.Where(x => x.Code == CodeTextBox.Text && x.Name == NameTextBox.Text).FirstOrDefault().Id,
                    CompanyId = companyId
                    

                };

                context.CompanyProdComs.Add(cpc);
                context.SaveChanges();

                MessageBox.Show($"{NameTextBox.Text} Added!");

            }


        }
    }
}
