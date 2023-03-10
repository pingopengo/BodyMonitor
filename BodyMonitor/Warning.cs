namespace BodyMonitor;

public class Warning
{
    public string message;
    public bool isValid;
    public int priority;

    public Warning(string message, bool isValid, int priority)
    {
        this.message = message;
        this.isValid = isValid;
        this.priority = priority;
    }
}