namespace SchedulerProj.Models;

public class Scheduler {
    public int Id { get; }
    public string Name { get; set; }
    public List<DateTime> Calendar { get; set; }
    public List<Schedule>? Schedules { get; set; }
}