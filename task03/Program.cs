// Задача 8
// Напишите программу, которая на вход принимает число N, а на выход выдает все четные числа от 1 до N
// 5 -> 2, 4 
// 8 -> 2, 4, 6, 8 
Console.Clear();
Console.WriteLine("Вы находитесь в программе, которая принимает на вход число N, а на выход выдает все четные числа от 1 до N. Нажмите Enter, чтобы продолжить...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

for (int i = 2; i <= a; i=i+2) {
    Console.Write(i + ", ");
}

