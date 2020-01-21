using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamMarketConsole
{
    class View
    {
        private List<Category> categories;

        public View(List<Category> categories)
        {
            this.categories = categories;
        }

        public void ShowCategories()
        {
            Console.WriteLine("Categories");
            for(int i = 0; i < categories.Count; ++i)
            {
                Console.WriteLine(i + 1 + ". " + categories[i].Name);
            }
        }
        public void showProducts(int categoryIndex)
        {
            List<ProductModel> products = categories[categoryIndex - 1].CategoryProducts;
            for (int i = 0; i < products.Count; ++i)
            {
                Console.WriteLine(i + 1 + ". " + products[i].Name+" Price: "+products[i].Price);
            }
        }
    }
}
