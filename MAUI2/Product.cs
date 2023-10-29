using System;
namespace MAUI2
{
    public class Product : Good
    {
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}
