using System;
using OpenAPI.Models;
using System.Numerics;

namespace OpenAPI.Schemas
{
    public class WeatherForecastSchema : WeatherForecast
    {
        public new Object Summary { get; }
        public BigInteger PreciseTemperature { get; }
    }
}