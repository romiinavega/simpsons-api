using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api_simpsons.Modules;
using api_simpsons.Dependencies;
using Microsoft.AspNetCore.Cors;

namespace api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController] 
    [EnableCors("AllowOrigin")]

    public class CharacterController : ICharacter
    {
        List<Character> listofCharacters => new List<Character> 
        {
            new Character 
            {
                Name = "Homero",
                LastName = "Simposon",
                SecondName = "Jay",
                Age = 24
            },
            new Character{
                Name = "Bart",
                LastName = "Simposon",
                Age = 10
            },
        };

        [HttpGet("{id}")]
        public Character GetCharacter(int id){
            return listofCharacters[id];
        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            return listofCharacters; 
        }
    }
}