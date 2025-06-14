namespace Core.Util
{
    ///
    public static class Calendar
    {
        public static int GetDate(DateTime datetime)
        {
            return (int)(datetime - new DateTime(2025, 1, 29).ToUniversalTime()).TotalSeconds;
        }
    }
}
