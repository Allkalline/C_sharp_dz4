/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел равна = {GetStepen(A)}");


int GetStepen (int number)
{
    
    int result =1;
    int i = 1;
    while (i<=B)
    {
        
        result = result * number;
        i++;
        
    }
    return result;

}



