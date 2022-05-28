﻿using CabInvoiceGenerator;
using CabInVoiceGeneratorProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInVoiceGeneratorProblem
{
    public class InvoiceGenerator
    {
        const int MIN_FARE = 5;
        const int FARE_PER_KM = 10;
        const int FARE_PER_MIN = 1;
        public double CalculateFare(int distance, int time)
        {
            double calulateFare = distance * FARE_PER_KM + time * FARE_PER_MIN;
            return Math.Max(calulateFare, MIN_FARE);
        }
        public double CalculateMultipleRides(Ride[] rides)
        {
            double result = 0;
            foreach (var data in rides)
            {
                result += CalculateFare(data.distance,data.time);
            }
            return result / rides.Length;

        }
        public InvoiceSummary MultipleRides(Ride[] rides)
        {
            double result = 0;
            foreach (var data in rides)
            {
                result += CalculateFare(data.distance, data.time);
            }
            return new InvoiceSummary(rides.Length, result);
        }
    }
}
       