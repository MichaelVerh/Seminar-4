// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число A");
int NumberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число B");
int NumberB=Convert.ToInt32(Console.ReadLine());
int result=1;
for (int i=0; i<NumberB; i++)
{
    result*=NumberA;
}
Console.WriteLine($"Число {NumberA} в степени {NumberB} равно {result}");