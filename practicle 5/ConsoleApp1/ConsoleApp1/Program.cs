// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

int choice, num1, num2;
CalculateValues calc=new CalculateValues();
Console.WriteLine("1.Addition");
Console.WriteLine("2.Substraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Division");
Console.WriteLine("Enter the number of the operation u need to perform");
choice =int.Parse(Console.ReadLine());
Console.WriteLine("enter first number");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number");
num2= int.Parse(Console.ReadLine());

if (choice== 1)
{
   Console.WriteLine(calc.Add(num1,num2));
}
if (choice== 2)
{
    Console.WriteLine(calc.Sub(num1, num2));
}
if(choice== 3)
{
   Console.WriteLine( calc.Mult(num1, num2));
}
if( choice== 4)
{
   Console.WriteLine( calc.Div(num1, num2));
}
Console.ReadKey();