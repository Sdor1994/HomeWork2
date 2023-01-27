void FillMas(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(100,999);
        arr[i] = num;
    }
}

void PrintMas(int[] arr){
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}


Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);
Console.WriteLine(arr);
int countA = 0;
int countB = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2==0) countA= countA+1;
    else countB = countB+1;
}
System.Console.WriteLine("Четных: "+countA);
System.Console.WriteLine ("Нечетных: "+countB);
