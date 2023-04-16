// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

 System.Console.WriteLine("Введите трёхзначное число: ");
 int number = int.Parse(Console.ReadLine());
 int i;

 if (number > 99 && number < 1000)
 {
    i = number % 100;
    i = i / 10;
    System.Console.WriteLine(i);
 }
 else
 {
    System.Console.WriteLine("Вы ввели не трёхзначное число.");
 }