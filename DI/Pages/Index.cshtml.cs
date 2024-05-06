using DI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DI.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly UserService userService;
    private readonly IMyLog myLog;

    public IndexModel(ILogger<IndexModel> logger, UserService userService, IMyLog myLog)
    {
        _logger = logger;
        this.userService = userService;
        this.myLog = myLog;
    }

    public void OnGet()
    {
        //var mylogFile = new MyLogFile();
        //var mylogDb = new MyLogDB();
        //var mylogElastic = new MyLogElastic();
        //doLog(mylogFile, "test");
        //doLog(mylogDb, "test");
        //doLog(mylogElastic, "test");


        //var userService = new UserService(mylogDb);
        userService.AddUser("test", "xyz");
    }


    private void doLog(IMyLog myLog, string  msg)
    {
        //Dependncy Injection
        //Container
        //var mylog = new MyLog();
        myLog.Log(msg);
    }
}
