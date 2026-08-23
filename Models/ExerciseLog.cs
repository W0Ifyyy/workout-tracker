namespace WorkoutTracker.Models;

public class ExerciseLog
{
    public int Id { get; set; }
    public int WorkoutSessionId { get; set; }
    public WorkoutSession WorkoutSession { get; set; } = null!;
    public int ExerciseId { get; set; }
    public Exercise Exercise { get; set; } = null!;
    public List<SetLog> SetLogs { get; set; } = new();

}