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
    public class StatisticsController : Controller
    {
        private readonly MvcStatisticContext _context;

        public StatisticsController(MvcStatisticContext context)
        {
            _context = context;
        }

        // GET: Statistics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Statistic.ToListAsync());
        }

        // GET: Statistics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statistic = await _context.Statistic.FindAsync(id);
            if (statistic == null)
            {
                return NotFound();
            }
            return View(statistic);
        }

        // POST: Statistics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StatId,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,Initiative,Proficiency,HealthPoints,Speed,Acrobatics,AnimalHandling,Arcana,Athletics,Deception,History,Insight,Intimidation,Investigation,Medicine,Nature,Perception,Performance,Persuassion,Religion,SleightOfHand,Stealth,Survival")] Statistic statistic)
        {
            if (id != statistic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statistic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatisticExists(statistic.Id))
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
            return View(statistic);
        }

        private bool StatisticExists(int id)
        {
            return _context.Statistic.Any(e => e.Id == id);
        }
    }
}
