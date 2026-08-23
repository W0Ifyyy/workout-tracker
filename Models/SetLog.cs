namespace WorkoutTracker.Models;

public class SetLog
{
    public int Id { get; set; }
    public int ExerciseLogId { get; set; }
    public ExerciseLog ExerciseLog { get; set; } = null!;
    public int SetNumber { get; set; }
    public int Reps { get; set; }
    public decimal Weight { get; set; } 
}