using System.ComponentModel.DataAnnotations;

namespace DemoBlazor.Pages.Exos.Exo2.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Range(0,2000)]
        public int Prix { get; set; }
        [Required]
        public string Categorie { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
