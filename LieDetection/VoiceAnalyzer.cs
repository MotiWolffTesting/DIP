public class VoiceAnalyzer : ILieDetector
{
    public bool IsLying(string suspectStatement)
    {
        return suspectStatement.ToLower().Contains("lie");
    }
}