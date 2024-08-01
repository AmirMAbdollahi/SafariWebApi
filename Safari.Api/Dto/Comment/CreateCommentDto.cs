namespace Safari.Api.Dto.Comment;

public class CreateCommentDto
{
    public string Text { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public int MartyrId { get; set; }
}