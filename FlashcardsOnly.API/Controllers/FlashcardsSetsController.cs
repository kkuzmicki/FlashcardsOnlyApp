using FlashcardsOnly.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardsOnly.API.Controllers;

[ApiController]
[Route("api/flashcardsSets")]
public class FlashcardsSetsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<FlashcardsSetDTO>> GetFlashcardsSets()
    {
        return NotFound();
    }

    [HttpGet("{id}")]
    public ActionResult<FlashcardsSetDTO> GetFlashcardsSet(int id)
    {
        return Ok();
    }
}
