//By Sohal Patel
//CIS-411-75-4202

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CartItem
{
    public CartItem() { }

    public CartItem(Product product, int quantity)
    {
        this.Product = product;
        this.Quantity = quantity;
        this.Total = product.UnitPrice * quantity;
    }

    public Product Product { get; set; }
    public int Quantity { get; set; }

    public decimal Total { get; set; }

    public void AddQuantity(int quantity)
    {
        this.Quantity += quantity;
    }



    public string Display()
    {
        //string displayString = string.Format("{0} ({1} @ {2} each = {3})",
        //    Product.Name,
        //    Quantity.ToString(),
        //    Product.UnitPrice.ToString("c"),
        //    Total.ToString("c")
        //);
        string displayString = string.Format($"{Product.Name} ({Quantity} @ {Product.UnitPrice:C} each = {Total:C})");
        return displayString;
    }
}
