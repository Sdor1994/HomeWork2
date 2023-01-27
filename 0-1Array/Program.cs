void FillMas(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(2);
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
System.Console.WriteLine(arr);