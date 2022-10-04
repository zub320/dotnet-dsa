Console.WriteLine("To check if a number is prime or not. \r\n");
Console.Write("Enter a Number: ");
int number = int.Parse(Console.ReadLine()!);

if(MyMath.IsPrime(number))
{
    Console.Write("Number is Prime.");
}
else
{
    Console.Write("Number is not Prime.");
}

Console.ReadKey();