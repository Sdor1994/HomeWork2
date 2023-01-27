void FillMas(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(20);
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
int Summ = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i%2==0) Summ = Summ+ arr[i]; 
    if (i%2==0) Console.WriteLine(arr[i]);
    
}
Console.WriteLine("Сумма чисел на нечентых позициях = "+Summ);

