using System.ComponentModel.DataAnnotations;

namespace MovieExpressWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string Description { get; set; }
        public string Genere { get; set; }

    }
}
