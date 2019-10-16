using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api_simpsons.Modules;
using api_simpsons.Dependencies;
using Microsoft.AspNetCore.Cors;
using System.Data.SqlClient;

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

        string connectionString = @"data source=DESKTOP-QMQ7M9Q\SQLEXPRESS; initial catalog=db_simpsons; user id=simpsons; password=1234";

        [HttpGet("{id}")]
        public Character GetCharacter(int id){
            return listofCharacters[id];
        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            List<Character> characters = new List<Character>();

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from tbl_character", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Character character = new Character
                {
                    Id = reader.GetInt64(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("firstName"))
                };
                characters.Add(character);
            }
            conn.Close();
            return characters;
        }
    }
}