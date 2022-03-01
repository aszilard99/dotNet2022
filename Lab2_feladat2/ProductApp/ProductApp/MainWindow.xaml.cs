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

namespace ProductApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
            products.Add(new Product { AnnualSales = 1230, Material = MaterialType.Granules, PackageType = "glass", ProductId = "89", ProductName = "Wine", Quantity = 5192 });
            products.Add(new Product { AnnualSales = 54350, Material = MaterialType.Granules, PackageType = "paper", ProductId = "1", ProductName = "Tobacco", Quantity = 15491 });
            products.Add(new Product { AnnualSales = 12340, Material = MaterialType.Granules, PackageType = "plastic", ProductId = "39", ProductName = "Chocolate", Quantity = 25396 });
            products.Add(new Product { AnnualSales = 567510, Material = MaterialType.Granules, PackageType = "paper", ProductId = "679", ProductName = "Bread", Quantity = 115193 });
            products.Add(new Product { AnnualSales = 88850, Material = MaterialType.Granules, PackageType = "glass", ProductId = "21", ProductName = "Beer", Quantity = 39192 });
            ProductListView.ItemsSource = products;
        }
    }
}
