Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
int i = 1;
int Q = 0;
while (i <= A)
{
    Q = Q + i;
    i++;
}
Console.WriteLine("Сумма чисел от 1 до "+ A +" = "+Q );