// Задача 4. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int num;

// Ввод данных
Console.WriteLine("Введите три числа: ");
int num_A = Convert.ToInt32(Console.ReadLine());
int num_В = Convert.ToInt32(Console.ReadLine());
int num_C = Convert.ToInt32(Console.ReadLine());

// Определение максимального числа
int max = num_A;

if (num_В > max)
{
    max = num_В;
}
if (num_C > max)
{
    max = num_C;
}

// Вывод ответа на экран
Console.WriteLine("Наибольшее из введенных чисел->" + max);

