using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAndDWebsite.Models
{
    public class Character
    {
        public int Id { get; set; }
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        [Display(Name = "Class")]
        public string ClassSelection { get; set; }
        [Display(Name = "Race")]
        public string RaceSelection { get; set; }
        public string Gender { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
    }
}
