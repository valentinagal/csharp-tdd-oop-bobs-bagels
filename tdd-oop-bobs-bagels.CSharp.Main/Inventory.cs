﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_bobs_bagels.CSharp.Main
{
    public partial class Inventory

    {
        private readonly List<InventoryItem> _items;

        public Inventory()
        {
            _items = new List<InventoryItem>
            {
                new InventoryItem("BGLO", 0.49f, "Bagel", "Onion", 7),
                new InventoryItem("BGLP", 0.39f, "Bagel", "Plain", 3),
                new InventoryItem("BGLE", 0.49f, "Bagel", "Everything", 4),
                new InventoryItem("BGLS", 0.49f, "Bagel", "Seasame", 5),
                new InventoryItem("COFB", 0.99f, "Coffee", "Black", 10),
                new InventoryItem("COFC", 1.29f, "Coffee", "Capuccino", 7),
                new InventoryItem("COFW", 1.19f, "Coffee", "White", 0),
                new InventoryItem("COFL", 1.29f, "Coffee", "Latte", 8),
                new InventoryItem("FILB", 0.12f, "Filling", "Bacon", 6),
                new InventoryItem("FILE", 0.12f, "Filling", "Egg", 6),
                new InventoryItem("FILC", 0.12f, "Filling", "Cheese", 6),
                new InventoryItem("FILX", 0.12f, "Filling", "Cream Cheese", 6),
                new InventoryItem("FILS", 0.12f, "Filling", "Smoked Salmon", 6),
                new InventoryItem("FILH", 0.12f, "Filling", "Ham", 6)
                
            };
        }
        public List<string>GetUniqueNames()
        {
            return _items.Select(x => x.Name).Distinct().ToList();
        }

        public List<InventoryItem> getByName(string Name)
        {
            return _items.Where(item => item.Name.Equals(Name)).ToList();
        }

        public InventoryItem getBySKU(string SKU)
        {
            return _items.SingleOrDefault(item => item.SKU.Equals(SKU));
        }


    }
}
