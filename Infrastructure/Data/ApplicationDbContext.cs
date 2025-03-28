using Core.Entities;
using Microsoft.EntityFrameworkCore;
using webApp.Models;

namespace Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<MouseTrackModel>? MouseTracksModel { get; set; }
}