namespace Safari.Data.Entities;

public class Comment : BaseEntity
{
    public string Text { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public int MartyrId { get; set; }
    public bool IsApproved { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsDeleted { get; set; }

    public Martyr Martyr { get; set; } = default!;
}