using System.Text.Json;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace webApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MouseTrackController(ISaveMouseTracksUseCase useCase) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> SaveMouseTracks([FromBody] JsonElement data)
    {
        await useCase.ExecuteAsync(data.GetRawText());
        return Ok();
    }
}