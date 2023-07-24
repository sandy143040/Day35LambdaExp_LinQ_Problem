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
        public void ProductId_Review(List<ProductReview> products)
        {
            Console.WriteLine("Using Lambda: ");
            var result = products.Select(x => new { x.ProductID, x.Review });
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductID + "  " + product.Review);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Using LinQ: ");
            var record = from product in products select new { product.ProductID, product.Review };
            foreach (var product in record)
            {
                Console.WriteLine(product.ProductID + "  " + product.Review);
            }
        }
        public void SkipTop_Record(List<ProductReview> products)
        {
            var records = (from product in products select product).Skip(5);
            Console.WriteLine("Using LinQ: ");
            foreach (var prod in records)
            {
                Console.WriteLine(prod.ProductID + "  " + prod.UserID + "  " + prod.Rating + "  " + prod.Review + "  " + prod.IsLike);
            }
            Console.WriteLine("Using Lambda: ");
            Console.WriteLine("-----------------------------");
            var result = products.OrderByDescending(x => x.Rating).Skip(5);
            foreach (var prod1 in result)
            {
                Console.WriteLine(prod1.ProductID + "  " + prod1.UserID + "  " + prod1.Rating + "  " + prod1.Review + "  " + prod1.IsLike);
            }
        }
        public void ProductId_Reviews(List<ProductReview> products)
        {
            Console.WriteLine("Using Lambda: ");
            var result = products.Select(x => new { x.ProductID, x.Review });
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductID + "  " + product.Review);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Using LinQ: ");
            var record = from product in products select new { product.ProductID, product.Review };
            foreach (var product in record)
            {
                Console.WriteLine(product.ProductID + "  " + product.Review);
            }
        }
    }
}
