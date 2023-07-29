// See https://aka.ms/new-console-template for more information
// question 1
Console.Write("Enter the number 1 : ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number 2 : ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Sum = {0} ", n1 + n2);

//question 2
Console.Write("Enter the number 1 : ");
float n1 = float.Parse(Console.ReadLine());
Console.Write("Enter the number 2 : ");
float n2 = float.Parse(Console.ReadLine());
Console.Write("Summation = {0}", n1 + n2);
Console.Write("substraction = {0}", n1 - n2);
Console.Write("Multiplication = {0}", n1 * n2);
Console.Write("Devision = {0}", n1 / n2);

//question 3
Console.Write("Enter the Radius : ");
int rad = int.Parse(Console.ReadLine());

Console.Write("Area = {0}", 3.14 * rad * rad);
Console.Write("Circumference = {0}", 2 * 3.14 * rad);

//question 4
Console.Write("Enter the number : ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("The number is Even number");
}
else
{
    Console.Write("The number is ODD number");
}

//question 5
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter the value {0} : ", i);
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] % 2 == 0)
    {
        Console.WriteLine("The number {0} is Even number", j);
    }
    else
    {
        Console.WriteLine("The number {0} is ODD number", j);
    }
}
