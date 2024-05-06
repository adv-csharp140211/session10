using System.Diagnostics;

namespace DI.Service;

public class MyLogFile : IMyLog, IDisposable
{
    public void Dispose()
    {
        //
    }

    public void Log(string message)
    {
        Debug.WriteLine(message);
    }

    public void Log2(string message)
    {
        Debug.WriteLine(message);
    }
}


public class MyLogDB : IMyLog
{
    public void Log(string message)
    {
        Debug.WriteLine($"MASALAN DB: {message}");
    }
}

public class MyLogElastic : IMyLog
{
    public void Log(string message)
    {
        Debug.WriteLine($"MASALAN Elastic: {message}");
    }
}