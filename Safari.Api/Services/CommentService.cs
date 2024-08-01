using Microsoft.EntityFrameworkCore;
using Safari.Api.Dto.Comment;
using Safari.Api.Interfaces;
using Safari.Data.DbContext;
using Safari.Data.Entities;

namespace Safari.Api.Services;

public class CommentService : ICommentService
{
    private readonly SafariDbContext _dbContext;

    public CommentService(SafariDbContext context)
    {
        _dbContext = context;
    }

    public async Task<List<CommentDto>> GetCommentListAsync()
    {
        var comments = await _dbContext.Comments.Select(comment => new CommentDto()
        {
            Id = comment.Id,
            Text = comment.Text,
            FirstName = comment.FirstName,
            LastName = comment.LastName,
            PhoneNumber = comment.PhoneNumber,
            MartyrId = comment.MartyrId
        }).ToListAsync();
        return comments;
    }

    public async Task AddCommentAsync(CreateCommentDto createCommentDto)
    {
        var comment = new Comment()
        {
            Text = createCommentDto.Text,
            FirstName = createCommentDto.FirstName,
            LastName = createCommentDto.LastName,
            PhoneNumber = createCommentDto.PhoneNumber,
            MartyrId = createCommentDto.MartyrId
        };
        await _dbContext.Comments.AddAsync(comment);
        await _dbContext.SaveChangesAsync();
    }
}