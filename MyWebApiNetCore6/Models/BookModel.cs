using System.ComponentModel.DataAnnotations;

namespace MyWebApiNetCore6.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public string? Tittle { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}