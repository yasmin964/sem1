Console.WriteLine("введите число");
int n=int.Parse(Console.ReadLine()!);
int n1=1;
while (n1<=n)
{
    n1+=1;
    System.Console.WriteLine($"все четные {n1%2==0}");
}
