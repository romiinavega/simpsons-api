

using api_simpsons.Modules;
using System.Collections.Generic;

namespace api_simpsons.Dependencies
{
    public interface ICharacter
    {
        List<Character> GetCharacterList();

        Character GetCharacter(int id);
    }
}