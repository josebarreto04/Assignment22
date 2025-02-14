﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Library.Models
{
    public class ShoppingCart
    {
       public int Id { get; set; }
        public ObservableCollection<Product> Contents { get; set; }
        public ShoppingCart() 
        { 
            Contents = new ObservableCollection<Product>();
        }
    }
}
