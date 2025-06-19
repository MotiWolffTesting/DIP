public class VoiceAnalyzer
{
    public bool IsLying(string suspectStatement)
    {
        return suspectStatement.ToLower().Contains("lie");
    }
}