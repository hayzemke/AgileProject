using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ILogger<CharacterController> _logger;

    public CharacterController(ILogger<CharacterController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public async Task<IActionResult> GetCharacterByID(int id)
    {
        var character = await _context.Character.FindASync(id);
        if(character == null)
        {
            return NotFound();
        }
        return Ok(character);
    }
    //* C R U D
}