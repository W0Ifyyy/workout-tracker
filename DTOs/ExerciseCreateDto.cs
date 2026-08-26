using System.ComponentModel.DataAnnotations;

namespace WorkoutTracker.DTOs;

public class ExerciseCreateDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string MuscleGroup { get; set; } = string.Empty;
}