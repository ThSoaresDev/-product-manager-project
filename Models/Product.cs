using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_produtos.Models;
[Table("Products")]
public class Product
{
    [Key]
    public int id { get; set; }
    [Required]
    [StringLength(80)]
    public string? name { get; set; }
    [Required]
    [StringLength(300)]
    public string? description { get; set; }
    [Required]
    [Column(TypeName ="decimal(10,2)")]
    public decimal price { get; set; }
    [Required]
    [StringLength(300)]
    public string? imageUrl { get; set; }
    public float stock {get; set;}
    public DateTime registrationDate { get; set; }
    public int categoryId { get; set; }
    public Category? category { get; set; }
    
}

