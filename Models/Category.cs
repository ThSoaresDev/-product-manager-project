using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_produtos.Models;
[Table("Categories")]
public class Category
{

    public Category()
    {
            products = new Collection<Product>();
    }
    [Key]
    public int id { get; set; }
    [Required]
    [StringLength(80)]
    public string? name { get; set; }
    [Required]
    [StringLength(300)]
    public string? imageUrl { get; set; }
    public ICollection<Product>? products { get; set; }
}
