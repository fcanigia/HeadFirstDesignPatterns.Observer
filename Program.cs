// See https://aka.ms/new-console-template for more information
using HeadFirstDesignPatterns.Observer;
using HeadFirstDesignPatterns.Observer.Observers;
using System;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

WeatherData weatherData = new WeatherData();

CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
HeatIndexDisplay heatIndex = new HeatIndexDisplay(weatherData); 

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);

Console.ReadKey();

