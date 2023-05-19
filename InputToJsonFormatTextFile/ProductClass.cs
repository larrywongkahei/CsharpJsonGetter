using System;
namespace InputToJson
{
    public class ProductClass
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public string Origin { get; set; }

        public ProductClass(string productName, double price, string image, string description, string rating, string origin)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Image = image;
            this.Description = description;
            this.Rating = rating;
            this.Origin = origin;
        }

        public override string ToString()
        {
            return $"The product is {ProductName} and it costs {Price}";
        }
    }
}
