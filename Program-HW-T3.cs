// Напишите программу, котрая задает массив из 8 случайных целых чисел и выводит отредактированный по модулю массив.
int[] array=new int[8];
Random random=new Random();
for(int i=0; i<array.Length; i++)
{
    array[i]=random.Next(-10,10);
}
Console.WriteLine ("Вывод начального массива");
for(int i=0; i<array.Length; i++)
{
    Console.Write (array[i]+"\t");
}
Console.WriteLine();
for (int i=array.Length-1; i>0; i--)
{
    for (int j=0; j<i; j++)
    {
        if (Math.Abs(array[j])>Math.Abs(array[j+1]))
        {
            int temp=array[j];
            array[j]=array[j+1];
            array[j+1]=temp;
        }
    }
}
Console.WriteLine ("Вывод отсортированного по модулю массива");
for(int i=0; i<array.Length; i++)
{
    Console.Write (array[i]+"\t");
}
Console.WriteLine();