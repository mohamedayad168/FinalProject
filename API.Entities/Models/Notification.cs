namespace API.Entities.Models;
public class Notification
{
    public int Id { get; set; }
    public string Content { get; set; }
    List<User> Users { get; set; }
}
