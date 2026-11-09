using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Core.DesignPatterns.CreationDP.BuilderDP
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public int StockQuantity { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Stock: {StockQuantity}");
        }
    }


    public class ProductBuilder
    {
        private readonly Product _product;

        public ProductBuilder()
        {
            _product = new Product();
        }

        public ProductBuilder SetId(int id)
        {
            _product.Id = id;
            return this;
        }

        public ProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public ProductBuilder SetPrice(decimal price)
        {
            _product.Price = price;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            _product.Description = description;
            return this;
        }

        public ProductBuilder SetCategory(string category)
        {
            _product.Category = category;
            return this;
        }

        public ProductBuilder SetStockQuantity(int quantity)
        {
            _product.StockQuantity = quantity;
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}
