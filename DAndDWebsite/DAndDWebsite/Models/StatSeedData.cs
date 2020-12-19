using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DAndDWebsite.Data;

namespace DAndDWebsite.Models
{
    public class StatSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStatisticContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStatisticContext>>()))
            {
                if (context.Statistic.Any())
                {
                    return;
                }

                context.Statistic.AddRange(
                    new Statistic
                    {
                        Strength = 13,
                        Dexterity = 17,
                        Constitution = 14,
                        Intelligence = 20,
                        Wisdom = 15,
                        Charisma = 11,
                        Initiative = 3,
                        Proficiency = 3,
                        Speed = 30,
                        HealthPoints = 37,
                        Acrobatics = 3,
                        AnimalHandling = 2,
                        Arcana = 5,
                        Athletics = 1,
                        Deception = 0,
                        History = 5,
                        Insight = 2,
                        Intimidation = 0,
                        Investigation = 5,
                        Medicine = 2,
                        Nature = 5,
                        Perception = 2,
                        Performance = 0,
                        Persuassion = 0,
                        Religion = 5,
                        SleightOfHand = 3,
                        Stealth = 3,
                        Survival = 2
                    }
                    );
                context.SaveChanges();
            }

        }
    }
}
