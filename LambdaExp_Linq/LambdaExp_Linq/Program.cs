﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExp_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ ProductID = 1,UserID = 1, Rating=5, Review="Average",IsLike=true},
                new ProductReview(){ ProductID = 2,UserID = 2, Rating=6, Review="Average",IsLike=true},
                new ProductReview(){ ProductID = 3,UserID = 3, Rating=3, Review="Bad",IsLike=false},
                new ProductReview(){ ProductID = 4,UserID = 4, Rating=8, Review="Good",IsLike=true},
                new ProductReview(){ ProductID = 5,UserID = 5, Rating=2, Review="Bad",IsLike=false},
                new ProductReview(){ ProductID = 6,UserID = 6, Rating=1, Review="Bad",IsLike=false},
                new ProductReview(){ ProductID = 7,UserID = 7, Rating=10, Review="VeryGood",IsLike=true},
                new ProductReview(){ ProductID = 8,UserID = 8, Rating=7, Review="Nice",IsLike=true},
                new ProductReview(){ ProductID = 9,UserID = 9, Rating=5, Review="Average",IsLike=false},
                new ProductReview(){ ProductID = 10,UserID = 10, Rating=4, Review="Average",IsLike=false},
                new ProductReview(){ ProductID = 11,UserID = 11, Rating=9, Review="Good",IsLike=true},
                new ProductReview(){ ProductID = 12,UserID = 12, Rating=1, Review="Bad",IsLike=false},
                new ProductReview(){ ProductID = 1,UserID = 13, Rating=3, Review="Bad",IsLike=false},
                new ProductReview(){ ProductID = 14,UserID = 14, Rating=9, Review="Good",IsLike=true},
                new ProductReview(){ ProductID = 15,UserID = 15, Rating=6, Review="Nice",IsLike=true},
                new ProductReview(){ ProductID = 16,UserID = 16, Rating=10, Review="VeryGood",IsLike=false},
                new ProductReview(){ ProductID = 17,UserID = 17, Rating=4, Review="Bad",IsLike=true},
                new ProductReview(){ ProductID = 18,UserID = 18, Rating=6, Review="Nice",IsLike=false},
                new ProductReview(){ ProductID = 19,UserID = 19, Rating=8, Review="Good",IsLike=false},
                new ProductReview(){ ProductID = 20,UserID = 20, Rating=2, Review="Bad",IsLike=true},
                new ProductReview(){ ProductID = 21,UserID = 21, Rating=1, Review="Bad",IsLike=false},
                new ProductReview(){ ProductID = 6,UserID = 22, Rating=9, Review="Good",IsLike=true},
                new ProductReview(){ ProductID = 4,UserID = 23, Rating=5, Review="Average",IsLike=false},
                new ProductReview(){ ProductID = 17,UserID = 24, Rating=10, Review="VeryGood",IsLike=false},
                new ProductReview(){ ProductID = 6,UserID = 25, Rating=6, Review="Nice",IsLike=false},

            };
            while(true)
            {
                Console.WriteLine("Please choose a option: ");
                Console.WriteLine("1.Top 3 Ratings");
                Console.WriteLine("2.Ratings greater than 3 by ProductID");
                Console.WriteLine("3.Count for each ProductID");
                Console.WriteLine("4.Retrieve only productId & Review from list");
                Console.WriteLine("5.Skip Top 5 Records from List");
                Console.WriteLine("6.Retrieve only productId & Review from lis");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        management.TopRecord(list);
                        Console.WriteLine("-----------------------------");
                        break;
                    case 2:
                        management.ProductRating(list);                       
                        break;
                    case 3:
                        management.CountProduct(list);
                        Console.WriteLine("-----------------------------");
                        break;
                    case 4:
                        management.ProductId_Review(list);
                        Console.WriteLine("-----------------------------");
                        break;
                    case 5:
                        management.SkipTop_Record(list);
                        Console.WriteLine("-----------------------------");
                        break;
                    case 6:
                        management.ProductId_Reviews(list);
                        Console.WriteLine("-----------------------------");
                        break;
                }
            }
        }
    }
}
