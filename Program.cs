class Program
{
    static void Main(string[] args)
    {
        // Using FileLogger
        ILogger fileLogger = new FileLogger();
        MissionController fileMission = new MissionController(fileLogger);
        fileMission.RunMission("Rescue Mission");

        // Using ConsoleLogger
        ILogger consoleLogger = new ConsoleLogger();
        MissionController consoleMission = new MissionController(consoleLogger);
        consoleMission.RunMission("Attack Mission");
    }
}
