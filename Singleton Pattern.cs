using System.Security.Cryptography.X509Certificates;

class LoggerFactory
{
    static LoggerFactory loggerFactory;
    private LoggerFactory()
    {
        
    }

    public static LoggerFactory GetLoggerFactoryInstance()
    {
        if(loggerFactory == null)
        {
            return loggerFactory = new LoggerFactory();
        }
        return loggerFactory;
    }

}

class sendNotification
{
    public void Main()
    {
        LoggerFactory loggerFactory =  LoggerFactory.GetLoggerFactoryInstance();
    }
} 

// double-checked locking pattern
// class LoggerFactory
// {
//     private static LoggerFactory loggerFactory;
//     private static readonly object lockObj = new object();

//     private LoggerFactory() { }

//     public static LoggerFactory GetLoggerFactoryInstance()
//     {
//         if (loggerFactory == null)
//         {
//             lock (lockObj)
//             {
//                 if (loggerFactory == null)
//                 {
//                     loggerFactory = new LoggerFactory();
//                 }
//             }
//         }
//         return loggerFactory;
//     }
// }

// class LoggerFactory
// {
//     private static readonly Lazy<LoggerFactory> instance = new Lazy<LoggerFactory>(() => new LoggerFactory());

//     private LoggerFactory() { }

//     public static LoggerFactory GetLoggerFactoryInstance()
//     {
//         return instance.Value;
//     }
// }