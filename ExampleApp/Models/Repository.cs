﻿using System.Collections.Generic;

namespace ExampleApp.Models
{
    public class Repository
    {
        private Dictionary<int, Product> data;
        private static Repository repo;

        static Repository()
        {
            repo = new Repository();
        }

        public static Repository Current
        {
            get { return repo; }
        }

        public Repository()
        {
            Product[] products = new Product[]
            {
                new Product { ProductId = 1, Name = "Kayak", Price = 275M },
                new Product { ProductId = 2, Name = "Lifejacket", Price = 48.95M },
                new Product { ProductId = 3, Name = "Soccer Ball", Price = 19.50M },
                new Product { ProductId = 4, Name = "Thinking Cap", Price = 16M },
            };

            data = new Dictionary<int, Product>();

            foreach (Product prod in products)
            {
                data.Add( prod.ProductId, prod );
            }
        }

        public IEnumerable<Product> Products
        {
            get { return data.Values; }
        }

        public Product GetProduct( int id )
        {
            return data[id];
        }

        public Product SaveProduct( Product newProduct )
        {
            newProduct.ProductId = data.Keys.Count + 1;
            return data[newProduct.ProductId] = newProduct;
        }

        public Product DeleteProduct( int id )
        {
            Product prod = data[ id ];

            if (prod != null)
            {
                data.Remove( id );
            }

            return prod;
        }
    }
}