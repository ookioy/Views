using System;

namespace Views.Services
{
    public class SimpleTimeService : ITimeService
    {
        public string GetTimeForTomorrow()
        {
            return DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
        }
    }
}