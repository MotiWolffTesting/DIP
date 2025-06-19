public class MissionController
{
    private FileLogger logger = new FileLogger();

    public void RunMission(string missionName)
    {
        // Simulate mission]
        Console.WriteLine($"Running mission: {missionName}");
        string result = $"Mission '{missionName}' completed successfully!";

        logger.Log(result);
    }
}