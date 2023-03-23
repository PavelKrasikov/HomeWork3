// Вводим число и выводим сумму цифр этого числа
Console.WriteLine("Enter number: ");
int A = Convert.ToInt32(Console.ReadLine());
int PrintSum(int numA)
{
    int Sum = 0;
    int i = 0;
    while (numA >= 1)
    {
    i = numA % 10;
    Sum = Sum + i;
    numA = numA/10;
    }
    return Sum;
}
Console.WriteLine("Сумма цифр числа " + A + " = " + $"{PrintSum(A)}");
