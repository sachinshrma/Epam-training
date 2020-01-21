using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamMarketConsole
{
    class Category
    {
        private string name;
        private List<ProductModel> categoryProducts;

        public Category(string name)
        {
            this.Name = name;
        }
        public Category(string name,List<ProductModel> categoryProducts)
        {
            this.Name = name;
            this.CategoryProducts = categoryProducts;
        }

        public string Name { get => name; set => name = value; }
        public List<ProductModel> CategoryProducts { get => categoryProducts; set => categoryProducts = value; }
    }
}
