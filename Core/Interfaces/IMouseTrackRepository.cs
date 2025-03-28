using Core.Entities;
using webApp.Models;

namespace Core.Interfaces;

public interface IMouseTrackRepository
{ 
    Task SaveAsync(MouseTrackModel entity);
}