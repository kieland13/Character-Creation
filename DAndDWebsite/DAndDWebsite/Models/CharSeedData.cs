using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DAndDWebsite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAndDWebsite.Models
{
    public class CharSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCharacterContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcCharacterContext>>()))
            {
                if (context.Character.Any())
                {
                    return;
                }

                context.Character.AddRange(
                    new Character
                    {
                        CharacterName = "Nick",
                        Age = 29,
                        Height = 77,
                        Weight = 200,
                        ClassSelection = "Druid",
                        RaceSelection = "Half-Elf",
                        Gender = "Male",
                        Hair = "Brown",
                        Eyes = "Blue",
                        Skin = "White"
                    });
                context.SaveChanges();
            }
        }
    }
}
