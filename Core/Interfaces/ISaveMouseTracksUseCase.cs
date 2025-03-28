namespace Core.Interfaces;

public interface ISaveMouseTracksUseCase
{
    Task ExecuteAsync(string jsonData);
}
