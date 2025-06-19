public class BaseDefenseController
{
    private SirenAlert alert = new SirenAlert();

    public void OnThreatDetected()
    {
        Console.WriteLine("Threat detected.");
        alert.Alert();
    }
}