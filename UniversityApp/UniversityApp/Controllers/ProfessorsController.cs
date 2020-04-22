using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityApp.Data;
using UniversityApp.Models;
using UniversityApp.ViewModels;

namespace UniversityApp.Controllers
{
    public class ProfessorsController : Controller
    {
        private readonly UniversityAppContext _context;

        public ProfessorsController(UniversityAppContext context)
        {
            _context = context;
        }

        // GET: Professors
        public async Task<IActionResult> Index(string profName, string profDegree, string profAcRank)
        {
            IQueryable<Professor> professors = _context.Professor.AsQueryable();

            IQueryable<String> profDegreeQuery = _context.Professor
                .OrderBy(m => m.Degree).Select(m => m.Degree).Distinct();

            IQueryable<String> profAcRankQuery = _context.Professor
                .OrderBy(m => m.AcademicRank).Select(m => m.AcademicRank).Distinct();
           
            if (!String.IsNullOrEmpty(profName))
            {
                professors = professors.Where(s => s.FirstName.Contains(profName) || s.LastName.Contains(profName));
            }
           
            if (!String.IsNullOrEmpty(profDegree))
            {
                professors = professors.Where(x => x.Degree == profDegree);
            }
            if (!String.IsNullOrEmpty(profAcRank))
            {
                professors = professors.Where(x => x.AcademicRank == profAcRank);
            }

            professors = professors.Include(m => m.FirstProfCourses)
                                    .Include(m => m.SecondProfCourses);
            

            var profFilterViewModel = new ProfessorFilterViewModel
            {
                Professors = await professors.ToListAsync(),
                Degrees = new SelectList(await profDegreeQuery.ToListAsync()),
                AcademicRanks = new SelectList(await profAcRankQuery.ToListAsync())
                
            };

            return View(profFilterViewModel);

            //return View(await _context.Professor.ToListAsync());
        }

        // GET: Professors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor
                .Include(p => p.FirstProfCourses)
                .Include(p => p.SecondProfCourses)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // GET: Professors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Degree,AcademicRank,OfficeNumber,HireDate")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(professor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(professor);
        }

        // GET: Professors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }
            return View(professor);
        }

        // POST: Professors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Degree,AcademicRank,OfficeNumber,HireDate")] Professor professor)
        {
            if (id != professor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessorExists(professor.Id))
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
            return View(professor);
        }

        // GET: Professors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor
                .Include(p => p.FirstProfCourses)
                .Include(p => p.SecondProfCourses)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // POST: Professors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professor = await _context.Professor.FindAsync(id);
            _context.Professor.Remove(professor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessorExists(int id)
        {
            return _context.Professor.Any(e => e.Id == id);
        }
    }
}
