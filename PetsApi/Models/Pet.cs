using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
    }
}
