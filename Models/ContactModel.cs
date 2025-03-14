using System.ComponentModel.DataAnnotations;

namespace Blazorwind.Models;

public class ContactModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Phone is required")]
    public string Phone { get; set; }
    [Required (ErrorMessage = "Message is required")]
    [StringLength(500, ErrorMessage = "Message is too long")]
    public string Message { get; set; }
    
    
    public ContactModel()
    {
        
    }

    public ContactModel(string name, string email, string phone, string message)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Message = message;
    }
}