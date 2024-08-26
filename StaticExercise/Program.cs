namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(212);
            Console.WriteLine($"celsius {celsius}");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(100);
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
