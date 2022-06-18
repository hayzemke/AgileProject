using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _service;

    public CharacterController(ICharacterService service)
    {
        _service=service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCharacter ([FromForm] CharacterModel model)
    {
        if (ModelState.IsValid)
            return BadRequest(ModelState);

            var createdCharacter = await _service.CreateCharacterAsync(model);
            if(createdCharacter)
                return Ok("Character was created!");
            
            return BadRequest("Character was NOT created.");
        {
            
        }
    }

    //* C R U D
}