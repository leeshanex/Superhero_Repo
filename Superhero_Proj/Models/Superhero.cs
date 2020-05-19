using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero_Proj.Models
{
    public class Superhero 
    {
        [Key]
        public int ID { get; set; }
        public string superheroName { get; set; }
        public string alterEgoName{ get; set; }
        public string primaryAbility{ get; set; }
        public string secondaryAbility { get; set; }
        public string catchphrase { get; set; }
    }
}
