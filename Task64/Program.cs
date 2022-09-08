//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNaturalNumbers(int N, int M)
{
    if(N > M) ShowNaturalNumbers(N -1, M);

    Console.Write(N + " ");   
}

Console.WriteLine("Введите промежуток чисел, который задается M и N.");
Console.WriteLine("Введите M");
int NumM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int NumN = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {NumM}; N = {NumN}. -> ");
ShowNaturalNumbers(NumN, NumM);