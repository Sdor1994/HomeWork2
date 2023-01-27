Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
int i = 1;
int Q = 0;
while (i <= A)
{
    Q = i*i*i;
    if (Q%2 ==0 ) Console.WriteLine("Куб от четный "+i+" = "+Q );
    i++;
}