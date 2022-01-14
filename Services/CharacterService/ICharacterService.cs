using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_RPG.Dtos.Character;
using web_api_RPG.Models;

namespace web_api_RPG.Services.CharacterService
{
    //Tasks to make async calls
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(int userId);
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}