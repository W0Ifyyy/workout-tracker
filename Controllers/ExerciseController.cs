using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Data;
using WorkoutTracker.DTOs;
using WorkoutTracker.Models;

namespace WorkoutTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExerciseController : ControllerBase
{
    private readonly AppDbContext _context;
    public ExerciseController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Exercise>>> GetAll()
    {
        var result = await _context.Exercises.ToListAsync();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddExercise(ExerciseCreateDto exercise)
    {   
        await _context.Exercises.AddAsync(new Exercise{ Name = exercise.Name, MuscleGroup = exercise.MuscleGroup });
        await _context.SaveChangesAsync();
        return Ok(new { message = "Exercise has been added succesfully!"});
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> EditExercise(int id, ExerciseCreateDto exercise)
    {
        var exists = await _context.Exercises.AnyAsync(e => e.Id == id);
        if (!exists)
        {
            return NotFound(new { message = "Exercise with that id does not exist!" });
        }

        _context.Exercises.Update(new Exercise { Id = id, Name = exercise.Name, MuscleGroup = exercise.MuscleGroup });
        await _context.SaveChangesAsync();
        return Ok(exercise);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteExercise(int id)
    {
        var exercise = await _context.Exercises.FirstOrDefaultAsync(e => e.Id == id);
        if (exercise == null)
        {
            return NotFound(new { message = "Exercise with that id does not exist!" });
        }
        _context.Exercises.Remove(exercise);
        await _context.SaveChangesAsync();
        return Ok(new { message = "Exercise has been removed succesfully!"});
    }
}