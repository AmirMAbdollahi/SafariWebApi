namespace Safari.Data.Entities;

public class Martyr : BaseEntity
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string? FatherFirstName { get; set; }
    public string? BirthDate { get; set; }
    public string? MartyrDate { get; set; }
    public int? Age { get; set; }
    public string? Education { get; set; }
    public string? Job { get; set; }
    public string? BurialPlace { get; set; }
    public string? MartyrPlace { get; set; }
    public string? MissionName { get; set; }
    public string? PhotoFileUrl { get; set; }
    public string? Marriage { get; set; }
    public string? TestamentText { get; set; }
    public string? TestamentFileUrl { get; set; }
    public string? Bio { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Comment> Comments { get; set; } = default!;
}