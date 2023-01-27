Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int B = int.Parse(Console.ReadLine());
int i = 1;
int Q = 1;
while (i <= B)
{
    Q = Q * A;
    i++;
}
Console.WriteLine(A + " В степени "+ B +" = "+Q );