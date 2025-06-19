public class MissionController
{
    private readonly ILogger logger;

    public MissionController(ILogger logger)
    {
        this.logger = logger;
    }
    public void RunMission(string missionName)
    {
        // Simulate mission]
        Console.WriteLine($"Running mission: {missionName}");
        string result = $"Mission '{missionName}' completed successfully!";

        logger.Log(result);
    }
}