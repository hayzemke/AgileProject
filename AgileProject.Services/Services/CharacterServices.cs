using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CharacterServices : ICharacterService
{
    //* CRUD
    private readonly ApplicationDbContext _context;
    private readonly int _characterID;

    public CharacterServices(ApplicationDbContext context)
    {
        _context = context;
    } 
    public async Task<IEnumerable<CharacterListItem>> GetPostListItemsAsync()
        {
            var characters = await _context.Characters
            .Where(entity => entity.ID == _characterID)
            .Select(entity => new PostListItem
            {
                Id = entity.ID,
                Title = entity.Title,
            })
            .ToListAsync();
        return posts;
        }

}