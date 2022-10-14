//задача 2= принимает 2 числа,определяет какое большее и меньшее
Console.WriteLine("введите первое число: ");
int num1=int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число: ");
int num2=int.Parse(Console.ReadLine()!);
if (num1>num2)
{
  
    System.Console.WriteLine($"максимальное число {num1}");
}
else if(num1<num2)
{

    System.Console.WriteLine($"максимальное число {num2}");
}
else
{
    System.Console.WriteLine($"максимального числа нет, первое=второе");

}