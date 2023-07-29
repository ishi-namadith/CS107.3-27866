// See https://aka.ms/new-console-template for more information
Console.Write("Enter the distance in kilometers: ");
double kilometers = double.Parse(Console.ReadLine());
ConvertValues converter = new ConvertValues();
converter.KilometerToMeter(kilometers);
