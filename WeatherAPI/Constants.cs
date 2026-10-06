namespace HolidayAPI
{
    public class Constants
    {
        public static string adress = "https://date.nager.at";
        public static string Connect =
            Environment.GetEnvironmentVariable("HOLIDAYS_DB_CONNECTION")
            ?? throw new InvalidOperationException("Set the HOLIDAYS_DB_CONNECTION environment variable");
    }
}
