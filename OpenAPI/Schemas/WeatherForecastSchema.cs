using System;
using OpenAPI.Models;
using System.Numerics;

namespace OpenAPI.Schemas
{
    public class WeatherForecastSchema : WeatherForecast
    {
        public new AnySchema Summary { get; }
        public BigInteger PreciseTemperature { get; }
    }
}