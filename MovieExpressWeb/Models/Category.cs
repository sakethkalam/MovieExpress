using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieExpressWeb.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Movie Name")]
        public string? MovieName { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Display(Name = "Genere")]
        public  string? Genere { get; set; }

    }
}
