using SchedulerProj.Models;

namespace SchedulerProj.Services;

public static class UserService
{ 
    static List<User> Users { get; }
    static int nextId = 3;
    static UserService()
    { 
        Users = new List<User>()
        {
            new User { Id = 1, Name = "Lucas", Email = "Lucas@Lucas.com", Password = "1234"},
            new User { Id = 2, Name = "Lais", Email = "Lais@Lais.com", Password ="4321"}
        };
    }

    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(u => u.Id == id);

    public static void Add(User user)
    {
        user.Id = nextId++;
        Users.Add(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(u => u.Id == user.Id);
        if (index == -1) 
            return;
        Users[index] = user;
    }

    public static void Delete(int id)
    {
        var user = Get(id);
        if (user is null)
            return;
        Users.Remove(user);
    }
}