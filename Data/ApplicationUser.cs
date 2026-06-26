using Microsoft.AspNetCore.Identity;
namespace ERP1.Data;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string Document { get; set; } = string.Empty;
}
