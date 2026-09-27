using System;
using System.Threading;

namespace YRTCargoMonitor
{
    class Program
    {
        // -----------------------------------------------------------------------------
        // YRT PROTOTYPE STARTER: MEDICAL CARGO MONITOR
        // Goal: Implement your Draw.io logic to track consecutive temperature breaches.
        // -----------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("--- YRT Cargo Monitor (Alpha Build) ---");
            Console.WriteLine("System Initializing...\n");

            // SIMULATED SENSOR DATA
            // This array represents temperature readings taken every 1 minute.
            // Notice the spike at reading 3, and the sustained high temperatures later.
            double[] sensorReadings = { 4.5, 5.2, 9.1, 7.8, 6.0, 8.2, 8.5, 9.0, 7.0, 4.2 };

            // YOUR VARIABLES GO HERE
            // Think about what you need to track. (e.g., current temp, warning count, threshold)
            double maxTempThreshold = 8.0;
            // int consecutiveMinutesHigh = ???;

            Console.WriteLine($"Alert Threshold set to: > {maxTempThreshold}°C for more than 2 consecutive minutes.");
            Console.WriteLine("Starting simulation...\n");

            // MAIN SENSOR LOOP
            for (int i = 0; i < sensorReadings.Length; i++)
            {
                double currentTemp = sensorReadings[i];
                Console.Write($"Minute {i + 1}: Reading {currentTemp}°C... ");

                // ---------------------------------------------------------
                // STUDENT TASK: IMPLEMENT THE LOGIC FROM YOUR ECN / DRAW.IO
                // ---------------------------------------------------------

                // 1. Is the temperature above the threshold?

                // 2. If yes, increment your counter. If no, reset it to zero.

                // 3. Has the counter breached the 2-minute rule?
                //    If yes, call the TriggerAudioAlarm() method and reset the counter.



                // --- Delete this placeholder line once your logic is in ---
                Console.WriteLine("[Status OK]");


                // ---------------------------------------------------------
                // END OF STUDENT LOGIC
                // ---------------------------------------------------------

                // Pauses the console for 1 second to simulate real-time checking
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nSimulation Complete. Cargo reached destination.");
            Console.ReadLine();
        }

        // HELPER METHOD: Do not change this. Call it when your logic dictates an alert is needed.
        static void TriggerAudioAlarm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[!!! ALARM TRIGGERED !!!] - CARGO INTEGRITY COMPROMISED");
            Console.ResetColor();
            // Simulate playing an audio file to the cab
            Console.Beep(1000, 500);
            Console.Beep(1000, 500);
        }
    }
}