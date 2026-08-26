using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.Models;

public class Exercise
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name {get; set;} = string.Empty;
    [Required]
    [MaxLength(30)]
    public string MuscleGroup {get; set; } = string.Empty;
}