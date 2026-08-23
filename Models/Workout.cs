namespace WorkoutTracker.Models;

public enum Day
{
    Monday = 0,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Workout
{
    public int Id { get; set; }
    public int WorkoutPlanId { get; set; }
    public WorkoutPlan WorkoutPlan { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public Day DayOfWeek { get; set; }
    public List<WorkoutExercise> WorkoutExercises { get; set; } = new();
    public List<WorkoutSession> WorkoutSessions { get; set; } = new();
}