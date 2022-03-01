using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public class Product
    {
        public int AnnualSales
        {
            get;set;
        }
        public MaterialType Material
        {
            get;set;
        }
        public string PackageType
        {
            get;set;
        }
        public string ProductId
        {
            get;set;
        }
        public string ProductName
        {
            get;set;
        }
        public int Quantity
        {
            get;set;
        }
    }
}
