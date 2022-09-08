//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AckermanFunc(int M, int N)
{
  if(M == 0) return N + 1;
  else 
    if (N == 0) return AckermanFunc(M - 1, 1);
  else 
    return AckermanFunc(M - 1, AckermanFunc(M, N - 1));
}

Console.WriteLine("Введите два неотрицательных числа M и N.");
Console.WriteLine("Введите M");
int NumM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int NumN = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {NumM}; n = {NumN}. -> ");
Console.Write($"A(m,n) = " + AckermanFunc(NumM, NumN));



