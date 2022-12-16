// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] Array = new int [8];
ArrayNew(Array);
PrintArray(Array);

void ArrayNew (int[] x)
{
    for(int i =0; i<x.Length;i++)
    { x[i] = new Random().Next(0,100);}
}

void PrintArray (int [] x)
{
     for(int i =0; i<x.Length;i++)
     { Console.Write ($"{x[i]} ");}
}

