﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_CollectionView.MVVM.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }
        public bool HasOffer { get; set; }
        public decimal OfferPrice { get; set; }
    }
}
