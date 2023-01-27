Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
int i = 1;
int Q = 0;
while (i <= A)
{
    Q = i*i*i;
    Console.WriteLine("Куб от "+i+" = "+Q );
    i++;
}