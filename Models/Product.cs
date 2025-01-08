namespace CRUD_produtos.Models;
public class Product
{
    public int id { get; set; }
    public string? name { get; set; }
    public string? description { get; set; }
    public decimal price { get; set; }
    public decimal quantity { get; set; }
    public string? imageUrl { get; set; }
    public float stock {get; set;}
    public DateTime registrationDate { get; set; }
    
}

