using Microsoft.AspNetCore.Mvc;
using Safari.Api.Dto.Comment;
using Safari.Api.Interfaces;

namespace Safari.Api.Controller;

[ApiController]
[Route("api/[controller]/[action]")]
public class CommentController : ControllerBase
{
    private ICommentService _commentService;

    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    [HttpGet]
    public async Task<List<CommentDto>> GetComment()
    {
        return await _commentService.GetCommentListAsync();
    }

    [HttpPost]
    public async Task<IActionResult> Addcomment([FromBody] CreateCommentDto comment)
    {
        await _commentService.AddCommentAsync(comment);
        return Ok();
    }
}