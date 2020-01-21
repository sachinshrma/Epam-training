using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamMarketConsole
{
    class Cart
    {
        private List<ProductModel> ProductsInCart;
        private double cartPrice;

        public Cart()
        {
            ProductsInCart = new List<ProductModel>();
            cartPrice = 0;
        }
        public void AddProduct(ProductModel product)
        {
            ProductsInCart.Add(product);
            cartPrice += product.Price;
        }
        public List<ProductModel> GetProductsInCart() { return ProductsInCart; }
    }
}
