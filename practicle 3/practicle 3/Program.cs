// See https://aka.ms/new-console-template for more information
// question 1
Console.WriteLine("Enter the Number :");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Even Number");
}
else
{
    Console.WriteLine("ODD Number");
}

//question 2
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();
int vowelCount = 0;
for (int i = 0; i < str.Length; i++)
{
    char ch = str[i];

    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
    {
        vowelCount++;
    }
}
Console.WriteLine("The number of vowels in the string is"+vowelCount);

//question 3
Console.WriteLine("Enter a Number:");
int num = int.Parse(Console.ReadLine());

int total = 0;
while (num > 0)
{
    int digit = num % 10;
    total += digit;
    num /= 10;
}

Console.WriteLine("Sum of the Digit = " +total);

//question 4
Console.WriteLine("Enter a Number:");
int num = int.Parse(Console.ReadLine());

int total = 0;

while (num > 0)
{
    int digit = num % 10;

    if (num % 2 == 1)
    {
        total += digit;
    }
    num /= 10;
}

Console.WriteLine("Sum of the Digit = {0}", total);
