using Core.Entities;
using Core.Interfaces;

namespace webApp.UseCases;

public class SaveMouseTracksUseCase(IMouseTrackRepository repository) : ISaveMouseTracksUseCase
    
{
    public async Task ExecuteAsync(string jsonData)
    {
        var model = new MouseTrackModel { JsonData = jsonData };

        await repository.SaveAsync(model);
    }
}