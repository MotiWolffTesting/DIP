public class TerroristInterrogationUnit
{
    private readonly ILieDetector lieDetector;

    public TerroristInterrogationUnit(ILieDetector lieDetector)
    {
        this.lieDetector = lieDetector;
    }

    public void Interrogate(string suspectStatement)
    {
        bool isLying = lieDetector.IsLying(suspectStatement);
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