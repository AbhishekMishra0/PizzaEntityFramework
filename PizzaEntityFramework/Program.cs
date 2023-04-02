using PizzaEntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaContext context = new PizzaContext();
            context.Products.Add(new Product { Id = 1, Description = "Delivering Pizza", ProdType= " Margerita Pizza" });
            Console.WriteLine("Added Pizza");
            context.SaveChanges();
        }
    }
}
