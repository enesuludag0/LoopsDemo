namespace LoopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Laptop";
            product1.UnitPrice = 3000;
            product1.StockAmount = 12;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Mouse";
            product2.UnitPrice = 50;
            product2.StockAmount = 20;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Keyboard";
            product3.UnitPrice = 200;
            product3.StockAmount = 24;

            Product product4 = new Product();
            product4.Id = 4;
            product4.Name = "Monitor";
            product4.UnitPrice = 750;
            product4.StockAmount = 15;

            Product[] products = new Product[] { product1, product2, product3, product4 };

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine("Product: " + products[i].Name);
            //    Console.WriteLine("Price: " + products[i].UnitPrice);
            //    Console.WriteLine("Stock Amount: " + products[i].StockAmount);
            //    Console.WriteLine("--------------------");
            //}

            foreach (var product in products)
            {
                Console.WriteLine("Product: " + product.Name);
                Console.WriteLine("Price: " + product.UnitPrice);
                Console.WriteLine("Stock Amount: " + product.StockAmount);
                Console.WriteLine("--------------------");
            }

            //int i = 0;
            //while (i < products.Length)
            //{
            //    Console.WriteLine("Product: " + products[i].Name);
            //    Console.WriteLine("Price: " + products[i].UnitPrice);
            //    Console.WriteLine("Stock Amount: " + products[i].StockAmount);
            //    Console.WriteLine("--------------------");
            //    i++;
            //}
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }

    }
}
