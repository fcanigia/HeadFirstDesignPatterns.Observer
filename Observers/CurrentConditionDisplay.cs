// See https://aka.ms/new-console-template for more information

using HeadFirstDesignPatterns.Observer.Abstract;

namespace HeadFirstDesignPatterns.Observer.Observers
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            temperature = weatherData.GetTemperature();
            humidity = weatherData.GetHumidity();
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }

    }
}