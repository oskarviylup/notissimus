using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using webApp.Models;

namespace Infrastructure.Repositories;

public class MouseTrackRepository(ApplicationDbContext context) : IMouseTrackRepository
{
    public async Task SaveAsync(MouseTrackModel entity)
    {
        context.MouseTracksModel?.Add(entity);
        await context.SaveChangesAsync();
    }
}