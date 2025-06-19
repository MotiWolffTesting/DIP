public class TerroristInterrogationUnit
{
    private VoiceAnalyzer voiceAnalyzer = new VoiceAnalyzer();

    public void Interrogate(string suspectStatement)
    {
        bool isLying = voiceAnalyzer.IsLying(suspectStatement);
        if (isLying)
        {
            Console.WriteLine("Suspect is lying!");
        }
        else
        {
            Console.WriteLine("Suspect is telling the truth.");
        }
    }
}