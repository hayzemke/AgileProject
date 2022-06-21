using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class CharacterServices : ICharacterService
{
    private readonly ApplicationDbContext _context;
    public CharacterServices(ApplicationDbContext context)
    {
        _context = context;
    }
    private readonly int _characterID;

    public async Task<IEnumerable<CharacterListItem>> GetCharacterListItemsAsync()
        {
            var characters = await _context.Characters
            // .Where(entity => entity.ID == _characterID)
            // ^Not needed because we dont have a user table like we did in eleven note, i.e. we dont need to query therough i.d's
            .Select(entity => new CharacterListItem
            {
                Id = entity.ID,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            })
            .ToListAsync();
        return characters;
        }

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

    public async Task<CharacterDetails> GetCharacterDetailsAsync(int id)
    {
        var character =  await _context.Characters.FindAsync(id);
        if(character is null)
        {
            return null;
        }
        return new CharacterDetails{
            FirstName = character.FirstName,
            LastName = character.LastName,
            Age = character.Age,
            IsEvil = character.IsEvil,
            Animal = character.Animal,
            FarmerType = character.FarmerType,
            Level = character.Level,
        };
    }
}

//CharacterModel is being passed through SaveChangesAsync

//CharacterEdit is like a view model


//Think of the listitem object as your gmail, the minimum amount of data to get your eye or get information across
