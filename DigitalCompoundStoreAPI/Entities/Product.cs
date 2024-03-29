﻿namespace DigitalCompoundStoreAPI.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateBought { get; set; } // add popup callendar in the future
    public DateTime? DateSold { get; set; } // nullable, because DateSold value will be added once the product is actually sold
    public string Barcode { get; set; } //TODO barcode implementation

    // Navigation properties
    public int? PriceId { get; set; }
    public virtual Price Price {get; set;}
    public int? PriceUsedId { get; set; }
    public virtual PriceUsed PriceUsed { get; set; }
    public int? VideoGameId { get; set; }
    public virtual VideoGame VideoGame { get; set; }
}
