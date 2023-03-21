// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first digit: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second digit: ");
int B = Convert.ToInt32(Console.ReadLine());
double i = Math.Pow(A,B);
Console.WriteLine("Число " + A + " в степени " + B + " = " + i);
