using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp_Linq
{
    public class Management
    {
        public void TopRecord(List<ProductReview> products)
        {            
            var record = (from product in products orderby product.Review descending select product).Take(3);

            Console.WriteLine("Using LinQ:");
            foreach (var prod in record)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);
            }
            Console.WriteLine("----------------");
            var result = products.OrderByDescending(x => x.Rating).Take(3);
            Console.WriteLine("Using Lambda:");
            foreach(var prod in result)
            {
                Console.WriteLine(prod.ProductID + " " + prod.UserID + " " + prod.Rating + " " + prod.Review + "  " + prod.IsLike);
            }
        }
    }
}
