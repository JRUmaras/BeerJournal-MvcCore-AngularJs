using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace BeerMvcAngularJs.Models
{
    public class Beer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public bool HasTried { get; set; }
    }
}
