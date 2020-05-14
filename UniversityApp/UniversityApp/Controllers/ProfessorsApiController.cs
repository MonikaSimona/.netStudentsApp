using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApp.Data;
using UniversityApp.Models;

namespace UniversityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsApiController : ControllerBase
    {
        private readonly UniversityAppContext _context;

        public ProfessorsApiController(UniversityAppContext context)
        {
            _context = context;
        }

        // GET: api/ProfessorsApi
        [HttpGet]
        public List<Professor> GetTeacher(string firstNameString, string lastNameString,
            string degreeString, string academicRankString)
        {
            IQueryable<Professor> professors = _context.Professor.AsQueryable();
            if (!string.IsNullOrEmpty(firstNameString))
            {
                professors = professors.Where(t => t.FirstName == firstNameString);
            }
            if (!string.IsNullOrEmpty(lastNameString))
            {
                professors = professors.Where(t => t.LastName == lastNameString);
            }
            if (!string.IsNullOrEmpty(degreeString))
            {
                professors = professors.Where(t => t.Degree == degreeString);
            }
            if (!string.IsNullOrEmpty(academicRankString))
            {
                professors = professors.Where(t => t.AcademicRank == academicRankString);
            }
            return professors.ToList();
        }

        // GET: api/ProfessorsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Professor>> GetProfessor(int id)
        {
            var professor = await _context.Professor.FindAsync(id);

            if (professor == null)
            {
                return NotFound();
            }

            return professor;
        }

        // PUT: api/ProfessorsApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessor(int id, Professor professor)
        {
            if (id != professor.Id)
            {
                return BadRequest();
            }

            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProfessorsApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Professor>> PostProfessor(Professor professor)
        {
            _context.Professor.Add(professor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessor", new { id = professor.Id }, professor);
        }

        // DELETE: api/ProfessorsApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Professor>> DeleteProfessor(int id)
        {
            var professor = await _context.Professor.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            _context.Professor.Remove(professor);
            await _context.SaveChangesAsync();

            return professor;
        }

        private bool ProfessorExists(int id)
        {
            return _context.Professor.Any(e => e.Id == id);
        }
    }
}
