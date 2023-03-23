// Вводим два числа А и В и возводим число А в степень В
Console.WriteLine("Enter first digit: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second digit: ");
int B = Convert.ToInt32(Console.ReadLine());

double PrintNum (double A1, double B1)
{
   double i = Math.Pow(A1,B1);
   return i;
}
Console.WriteLine("Число " + A + " в степени " + B + " = " + $"{PrintNum(A, B)}");

