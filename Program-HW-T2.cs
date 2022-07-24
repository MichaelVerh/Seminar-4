// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
Console.WriteLine("Введите число");
int Number=Convert.ToInt32(Console.ReadLine());
int sum=0;
while(Number>0)
{
    sum+=Number%10;
    Number/=10;
}
Console.WriteLine($"Сумма цифр в числе {Number} равна {sum}");