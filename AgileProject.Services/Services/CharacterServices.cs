using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CharacterServices : ICharacterService
{
    private readonly ApplicationDbContext _context;
    public CharacterServices(ApplicationDbContext context)
    {
        _context = context;
    }

    //* CRUD
    public async Task<bool> CreateCharacterAsync(CharacterModel model)
    {
        var character = new Character
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Age = model.Age,
            IsEvil = model.IsEvil
        };

        _context.Characters.Add(character);
        var numberOfChanges = await _context.SaveChangesAsync();
        return numberOfChanges == 1;
    }

    
}