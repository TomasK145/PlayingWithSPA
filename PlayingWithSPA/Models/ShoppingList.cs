using System;
using System.Collections.Generic;

namespace PlayingWithSPA.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public ShoppingList()
        {
            Id = 0;
            Name = String.Empty;
            Items = new List<Item>();
        }
    }
}