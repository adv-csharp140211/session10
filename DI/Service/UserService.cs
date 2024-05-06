namespace DI.Service;

public class UserService
{
    IMyLog myLog;
    private readonly ILogger<UserService> logger;

    public UserService(IMyLog myLog, ILogger<UserService> logger)
    {
        this.myLog = myLog;
        this.logger = logger;
    }

    public void AddUser(string username, string password)
    {
        //new dbContext
        //add
        //saveChanges

        //SpyObject
        myLog.Log($"User {username} Seaved");
    }

    public void EditUser(string username, string password)
    {
        //new dbContext
        //add
        //saveChanges

        myLog.Log($"User {username} Updated");
    }
}
