using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAndDWebsite.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        [Display(Name = "Weapon Name")]
        public string WeaponName { get; set; }
        [Display(Name = "Weapon Type")]
        public string WeaponType { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }

        public string Damage { get; set; }
        [Display(Name = "Damage Type")]
        public string DamageType { get; set; }
    }
}
