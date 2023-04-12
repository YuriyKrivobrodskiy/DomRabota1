// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее

System.Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());

if ((a) == (b)) {
    System.Console.Write(a);
    System.Console.Write(" = ");
    System.Console.WriteLine(b);
}
else {
    if ( a > b ) {
        System.Console.Write("Max = ");
        System.Console.WriteLine(a);

        System.Console.Write("Min = ");
        System.Console.Write(b);
    }
    else {
        System.Console.Write("Max = ");
        System.Console.WriteLine(b);

        System.Console.Write("Min = ");
        System.Console.Write(a);
    }
}
