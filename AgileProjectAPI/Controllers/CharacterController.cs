using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProject.Models.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ILogger<CharacterController> _logger;
    private readonly ApplicationDBContext _context;
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
    //Will be done by someone esle just a placeholder in this branch
    [HttpGet("Get Characters By ID")]
    public async Task<IActionResult> GetCharacterByID(int id)
    {
        var character = await _context.Character.FindAsync(id);
        if(character == null)
        {
            return NotFound();
        }
        return Ok(character);
    }
    //Update
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateCharacter([FromForm] CharacterEdit model, [FromRoute] int id)
    {
        var oldCharacter = await _context.Characters.FindAsync(id);
        if(oldCharacter == null)
        {
            return NotFound();
        }
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        if(!string.IsNullOrEmpty(model.Name))
        {
            oldCharacter.Name = model.Name;
        }
        await _context.SaveChangesAsync();
        return Ok("Your character has been updated");
    }
    //Delete
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteCharacter([FromRoute] int id)
    {
        var character = await _context.Character.FindAsync(id);
        if(character == null)
        {
            return NotFound();
        }
        _context.Character.Remove(character);
        await _context.SaveChangesAsync();
        return Ok("Character was Deleted");
    }
    //* C R U D
}