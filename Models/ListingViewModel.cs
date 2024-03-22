using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Models;

public class ListingViewModel
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public double Price { get; set; }
    
    public IFormFile? Image { get; set; }

    public bool IsSold { get; set; }
    
    [Required]
    public string? IdentityUserId { get; set; }
    
    [ForeignKey(nameof(IdentityUserId))]
    public IdentityUser? User { get; set; }
}