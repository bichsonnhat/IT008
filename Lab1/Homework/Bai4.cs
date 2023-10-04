using System;
using System.Text;
using System.Threading;

public class NhietKe
{
    public event EventHandler<double> TemperatureChanged;
    private Random random = new Random();
    private double temperature;

    public double Temperature
    {
        get { return temperature; }
        private set
        {
            temperature = value;
            OnTemperatureChanged(temperature);
        }
    }

    public void RandomTemperature()
    {
        Temperature = 35 + random.NextDouble() * (42 - 35);
    }

    protected virtual void OnTemperatureChanged(double newTemperature)
    {
        TemperatureChanged?.Invoke(this, newTemperature);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        NhietKe nhietke = new NhietKe();

        nhietke.TemperatureChanged += (sender, temperature) =>
        {
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.WriteLine($"Nhiệt độ hiện tại: {temperature:F2}°C");
        };

        while (true)
        {
            nhietke.RandomTemperature();
            Thread.Sleep(1000);
        }
    }
}
