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
        public void ProductRating(List<ProductReview> products)
        {
           // var result = products.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9));
            var record = from product in products where (product.ProductID == 1 || product.ProductID == 4 || product.ProductID == 9) && product.Rating > 3 select product;
            Console.WriteLine("Using LinQ:");
            foreach (var prod in record)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);

            }
            Console.WriteLine("-----------------------------");
            // Display(result);
        }
        //public void Display(IEnumerable<ProductReview> result)
        //{
        //    foreach (var prod in result)
        //    {
        //        Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);
        //    }
        //}
        public void CountProduct(List<ProductReview> products)
        {
            var record = products.GroupBy(x => x.ProductID).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("Using LinQ: ");            
            foreach (var prod in record)
            {
                Console.WriteLine(prod.ProductId + "  " + prod.Count);
            }
            Console.WriteLine("Using Lambda: ");
            var result = products.GroupBy(x => x.ProductID);
            foreach (var product in result)
            {
                Console.WriteLine(product.Key + " " + product.Count());
            }
        }
    }
}
