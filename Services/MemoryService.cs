using Auth.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Services
{
    public static class MemoryService
    {
        public static List<User> Users = new List<User>();
    }
}
