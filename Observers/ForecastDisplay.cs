// See https://aka.ms/new-console-template for more information

using HeadFirstDesignPatterns.Observer.Abstract;

namespace HeadFirstDesignPatterns.Observer.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.GetPressure();
            Display();
        }

        public void Display()
        {
            var forecast = "Forecast: ";

            if (currentPressure > lastPressure)
            {
                forecast += "Improving weather on the way!";
            }
            else if (currentPressure == lastPressure)
            {
                forecast += "More of the same";
            }
            else if (currentPressure < lastPressure)
            {
                forecast += "Watch out for cooler, rainy weather";
            }

            Console.WriteLine(forecast);
        }
    }
}