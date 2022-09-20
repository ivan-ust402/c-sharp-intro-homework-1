// Задача 6
// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на два без остатка)
// 4 -> да 
// -3 -> нет 
Console.Clear();
Console.WriteLine("Вы находитесь в программе, определяющей четность числа. Нажмите Enter, чтобы продолжить...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {
    Console.WriteLine($"Число {a} - четное");
} else {
    Console.WriteLine($"Число {a} - нечетное");
}
