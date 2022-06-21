using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ICharacterService
{
    Task<IEnumerable<CharacterListItem>> GetCharacterListItemsAsync();
    //Task with angle brackets means its awaitable
    Task<bool> CreateCharacterAsync(CharacterModel model);
}