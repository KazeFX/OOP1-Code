// public abstract class Sensor
// {

//     public abstract string Unit { get; set; }
//     public abstract double ReadValue();
// }

// class TemperatureSensor : Sensor
// {
//     public override string Unit { get; set; } = "°C";

//     public override double ReadValue()
//     {
//         return (Double)Random.Shared.Next(-10, 51);
//     }
// }

// public class HumiditySensor : Sensor
// {
//     public override string Unit { get; set; } = "%";

//     public override double ReadValue()
//     {
//         return (double)Random.Shared.Next(0, 101);
//     }
// }   

// public class LightSensor : Sensor
// {
//     public override string Unit { get; set; } = "Lux";

//     public override double ReadValue()
//     {
//         return (double)Random.Shared.Next(0, 1001);
//     }
// }

// public class ProgramSensor
// {

//     static List<Sensor> sensors = new List<Sensor>
//         {
//             new TemperatureSensor(),
//             new HumiditySensor()
//         };

//     public static void Main()
//     {
//         foreach (Sensor sensor in sensors)
//         {
//             Console.WriteLine($"Sensor reading: {sensor.ReadValue()} {sensor.Unit}");
//         }
//     }
// }