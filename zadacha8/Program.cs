// программа, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 1;

while (i <= N) {
if (i % 2 == 0) {
    System.Console.Write(i + " ");
}
i++;
}