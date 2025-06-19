class Program
{

    static void Main(string[] args)
    {
        // 1

        // // Using FileLogger
        // ILogger fileLogger = new FileLogger();
        // MissionController fileMission = new MissionController(fileLogger);
        // fileMission.RunMission("Rescue Mission");

        // // Using ConsoleLogger
        // ILogger consoleLogger = new ConsoleLogger();
        // MissionController consoleMission = new MissionController(consoleLogger);
        // consoleMission.RunMission("Attack Mission");

        // 2
        TerroristInterrogationUnit unit = new TerroristInterrogationUnit();
        unit.Interrogate("I did not lie.");
        unit.Interrogate("I'm being honest!");
    }
}
