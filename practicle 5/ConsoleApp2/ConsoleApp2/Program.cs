// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

int[] arr1 = new int[10];
Class1 arrMethods = new Class1();

for (int x = 0; x < arr1.Length; x++)
{
    Console.WriteLine("Enter value for index " + x + ":");
    arr1[x] = Convert.ToInt16(Console.ReadLine());
}

Console.WriteLine("Maximum Value: " + arrMethods.Max(arr1));
Console.WriteLine("Minimum Value: " + arrMethods.Min(arr1));
Console.WriteLine("Average Value: " + arrMethods.Avg(arr1));
