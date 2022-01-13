using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_RPG.Models;

namespace web_api_RPG.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Gandalf";
        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 60;
        public int Defense { get; set; } = 55;
        public int Intelligence { get; set; } = 200;
        public RpgClass Class { get; set; } = RpgClass.Mage;           
    }
}