using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Range(1, 1000, ErrorMessage = "Priset måste vara mellan 1 till 1000kr")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Count must be at least 1")]
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
