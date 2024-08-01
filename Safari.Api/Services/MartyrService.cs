using Microsoft.EntityFrameworkCore;
using Safari.Api.Dto.Martyr;
using Safari.Api.Interfaces;
using Safari.Data.DbContext;
using Safari.Data.Entities;

namespace Safari.Api.Services;

public class MartyrService : IMartyrService
{
    private readonly SafariDbContext _dbContext;

    public MartyrService(SafariDbContext context)
    {
        _dbContext = context;
    }

    public async Task<List<MartyrDto>> GetMartyrListAsync()
    {
        var martyrs = await _dbContext.Martyrs.Select(martyr => new MartyrDto()
        {
            Id = martyr.Id,
            FirstName = martyr.FirstName,
            LastName = martyr.LastName,
            FatherFirstName = martyr.FatherFirstName,
            BirthDate = martyr.BirthDate,
            MartyrDate = martyr.MartyrDate,
            Age = martyr.Age,
            Education = martyr.Education,
            Job = martyr.Job,
            BurialPlace = martyr.BurialPlace,
            MartyrPlace = martyr.MartyrPlace,
            MissionName = martyr.MissionName,
            PhotoFileUrl = martyr.PhotoFileUrl,
            Marriage = martyr.Marriage,
            TestamentText = martyr.TestamentText,
            TestamentFileUrl = martyr.TestamentFileUrl,
            Bio = martyr.Bio
        }).ToListAsync();
        return martyrs;
    }

    public async Task AddMartyrAsync(CreateMartyrDto martyrDto)
    {
        var martyr = new Martyr()
        {
            FirstName = martyrDto.FirstName,
            LastName = martyrDto.LastName,
            FatherFirstName = martyrDto.FatherFirstName,
            BirthDate = martyrDto.BirthDate,
            MartyrDate = martyrDto.MartyrDate,
            Age = martyrDto.Age,
            Education = martyrDto.Education,
            Job = martyrDto.Job,
            BurialPlace = martyrDto.BurialPlace,
            MartyrPlace = martyrDto.MartyrPlace,
            MissionName = martyrDto.MissionName,
            PhotoFileUrl = martyrDto.PhotoFileUrl,
            Marriage = martyrDto.Marriage,
            TestamentText = martyrDto.TestamentText,
            TestamentFileUrl = martyrDto.TestamentFileUrl,
            Bio = martyrDto.Bio,
            CreationDate = DateTime.Now
        };
        await _dbContext.Martyrs.AddAsync(martyr);
        await _dbContext.SaveChangesAsync();
    }
}