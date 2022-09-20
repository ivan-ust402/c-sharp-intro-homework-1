// Задача 2
// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше 
// a = 5, b = 7 => max = 7, min = 5
Console.Clear();
Console.WriteLine("Вы находитесь в программе, вычисляющей большее из двух введенных чисел. Нажмите Enter, чтобы продолжить...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) {
    Console.WriteLine($"max = {a}, min = {b}");
} else {
    Console.WriteLine($"max = {b}, min = {a}");
}
