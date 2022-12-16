/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе = {GetSummCount(A)}");

int GetSummCount (int number)
{
    
    int sum =number%10;
    while (number>0)
    {
        number = number/10;
        sum = sum + number%10;
        
    }
    return sum;

}