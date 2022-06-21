using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    // private readonly ApplicationDbContext _context;
    private readonly ICharacterService _service;

    public CharacterController(ICharacterService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCharacter([FromForm] CharacterModel model)
    {
        if (ModelState.IsValid)
            return BadRequest(ModelState);

        var createdCharacter = await _service.CreateCharacterAsync(model);
        if (createdCharacter)
            return Ok("Character was created!");

        return BadRequest("Character was NOT created.");
        {

        }
        //Will be done by someone esle just a placeholder in this branch
        
    }
     [HttpGet("{id}")]
    public async Task<IActionResult> GetCharacterByID(int id)
    {
        var character = await _context.Characters.FindAsync(id);
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
            oldCharacter.FirstName = model.FirstName;
            oldCharacter.LastName = model.LastName;
            oldCharacter.Age = model.Age;
            oldCharacter.IsEvil = model.IsEvil;
            oldCharacter.Animal = model.Animal;
            oldCharacter.FarmerType = model.FarmerType;

        await _context.SaveChangesAsync();
        return Ok("Your character has been updated");
    }
    //Delete
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteCharacter([FromRoute] int id)
    {
        var character = await _context.Characters.FindAsync(id);
        if(character == null)
        {
            return NotFound();
        }
        _context.Characters.Remove(character);
        await _context.SaveChangesAsync();
        return Ok("Character was Deleted");
    }
    //* C R U D
    [HttpGet]
    public async Task<ActionResult> GetAllCharacters()
    {
        var characters = await _service.GetCharacterListItemsAsync();
        return Ok(characters);
        // _service is doing the conversion from the characterlist item
        //Think of the controller as an office space call center
    }
}
