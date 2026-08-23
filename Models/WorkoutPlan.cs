namespace WorkoutTracker.Models;

public class WorkoutPlan
{
    public int Id { get; set; }
    public int UserId { get; set; }
    // public User User { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public List<Workout> Workouts { get; set; } = new ();
}