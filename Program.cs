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
        ILieDetector voiceAnalyzer = new VoiceAnalyzer();
        TerroristInterrogationUnit unit1 = new TerroristInterrogationUnit(voiceAnalyzer);
        unit1.Interrogate("I did not lie.");
        unit1.Interrogate("I'm being honest!");

        ILieDetector thermalScanner = new ThermalScanner();
        TerroristInterrogationUnit unit2 = new TerroristInterrogationUnit(thermalScanner);
        unit2.Interrogate("It is too hot here, i'm full of sweat!");
        unit2.Interrogate("Me? A liar? Hahaha!");
    }
}
