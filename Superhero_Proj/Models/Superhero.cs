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
    }
}
