using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAndDWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAndDWebsite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcWeaponContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcWeaponContext>>()))
            {
                if (context.Weapon.Any())
                {
                    return;
                }

                context.Weapon.AddRange(
                    new Weapon
                    {
                        WeaponName = "BattleAxe",
                        WeaponType = "Two-Handed",
                        Damage = "1d8",
                        DamageType = "Slashing",
                        Cost = 6,
                        Weight = 4
                    },

                    new Weapon
                    {
                        WeaponName = "BlowGun",
                        WeaponType = "One-Handed Range",
                        Damage = "1",
                        DamageType = "Piercing",
                        Cost = 1,
                        Weight = 1
                    },

                    new Weapon
                    {
                        WeaponName = "Club",
                        WeaponType = "One-Handed",
                        Damage = "1d4",
                        DamageType = "Bludgeoning",
                        Cost = 3,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Dagger",
                        WeaponType = "One-Handed",
                        Damage = "1d4",
                        DamageType = "Piercing",
                        Cost = 1,
                        Weight = 1
                    },

                    new Weapon
                    {
                        WeaponName = "Flail",
                        WeaponType = "One-Handed",
                        Damage = "1d8",
                        DamageType = "Bludgeoning",
                        Cost = 2,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Glaive",
                        WeaponType = "Two-Handed",
                        Damage = "1d10",
                        DamageType = "Slashing",
                        Cost = 10,
                        Weight = 6
                    },

                    new Weapon
                    {
                        WeaponName = "GreatAxe",
                        WeaponType = "Two-Handed",
                        Damage = "1d12",
                        DamageType = "Slashing",
                        Cost = 8,
                        Weight = 7
                    },

                    new Weapon
                    {
                        WeaponName = "Greatclub",
                        WeaponType = "Two-Handed",
                        Damage = "1d8",
                        DamageType = "Bludgeoning",
                        Cost = 6,
                        Weight = 10
                    },

                    new Weapon
                    {
                        WeaponName = "Greatsword",
                        WeaponType = "Two-Handed",
                        Damage = "2d6",
                        DamageType = "Slashing",
                        Cost = 15,
                        Weight = 6
                    },

                    new Weapon
                    {
                        WeaponName = "Halberd",
                        WeaponType = "Two-Handed",
                        Damage = "1d10",
                        DamageType = "Slashing",
                        Cost = 7,
                        Weight = 6
                    },

                    new Weapon
                    {
                        WeaponName = "Hand Crossbow",
                        WeaponType = "One-Handed Range",
                        Damage = "1d6",
                        DamageType = "Piercing",
                        Cost = 4,
                        Weight = 3
                    },

                    new Weapon
                    {
                        WeaponName = "Handaxe",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Slashing",
                        Cost = 6,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Heavy Crossbow",
                        WeaponType = "Two-Handed Range",
                        Damage = "1d10",
                        DamageType = "Piercing",
                        Cost = 7,
                        Weight = 18
                    },

                    new Weapon
                    {
                        WeaponName = "Javelin",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Piercing",
                        Cost = 5,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Lance",
                        WeaponType = "One-Handed",
                        Damage = "1d12",
                        DamageType = "Piercing",
                        Cost = 8,
                        Weight = 6
                    },

                    new Weapon
                    {
                        WeaponName = "Light Crossbow",
                        WeaponType = "Two-Handed Range",
                        Damage = "1d8",
                        DamageType = "Piercing",
                        Cost = 6,
                        Weight = 5
                    },

                    new Weapon
                    {
                        WeaponName = "Longbow",
                        WeaponType = "Two-Handed Range",
                        Damage = "1d8",
                        DamageType = "Piercing",
                        Cost = 5,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Longsword",
                        WeaponType = "Two-Handed",
                        Damage = "1d8",
                        DamageType = "Slashing",
                        Cost = 10,
                        Weight = 3
                    },

                    new Weapon
                    {
                        WeaponName = "Mace",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Bludgeoning",
                        Cost = 7,
                        Weight = 4
                    },

                    new Weapon
                    {
                        WeaponName = "Maul",
                        WeaponType = "Two-Handed",
                        Damage = "2d6",
                        DamageType = "Bludgeoning",
                        Cost = 6,
                        Weight = 10
                    },

                    new Weapon
                    {
                        WeaponName = "Morningstar",
                        WeaponType = "One-Handed",
                        Damage = "1d8",
                        DamageType = "Piercing",
                        Cost = 4,
                        Weight = 4
                    },

                    new Weapon
                    {
                        WeaponName = "Pike",
                        WeaponType = "Two-Handed",
                        Damage = "1d10",
                        DamageType = "Piercing",
                        Cost = 18,
                        Weight = 18
                    },

                    new Weapon
                    {
                        WeaponName = "Quarterstaff",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Bludgeoning",
                        Cost = 4,
                        Weight = 4
                    },

                    new Weapon
                    {
                        WeaponName = "Rapier",
                        WeaponType = "One-Handed",
                        Damage = "1d8",
                        DamageType = "Piercing",
                        Cost = 5,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Schimitar",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Slashing",
                        Cost = 3,
                        Weight = 3
                    },

                    new Weapon
                    {
                        WeaponName = "Shortbow",
                        WeaponType = "Two-Handed Range",
                        Damage = "1d6",
                        DamageType = "Slashing",
                        Cost = 2,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Shortsword",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Piercing",
                        Cost = 2,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Sickle",
                        WeaponType = "One-Handed",
                        Damage = "1d4",
                        DamageType = "Bludgeoning",
                        Cost = 2,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Sling",
                        WeaponType = "One-Handed",
                        Damage = "1d4",
                        DamageType = "Bludgeoning",
                        Cost = 3,
                        Weight = 3
                    },

                    new Weapon
                    {
                        WeaponName = "Spear",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Piercing",
                        Cost = 3,
                        Weight = 2
                    },

                    new Weapon
                    {
                        WeaponName = "Trident",
                        WeaponType = "One-Handed",
                        Damage = "1d6",
                        DamageType = "Piercing",
                        Cost = 4,
                        Weight = 4
                    },

                    new Weapon
                    {
                        WeaponName = "Warhammer",
                        WeaponType = "Two-Handed",
                        Damage = "1d8",
                        DamageType = "Bludgeoning",
                        Cost = 8,
                        Weight = 10
                    },

                    new Weapon
                    {
                        WeaponName = "Whip",
                        WeaponType = "One-Handed",
                        Damage = "1d4",
                        DamageType = "Slashing",
                        Cost = 3,
                        Weight = 3
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
