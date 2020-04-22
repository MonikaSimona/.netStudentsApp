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
    public class CoursesController : Controller
    {
        private readonly UniversityAppContext _context;

        public CoursesController(UniversityAppContext context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index(string courseTitle, int courseSemester, string courseProgramme)
        {
            
              

            IQueryable<Course> courses = _context.Courses.AsQueryable();
            IQueryable<string> titleQuery = _context.Courses
                .OrderBy(m => m.Title).Select(m => m.Title).Distinct();

            IQueryable<int> semesterQuery = _context.Courses
                .OrderBy(m => m.Semester).Select(m => m.Semester).Distinct();

            IQueryable<string> programmeQuery = _context.Courses
                .OrderBy(m => m.Programme).Select(m => m.Programme).Distinct();

            if (!string.IsNullOrEmpty(courseTitle))
            {
                courses = courses.Where(x => x.Title == courseTitle);
            }
            if (courseSemester != 0)
            {
                courses = courses.Where(x => x.Semester == courseSemester);
            }
            if (!string.IsNullOrEmpty(courseProgramme))
            {
                courses = courses.Where(x => x.Programme == courseProgramme);
            }

            courses = courses.Include(m => m.FirstProfessor).ThenInclude(m => m.FirstProfCourses);
            courses = courses.Include(m => m.SecondProfessor).ThenInclude(m => m.SecondProfCourses);
            courses = courses.Include(m => m.Students).ThenInclude(m => m.Student);

            var courseFilterVM = new CourseFilterViewModel
            {
                Titles = new SelectList(await titleQuery.ToListAsync()),
                Semesters = new SelectList(await semesterQuery.ToListAsync()),
                Programmes = new SelectList(await programmeQuery.ToListAsync()),
                Courses = await courses.ToListAsync()

            };
            return View(courseFilterVM);


            //var universityAppContext = _context.Courses.Include(c => c.FirstProfessor).Include(c => c.SecondProfessor);
            //return View(await universityAppContext.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.FirstProfessor)
                .Include(c => c.SecondProfessor)
                .Include(c => c.Students).ThenInclude(c => c.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            ViewData["FirstProfessorId"] = new SelectList(_context.Professor, "Id", "FullName");
           
            ViewData["SecondProfessorId"] = new SelectList(_context.Professor, "Id", "FullName");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Credits,Semester,Programme,EducationLevel,FirstProfessorId,SecondProfessorId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FirstProfessorId"] = new SelectList(_context.Professor, "Id", "FullName", course.FirstProfessorId);
            ViewData["SecondProfessorId"] = new SelectList(_context.Professor, "Id", "FullName", course.SecondProfessorId);
            return View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }


            ViewData["FirstProfessorId"] = new SelectList(_context.Professor, "Id", "FullName", course.FirstProfessorId);
            ViewData["SecondProfessorId"] = new SelectList(_context.Professor, "Id", "FullName", course.SecondProfessorId);
            
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Credits,Semester,Programme,EducationLevel,FirstProfessorId,SecondProfessorId")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
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
            ViewData["FirstProfessorId"] = new SelectList(_context.Professor, "Id", "FullName", course.FirstProfessorId);
            ViewData["SecondProfessorId"] = new SelectList(_context.Professor, "Id", "FullName", course.SecondProfessorId);
            return View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.FirstProfessor)
                .Include(c => c.SecondProfessor)
                .Include(c => c.Students).ThenInclude(c => c.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
