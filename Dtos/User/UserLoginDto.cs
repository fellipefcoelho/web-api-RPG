using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_RPG.Dtos.User
{
    public class UserLoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }        
    }
}