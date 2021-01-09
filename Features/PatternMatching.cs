using System;

using static System.Console;

namespace CSharp9
{
    public class PatternMatching
    {
        public static void Run()
        {
            WriteLine(nameof(PatternMatching));

            PrintToll(new Car { Passengers = 0 });
            PrintToll(new Car { Passengers = 1 });
            PrintToll(new Car { Passengers = 2 });
            PrintToll(new Car { Passengers = 3 });

            PrintToll(new Taxi { Fares = 0 });
            PrintToll(new Taxi { Fares = 1 });
            PrintToll(new Taxi { Fares = 2 });
            PrintToll(new Taxi { Fares = 3 });

            PrintToll(new Bus { Capacity = 10, Riders = 4 });
            PrintToll(new Bus { Capacity = 10, Riders = 8 });

            PrintToll(new DeliveryTruck { GrossWeightClass = 9000 });
            PrintToll(new DeliveryTruck { GrossWeightClass = 4000 });
            PrintToll(new DeliveryTruck { GrossWeightClass = 2000 });

            // Uncomment to test NULL patterns
            //PrintToll(new object());
            //PrintToll(null);

            static void PrintToll(object obj) => WriteLine(TollCalculator.CalculateToll(obj));
        }

        public static class TollCalculator
        {
            public static decimal CalculateToll(object vehicle) =>
                vehicle switch
                {
                    Car c => c.Passengers switch
                    {
                        0 => 2.00m + 0.5m,
                        1 => 2.0m,
                        2 => 2.0m - 0.5m,
                        _ => 2.00m - 1.0m
                    },

                    Taxi { Fares: 0 } => 3.50m + 1.00m,
                    Taxi { Fares: 1 } => 3.50m,
                    Taxi { Fares: 2 } => 3.50m - 0.50m,
                    Taxi => 3.50m - 1.00m, // Discard no longer needed

                    Bus(var c, var r) when ((double)r / c) < 0.50 => 5.00m + 2.00m,
                    Bus(var c, var r) when ((double)r / c) >= 0.50 => 5.00m - 1.00m,
                    Bus => 5.00m,  // Discard no longer needed

                    // Nested switch which simplifies over C# 8
                    DeliveryTruck t => t.GrossWeightClass switch
                    {
                        > 5000 => 10.00m + 5.00m,
                        >= 3000 and <= 5000 => 10.00m, // new AND pattern
                        < 3000 => 10.00m - 2.00m,
                    },

                    // New NOT pattern
                    not null => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),

                    // New NULL pattern
                    null => throw new ArgumentNullException(nameof(vehicle))
                };
        }

        public class Car
        {
            public int Passengers { get; set; }
        }

        public class DeliveryTruck
        {
            public int GrossWeightClass { get; set; }
        }

        public class Taxi
        {
            public int Fares { get; set; }
        }

        public class Bus
        {
            public int Capacity { get; set; }
            public int Riders { get; set; }

            public void Deconstruct(out int capacity, out int riders)
            {
                capacity = Capacity;
                riders = Riders;
            }
        }

        private enum TimeBand
        {
            MorningRush,
            Daytime,
            EveningRush,
            Overnight
        }

        private static TimeBand GetTimeBand(DateTime timeOfToll)
        {
            int hour = timeOfToll.Hour;
            if (hour < 6)
                return TimeBand.Overnight;

            if (hour < 10)
                return TimeBand.MorningRush;

            if (hour < 16)
                return TimeBand.Daytime;

            if (hour < 20)
                return TimeBand.EveningRush;

            return TimeBand.Overnight;
        }

        private static bool IsWeekDay(DateTime timeOfToll) =>
            timeOfToll.DayOfWeek switch
            {
                DayOfWeek.Saturday => false,
                DayOfWeek.Sunday => false,
                _ => true,
            };

        public static decimal PeakTimePremium(DateTime timeOfToll, bool inbound) =>
            (IsWeekDay(timeOfToll), GetTimeBand(timeOfToll), inbound) switch
            {
                (true, TimeBand.MorningRush, true) => 2.00m,
                (true, TimeBand.Daytime, _) => 1.50m,
                (true, TimeBand.EveningRush, false) => 2.00m,
                (true, TimeBand.Overnight, _) => 0.75m,
                (_, _, _) => 1.00m,
            };
    }
}
