public class ThermalScanner : ILieDetector
{
    public bool IsLying(string suspectStatement)
    {
        return suspectStatement.ToLower().Contains("sweat");
    }
}