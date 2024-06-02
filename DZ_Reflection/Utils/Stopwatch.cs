namespace Reflection.Utils;


public static class Stopwatch
{
    public static TimeSpan TimeInterval { get; private set; }
    private static DateTime startTime;
    private static DateTime stopTime;

    public static void Start()
    {
        if (startTime > stopTime)
            throw new Exception("Необходимо запустить метод Stop");

        startTime = DateTime.Now;
    }

    public static void Stop()
    {
        stopTime = DateTime.Now;

        TimeInterval = stopTime - startTime;

        if (TimeInterval < TimeSpan.Zero)
        {
            throw new ArgumentException("Необходимо запустить метод Start");
        }
    }
}
