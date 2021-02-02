using System;
using System.Collections.Generic;
using System.Text;

namespace NRulesDemo.Model
{
    public class Customer
    {
        public string Name { get; }
        public bool IsPreferred { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void NotifyAboutDiscount()
        {
            Console.WriteLine($"Customer {Name} was notified about a discount");
        }
    }

    public class Order
    {
        public int Id { get; }
        public Customer Customer { get; }
        public int Quantity { get; }
        public double UnitPrice { get; }
        public double PercentDiscount { get; set; }
        public bool IsOpen { get; set; } = true;

        public Order(int id, Customer customer, int quantity, double unitPrice)
        {
            Id = id;
            Customer = customer;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
