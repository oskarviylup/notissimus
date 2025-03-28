using Core.Entities;
using Core.Interfaces;
using Moq;
using webApp.UseCases;
using Xunit;

namespace Tests.Application.Tests;

public class SaveMouseTrackUseCaseTests
{
    [Fact]
    public async Task ExecuteAsync_ShouldCallRepositoryWithCorrectData()
    {
        const string jsonData = "[{\"x\":123,\"y\":456,\"t\":\"2025-03-27\"}]";
        var repositoryMock = new Mock<IMouseTrackRepository>();
        var useCase = new SaveMouseTracksUseCase(repositoryMock.Object);
        
        await useCase.ExecuteAsync(jsonData);
        
        repositoryMock.Verify(r => r.SaveAsync(It.Is<MouseTrackModel>(m =>
                m.JsonData == jsonData
        )), Times.Once);
    }
}