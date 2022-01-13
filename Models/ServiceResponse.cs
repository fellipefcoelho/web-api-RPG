using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_RPG.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Succes { get; set; } = true;
        public string Message { get; set; } = null;
    }
}