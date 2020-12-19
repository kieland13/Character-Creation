using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAndDWebsite.Models
{
    public class Statistic
    {
        public int Id { get; set; }
        public int StatId { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Initiative { get; set; }
        public int Proficiency { get; set; }
        [Display(Name = "Health Points")]
        public int HealthPoints { get; set; }
        public int Speed { get; set; }
        public int Acrobatics { get; set; }
        [Display(Name = "Animal Handling")]
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persuassion { get; set; }
        public int Religion { get; set; }
        [Display(Name = "Sleight Of Hand")]
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }
    }
}
