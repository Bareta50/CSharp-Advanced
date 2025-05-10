using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class06.Helper
{
    public static class ProductExtentions
    {
        public static double GetTotalPrice(this Product product, int quantity)
        {
         product.Price = product.Price * quantity;
            return product.Price;
        }
    }
}
