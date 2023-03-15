﻿using Microsoft.EntityFrameworkCore;

namespace DigitalCompoundStoreAPI.Entities
{
    public class Price
    {
        public int Id { get; set; }

        [Precision(18, 2)]
        public decimal PriceBuy { get; set; }
        [Precision(18, 2)]
        public decimal PriceSell { get; set;}
    }
}
