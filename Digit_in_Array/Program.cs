void FillMas(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(15);
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
Console.Write("Введите искомую чифру: ");
int B = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);
Console.WriteLine(arr);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]==B) count= count+1;
    else count = count;
}
if (count >0) System.Console.WriteLine("Число "+B+" есть  массиве");
else System.Console.WriteLine ("Искомой чифры нет в массиве");
