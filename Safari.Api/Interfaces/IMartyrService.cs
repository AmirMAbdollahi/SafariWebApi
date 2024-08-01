using Safari.Api.Dto.Martyr;

namespace Safari.Api.Interfaces;

public interface IMartyrService
{
    Task<List<MartyrDto>> GetMartyrListAsync();

    Task AddMartyrAsync(CreateMartyrDto martyrDto);
}