using Safari.Api.Dto.Comment;

namespace Safari.Api.Interfaces;

public interface ICommentService
{
    public Task<List<CommentDto>> GetCommentListAsync();

    public Task AddCommentAsync(CreateCommentDto createCommentDto);
}