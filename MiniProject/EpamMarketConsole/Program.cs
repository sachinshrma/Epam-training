using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamMarketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductModel> mobileProducts = generateMobileProducts();
            Category mobiles = new Category("Mobiles/Tablets",mobileProducts);

            List<ProductModel> fashionProducts = generateFashionProducts();
            Category fashion = new Category("Fashion", mobileProducts);

            List<Category> categories = new List<Category>();
            categories.Add(mobiles);
            categories.Add(fashion);

            View view = new View(categories);
            view.ShowCategories();
            int response = int.Parse(Console.ReadLine());
            view.showProducts(response);

        }

        

        private static List<ProductModel> generateMobileProducts()
        {
            ProductModel product = new ProductModel("OnePlus 7t", "", 37999);
            ProductModel product2 = new ProductModel("Samsung A7s", "", 17999);
            ProductModel product3 = new ProductModel("Iphone XR", "", 49999);
            List<ProductModel> products = new List<ProductModel>();
            products.Add(product);
            products.Add(product2);
            products.Add(product3);

            return products;
        }

        private static List<ProductModel> generateFashionProducts()
        {
            ProductModel product = new ProductModel("Polo tshirt", "", 599);
            ProductModel product2 = new ProductModel("White shirt", "", 699);
            ProductModel product3 = new ProductModel("Blue denim", "", 1250);
            List<ProductModel> products = new List<ProductModel>();
            products.Add(product);
            products.Add(product2);
            products.Add(product3);

            return products;
        }
    }
}
