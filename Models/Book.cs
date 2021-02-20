using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter Publisher")]
        public string Publisher { get; set; }
        
        [Required(ErrorMessage = "Please enter ISBN")]
        [RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "Not a valid ISBN Number")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Please enter Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter Price")]
        public double Price { get; set; }
    }
}
