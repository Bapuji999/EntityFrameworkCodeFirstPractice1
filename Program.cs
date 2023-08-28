using EntityFramworkPracticeCodeFirstAproch1.Data;
using EntityFramworkPracticeCodeFirstAproch1.Models;
using System;

namespace EntityFrameWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DemoContext demoContext = new DemoContext();

            //Add New record

            Product shirt = new Product()
            {
                Name = "Polo T-shirt",
                price = 100
            };

            demoContext.Product.Add(shirt);

            Product jeans = new Product()
            {
                Name = "Lavies Jeans",
                price = 200
            };
            demoContext.Add(jeans);
            demoContext.SaveChanges();

            //Update record
            var tShirt = demoContext.Product.FirstOrDefault(product => product.Name == "Polo T-shirt");
            if(tShirt != null)
            {
                tShirt.price = 250;
            }
            demoContext.SaveChanges();

            //Delete record
            var pant = demoContext.Product.FirstOrDefault(product => product.Name == "Lavies Jeans");
            if (pant != null)
            {
                demoContext.Remove(pant);
            }
            demoContext.SaveChanges();

            //Read record
            var products = demoContext.Product.Where(product => product.price > 150).OrderBy(product => product.Name);
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.price}");
            }

        }
    }
}