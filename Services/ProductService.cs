using ASPNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace ASPNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Outer Worlds [PlayStation 4]",
                Description = "The Outer Worlds is a new single-player first-person sci-fi RPG from Obsidian Entertainment and Private Division. Lost in transit while on a colonist ship bound for the furthest edge of the galaxy, you awake decades later only to find yourself in the midst of a deep conspiracy threatening to destroy the Halcyon colony.",
                Quantity = 2,
                Price = 1299.75M
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Elden Ring Launch Edition [PlayStation 5]",
                Description = "Elden Ring is an action role-playing game played in a third-person perspective with gameplay focusing on combat and exploration; it features elements similar to those found in other games developed by FromSoftware, such as the Souls series, Bloodborne, and Sekiro: Shadows Die Twice.",
                Quantity = 3,
                Price = 4482.13M
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Dragon Age: Origins [PlayStation 3]",
                Description = "Dragon Age: Origins is a role-playing game played from a third-person perspective. The player is a Grey Warden, part of an order of elite fighters, whose task is to defeat the Archdemon and save the world from a disastrous event called the Blight.",
                Quantity = 4,
                Price = 990.58M
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Stardew Valley [Nintendo Switch]",
                Description = "Stardew Valley is a farming simulation game primarily inspired by the Harvest Moon video game series. At the start of the game, players create a character, who becomes the recipient of a plot of land and a small house once owned by their grandfather in a small town called Pelican Town.",
                Quantity = 5,
                Price = 1766.89M
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Divinity Original Sin 2 Definitive Edition [PlayStation 4]",
                Description = "Divinity: Original Sin 2 is a single- and multiplayer top-down, party-based role-playing game with pen & paper RPG-like levels of freedom.",
                Quantity = 6,
                Price = 1302.88M
            });
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public decimal GetGrandTotalPrice()
        {
            decimal grandTotal = 0;
            foreach(var product in products)
            {
                grandTotal += product.TotalAmount;
            }
            return grandTotal;
        }
    }
}
