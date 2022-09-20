// Задача 4
// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// 2, 3, 7 => 7
Console.Clear();
Console.WriteLine("Вы находитесь в программе, вычисляющей большее из трех введенных чисел. Нажмите Enter, чтобы продолжить...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) {
    max = b;
}
if (c > max) {
    max = c;
}

Console.WriteLine($"Наибольшее число {max}");

