// программа, которая принимает на вход три чиссла и выдаёт макимальное из них
System.Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе чило ");
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine());

int max =a;

if ( b > max ) max = b;
if ( c > max ) max = c;
Console.Write("max = ");
Console.Write(max);