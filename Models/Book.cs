using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Pop_Andra_lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "book title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }

        public Publisher Publisher { get; set; } //navigation property

        public int? AutorID { get; set; }
        public Autor? Autor { get; set; }
    }
}
