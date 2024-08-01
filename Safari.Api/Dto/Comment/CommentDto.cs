namespace Safari.Api.Dto.Comment;

public class CommentDto
{
    public int Id { get; set; }
    public string Text { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public int MartyrId { get; set; }
}