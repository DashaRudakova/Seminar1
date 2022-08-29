// Задача 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 1;
bool not = true;

// Ввод данных
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Определение четности/нечетности числа
Console.WriteLine("Четные числа от 1 до " + num);

while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ",");
        not = false;
    }
    i ++;
}
if (not)
{
    Console.WriteLine("Нет четных чисел!");
}

