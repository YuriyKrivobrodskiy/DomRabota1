// программа, которая принимает на вход число и выдает, является ли оно четным
System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
   {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
} 