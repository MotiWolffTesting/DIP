public class BaseDefenseController
{
    private readonly IAlert alert;

    public BaseDefenseController(IAlert alert)
    {
        this.alert = alert;
    }
    public void OnThreatDetected()
    {
        Console.WriteLine("Threat detected.");
        alert.Alert();
    }
}