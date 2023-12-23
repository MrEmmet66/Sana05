using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Models
{
    public class Product
    {
        public Product(string name, decimal price, Currency cost, int quantity, string producer, float weight)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }
        public Product(string name, Currency cost, int quantity, string producer, float weight)
        {
            this.name = name;
            this.cost = cost;
            this.quantity = quantity;
            this.producer = producer;
            this.weight = weight;
        }
        public Product(Product product) : this(product.name, product.price, product.cost, product.quantity, product.producer, product.weight) { }
        public Product() { }

        protected string name;
        protected decimal price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected float weight;
    }
}
