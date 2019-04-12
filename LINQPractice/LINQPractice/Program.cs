using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(1252, ProductCategory.Computers, "Logitech M510 Wireless Computer Mouse", 18.49, 25),
                new Product(1343, ProductCategory.Computers, "Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard", 29.99, 9),
                new Product(1542, ProductCategory.Computers, "Corsair Vengeance LPX 16GB (2x8GB) DDR4 DRAM 3000MHz", 139.99, 42),
                new Product(1721, ProductCategory.Computers, "USB 3.0 A to A Cable Type A Male to Male, 3 feet", 7.29, 112),
                new Product(2231, ProductCategory.Computers, "USB C to USB A", 10.99, 84),
                new Product(2405, ProductCategory.Computers, "EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5", 169.99, 25),
                new Product(2502, ProductCategory.Computers, "ASUS ROG Strix Z370-E Motherboard LGA1151 ", 209.99, 8),
                new Product(3152, ProductCategory.Electronics, "Tascam DR05 Stereo Portable Digital Recorder", 92.99, 14),
                new Product(3178, ProductCategory.Electronics, "Toshiba 43LF621U19 43-inch 4K Ultra HD Smart LED TV HDR", 319.99, 23),
                new Product(3556, ProductCategory.Electronics, "Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier", 399.00, 17),
                new Product(4339, ProductCategory.Kitchen, "KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer", 278.63, 36),
                new Product(4411, ProductCategory.Kitchen, "Hamilton Beach 62682RZ Hand Mixer", 14.99, 67),
                new Product(4523, ProductCategory.Kitchen, "Tovolo Flex-Core All Silicone Spatula", 10.49, 98),
                new Product(5134, ProductCategory.Kitchen, "Circulon Symmetry Hard Anodized Nonstick Skillet", 49.95, 62),
                new Product(5216, ProductCategory.Pet, "Neater Feeder Express Pet Bowls", 22.99, 6),
                new Product(5678, ProductCategory.Pet, "Magic Roller Ball Dog Toy", 10.80, 9),
                new Product(6123, ProductCategory.Pet, "Pillow Pets Signature Cozy Cow Plush Toy", 19.99, 17),
                new Product(6732, ProductCategory.Pet, "Evriholder FURemover Broom with Squeegee ", 15.99, 21),
                new Product(7128, ProductCategory.Pet, "Fabreze Pet Oder Eliminator", 4.94, 33),
                new Product(7231, ProductCategory.Pet, "Professional Pet Slicker Rug Brush for Dogs", 7.59, 17)
            };
            // 2.
            Console.WriteLine("List of products with prices in range $10 to $20 ordered by price ascending:\n");
            Console.WriteLine("Non-functional:");
            var result2Non = from product in products
                                                  where product.Price >= 10.00 & product.Price <= 20.00
                                                  orderby product.Price
                                                  select product;
            foreach(var p in result2Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result2Func = products.Where(product => (product.Price >= 10.00 & product.Price <= 20.00)).OrderBy(product => product.Price);
                
            foreach (var p in result2Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 3.
            Console.WriteLine("List of titles for products with prices in range $10 to $20 ordered by title alphabetically ascending:\n");
            Console.WriteLine("Non-functional:");
            var result3Non = from product in products
                             where product.Price >= 10.00 & product.Price <= 20.00
                             orderby product.Title
                             select product;
            foreach (var p in result3Non)
            {
                Console.WriteLine(p.Title.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result3Func = products.Where(product => (product.Price >= 10.00 & product.Price <= 20.00)).OrderBy(product => product.Title);

            foreach (var p in result3Func)
            {
                Console.WriteLine(p.Title.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 4.
            Console.WriteLine("List of IDs for products with prices in range $10 to $20 ordered by ID descending:\n");
            Console.WriteLine("Non-functional:");
            var result4Non = from product in products
                             where product.Price >= 10.00 & product.Price <= 20.00
                             orderby product.ID descending
                             select product;
            foreach (var p in result4Non)
            {
                Console.WriteLine(p.ID.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result4Func = products.Where(product => (product.Price >= 10.00 & product.Price <= 20.00)).OrderByDescending(product => product.ID);

            foreach (var p in result4Func)
            {
                Console.WriteLine(p.ID.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 5.
            Console.WriteLine("Kitchen products:\n");
            Console.WriteLine("Non-functional:");
            var result5Non = from product in products
                             where product.Category== ProductCategory.Kitchen
                             select product;
            foreach (var p in result5Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result5Func = products.Where(product => (product.Category==ProductCategory.Kitchen));

            foreach (var p in result5Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 6.
            Console.WriteLine("Kitchen products ordered by quantity in stock descending:\n");
            Console.WriteLine("Non-functional:");
            var result6Non = from product in products
                             where product.Category == ProductCategory.Kitchen
                             orderby product.StockedQuantity descending
                             select product;
            foreach (var p in result6Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result6Func = products.Where(product => (product.Category == ProductCategory.Kitchen)).OrderByDescending(product => product.StockedQuantity);

            foreach (var p in result6Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 7.
            Console.WriteLine("Computer products costing more than $100:\n");
            Console.WriteLine("Non-functional:");
            var result7Non = from product in products
                             where product.Category == ProductCategory.Computers && product.Price>=100
                             select product;
            foreach (var p in result7Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result7Func = products.Where(product => (product.Category == ProductCategory.Computers && product.Price>=100));

            foreach (var p in result7Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 8.
            Console.WriteLine("Title of product with an ID of 3152:\n");
            Console.WriteLine("Non-functional:");
            var result8Non = from product in products
                             where product.ID == 3152
                             select product;
            foreach (var p in result8Non)
            {
                Console.WriteLine(p.Title.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result8Func = products.Where(product => (product.ID==3152));

            foreach (var p in result8Func)
            {
                Console.WriteLine(p.Title.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 9.
            Console.WriteLine("List of products with titles longer than 50 characters:\n");
            Console.WriteLine("Non-functional:");
            var result9Non = from product in products
                             where product.Title.Length >= 50
                             select product;
            foreach (var p in result9Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result9Func = products.Where(product => (product.Title.Length>50));

            foreach (var p in result9Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 10.
            Console.WriteLine("List of Pet products ordered by price from lowest to highest:\n");
            Console.WriteLine("Non-functional:");
            var result10Non = from product in products
                             where product.Category==ProductCategory.Pet
                             orderby product.Price
                             select product;
            foreach (var p in result10Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result10Func = products.Where(product => (product.Category==ProductCategory.Pet)).OrderBy(product=>(product.Price));

            foreach (var p in result10Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 11.
            Console.WriteLine("List of products with IDs in range 2000 to 2999 ordered by ID:\n");
            Console.WriteLine("Non-functional:");
            var result11Non = from product in products
                              where product.ID>=2000&& product.ID<=2999
                              select product;
            foreach (var p in result11Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result11Func = products.Where(product => (product.ID >= 2000 && product.ID <= 2999));

            foreach (var p in result11Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 12.
            Console.WriteLine("List of titles for products with IDs in range 2000 to 2999 ordered by title length:\n");
            Console.WriteLine("Non-functional:");
            var result12Non = from product in products
                              where product.ID >= 2000 && product.ID <= 2999
                              orderby product.Title.Length
                              select product;
            foreach (var p in result12Non)
            {
                Console.WriteLine(p.Title.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result12Func = products.Where(product => (product.ID >= 2000 && product.ID <= 2999)).OrderBy(product=>(product.Title.Length));

            foreach (var p in result12Func)
            {
                Console.WriteLine(p.Title.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 13.
            Console.WriteLine("Titles and stocked quantity for products with less than 20 in stock:\n");
            Console.WriteLine("Non-functional:");
            var result13Non = from product in products
                              where product.StockedQuantity<20
                              select new { Title = product.Title, StockedQuantity = product.StockedQuantity };
            foreach (var p in result13Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result13Func = products.Where(product => (product.StockedQuantity < 20)).Select(product => new { Title = product.Title, StockedQuality = product.StockedQuantity });
            foreach (var p in result13Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
            // 14.
            Console.WriteLine("Titles and stocked quantity for products with less than 20 in stock ordered by stock ascending:\n");
            Console.WriteLine("Non-functional:");
            var result14Non = from product in products
                              where product.StockedQuantity<20
                              orderby product.StockedQuantity
                              select new { Title = product.Title, StockedQuantity = product.StockedQuantity };
            foreach (var p in result14Non)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nFuntional:");
            var result14Func = products.Where(product => (product.StockedQuantity < 20)).OrderBy(product => (product.StockedQuantity)).Select(product=>(new { Title = product.Title, StockedQuantity = product.StockedQuantity }));

            foreach (var p in result14Func)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("------------------------------------------------------------\n");
        }
    }
}
