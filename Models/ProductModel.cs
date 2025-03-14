using System.ComponentModel.DataAnnotations;

namespace Blazorwind.Models;

public class ProductModel
{
    
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public double Price { get; set; }
    
    
    public ProductModel()
    {
        
    }
        
    public ProductModel(int id, string title, string description, string image, double price)
    {
        Id = id;
        Title = title;
        Description = description;
        Image = image;
        Price = price;
    }
    
    
    
    
    
    
}