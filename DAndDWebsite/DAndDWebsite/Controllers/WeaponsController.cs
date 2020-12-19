using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAndDWebsite.Data;
using DAndDWebsite.Models;

namespace DAndDWebsite.Controllers
{
    public class WeaponsController : Controller
    {
        private readonly MvcWeaponContext _context;

        public WeaponsController(MvcWeaponContext context)
        {
            _context = context;
        }

        // GET: Weapons
        public async Task<IActionResult> Index(string searchString)
        {
            var weapons = from w in _context.Weapon
                          select w;

            if (!String.IsNullOrEmpty(searchString))
            {
                weapons = weapons.Where(w => w.WeaponName.Contains(searchString));
            }
            
            return View(await weapons.ToListAsync());
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

       
        // GET: Weapons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapon.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }
            return View(weapon);
        }

        // POST: Weapons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WeaponName,WeaponType,Cost,Weight,Damage,DamageType")] Weapon weapon)
        {
            if (id != weapon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weapon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeaponExists(weapon.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(weapon);
        }

        private bool WeaponExists(int id)
        {
            return _context.Weapon.Any(e => e.Id == id);
        }
    }
}
