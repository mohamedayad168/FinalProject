using Microsoft.AspNetCore.Identity;

namespace API.Entities.Models;
public class User : IdentityUser 
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Bio { get; set; }
    public string AboutMe { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    List<Notification> Notifications { get; set; }
}
