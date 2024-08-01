using Microsoft.AspNetCore.Mvc;
using Safari.Api.Dto.Martyr;
using Safari.Api.Interfaces;

namespace Safari.Api.Controller;

[ApiController]
[Route("api/[controller]/[action]")]
public class MartyrController : ControllerBase
{
    private IMartyrService _martyrService;

    public MartyrController(IMartyrService martyrService)
    {
        _martyrService = martyrService;
    }

    [HttpGet]
    public async Task<List<MartyrDto>> GetMartyr()
    {
        return await _martyrService.GetMartyrListAsync();
    }

    [HttpPost]
    public async Task<IActionResult> AddMartyr([FromBody] CreateMartyrDto martyrDto)
    {
        await _martyrService.AddMartyrAsync(martyrDto);
        return Ok();
    }
}