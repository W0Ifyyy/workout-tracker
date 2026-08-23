namespace WorkoutTracker.Models;

public class WorkoutSession
{
    public int Id { get; set; }
    public int WorkoutId { get; set; }
    public Workout Workout { get; set; } = null!;
    public int UserId { get; set; }
    //public User User { get; set; } = null!:
    public DateTime Date { get; set; }
    public List<ExerciseLog> ExerciseLogs { get; set; } = new ();
}