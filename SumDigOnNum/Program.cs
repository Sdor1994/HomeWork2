Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = a;
int s = 0;
 while (a > 0)
 {
 
     s = s + a % 10;
     a = a /10 ;
 
 }
 Console.WriteLine("Сумма чифр в числе "+b+" = "+s);