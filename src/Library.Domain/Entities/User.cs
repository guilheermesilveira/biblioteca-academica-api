namespace Library.Domain.Entities;

public abstract class User : Entity
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}