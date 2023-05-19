using System;
using System.ComponentModel.DataAnnotations;

namespace InputToJson
{
    public class BookClass
    {
        public string Title { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Author { get; set; }

        public BookClass(string title, double price, string description, string image, string author)
        {
            this.Title = title;
            this.Price = price;
            this.Description = description;
            this.Image = image;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"The title is {Title} and it costs {Price}";
        }
    }

}
