public class Time
{
    // public accessor methods
    public void DisplayCurrentTime()
    {
        System.Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5}",
           Month, Date, Year, Hour, Minute, Second);
    }

    public int GetHour()
    {
        return Hour;
    }

    public void GetTime(ref int h, ref int m, ref int s)
    {
        h = Hour;
        m = Minute;
        s = Second;
    }

    // constructor
    public Time(System.DateTime dt)
    {

        Year = dt.Year;
        Month = dt.Month;
        Date = dt.Day;
        Hour = dt.Hour;
        Minute = dt.Minute;
        Second = dt.Second;
    }

    // private member variables
    private int Year;
    private int Month;
    private int Date;
    private int Hour;
    private int Minute;
    private int Second;

}