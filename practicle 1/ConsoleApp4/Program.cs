// See https://aka.ms/new-console-template for more information
//question1

Console.Write("Enter the name : ");
string name = Console.ReadLine();
Console.Write("Enter the batch : ");
string batch = Console.ReadLine();
Console.WriteLine(" I am"+name ,"my batch is "+batch);

//question 2
Console.Write("Enter circle radius: ");
float radius = float.Parse(Console.ReadLine());
Console.Write("The area of the circle is {0} ", 3.14 * radius * radius);

//question 3
Console.WriteLine("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number:  ");
int num2 = int.Parse(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine("Sum is "+sum);

//question 4
Console.Write("Enter the salary : ");
float salary = float.Parse(Console.ReadLine());
Console.Write("Enter the Tax rate : ");
float tax = float.Parse(Console.ReadLine());

float tax_payment = salary * tax / 100;
float amout_remain = salary - tax_payment;

Console.Write("The salary after the Tax = {0}", amout_remain);

