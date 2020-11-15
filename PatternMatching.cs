using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class PatternMatching
    {
        // DM NOTE: These two methods don't work for some reason...
        //public static decimal CalculateTollNew(object vehicle) => vehicle switch
        //{
        //    DeliveryTruck t when t.GrossWeightClass switch
        //    {
        //        > 5000 => 10.00m + 5.00m,
        //        < 3000 => 10.00m - 2.00m,
        //        _ => 10.00m,
        //        _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
        //    },
        //};

        //public static decimal CalculateTollNewV2(object vehicle) => vehicle switch
        //{
        //    DeliveryTruck t when t.GrossWeightClass switch
        //    {
        //        < 3000 => 10.00m - 2.00m,
        //        >= 3000 and <= 5000 => 10.00m,
        //        > 5000 => 10.00m + 5.00m,
        //        _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
        //    }
        //};

        public static decimal CalculateTollOld(object vehicle) => vehicle switch
        {
            DeliveryTruck t when t.GrossWeightClass > 5000 => 10.00m + 5.00m,
            DeliveryTruck t when t.GrossWeightClass < 3000 => 10.00m - 2.00m,
            DeliveryTruck _ => 10.00m,
            _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
        };

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
        }
    }
}
