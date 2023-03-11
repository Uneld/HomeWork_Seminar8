System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 7 || a < 1)
{
    System.Console.WriteLine("Wrong input");
}
else if (a == 6 || a == 7)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}