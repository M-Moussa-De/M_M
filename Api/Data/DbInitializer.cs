using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;

namespace Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                 new Product
                {
                    Name = "Hat 305",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/hat.png",
                    Brand = "Summer",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hat 307",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/hat2.png",
                    Brand = "Summer",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hat 313",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/hat3.png",
                    Brand = "Summer",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hat 507",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/hat4.png",
                    Brand = "Summer",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hat 107 xx",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/hat5.png",
                    Brand = "Summer",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hat 113 light",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/hat6.png",
                    Brand = "Summer",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pants short",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/pants.jpg",
                    Brand = "Light summer",
                    Type = "Pants",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Shoes 516",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/shoes.png",
                    Brand = "Convers",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/shoes2.jpg",
                    Brand = "Shoes 115",
                    Type = "Lady Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Running wr shoes",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/shoes3.jpg",
                    Brand = "Sports HI",
                    Type = "Sports shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Winter browny shoes",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/shoes4.jpg",
                    Brand = "Winter sd",
                    Type = "Winter shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Winter walking shoes",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/shoes5.jpg",
                    Brand = "Walking shoes 12",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Half socks",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/socks.jpg",
                    Brand = "Socks xy",
                    Type = "Socks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Socks",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/socks2.jpg",
                    Brand = "Red 45",
                    Type = "Socks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Winter group 107",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/socks3.png",
                    Brand = "Winter group",
                    Type = "Socks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Warmy socks",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/socks4.png",
                    Brand = "Socks for winter",
                    Type = "Socks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light green tshirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/tshirt.png",
                    Brand = "Young T-Shirts",
                    Type = "T-shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dark tshirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/tshirt2.png",
                    Brand = "Young T-Shirts",
                    Type = "T-shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White summer tshirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/tshirt3.png",
                    Brand = "Young T-Shirts",
                    Type = "T-shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue tshirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/tshirt4.png",
                    Brand = "Young T-Shirts",
                    Type = "T-shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dark tshirt",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/wallet2.jpg",
                    Brand = "Young T-Shirts",
                    Type = "T-shirts",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dark browny wallet",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/wallet3.jpg",
                    Brand = "Wallet save",
                    Type = "Wallets",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}