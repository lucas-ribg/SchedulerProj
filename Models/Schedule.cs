namespace SchedulerProj.Models;

public class Schedule {
    public int Id { get; }
    public User User { get; set; }
    public DateTime Datetime { get; set; }
}