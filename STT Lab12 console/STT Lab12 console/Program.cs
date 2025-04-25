using System;
using System.Globalization;
using System.Threading;

namespace ConsoleAlarmApp
{
    // Define delegate for the event
    public delegate void AlarmEventHandler();

    // Publisher class
    public class AlarmClock
    {
        // Event declaration
        public event AlarmEventHandler raiseAlarm;

        private DateTime targetTime;

        // Set target time
        public bool SetAlarmTime(string inputTime)
        {
            bool success = DateTime.TryParseExact(
                inputTime,
                "HH:mm:ss",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out targetTime
            );

            return success;
        }

        // Start monitoring the time
        public void Start()
        {
            Console.WriteLine("Alarm set for: " + targetTime.ToLongTimeString());
            while (true)
            {
                string currentTime = DateTime.Now.ToLongTimeString();
                Console.WriteLine("Tick-Tock: " + currentTime);

                if (DateTime.Now.TimeOfDay >= targetTime.TimeOfDay)
                {
                    // Raise the event when times match
                    raiseAlarm?.Invoke();
                    break;
                }

                Thread.Sleep(1000); // wait for 1 second
            }
        }
    }

    // Subscriber class
    public class AlarmSubscriber
    {
        public void Ring_alarm()
        {
            Console.WriteLine("ALARM!!!!!!!!! Time has been reached.");
        }
    }

    // Main application
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            AlarmSubscriber subscriber = new AlarmSubscriber();

            // Subscribe to the event
            clock.raiseAlarm += subscriber.Ring_alarm;

            Console.Write("Enter target time in HH:MM:SS format (24-hour): ");
            string input = Console.ReadLine();

            if (clock.SetAlarmTime(input))
            {
                clock.Start();
            }
            else
            {
                Console.WriteLine("Invalid time format. Please use HH:MM:SS (24-hour).");
            }
        }
    }
}
