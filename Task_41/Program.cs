// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел: ");
int count = int.Parse(Console.ReadLine());

int[] numbers = new int[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int positiveCount = CountPositive(numbers);
Console.WriteLine($"Количество положительных чисел: {positiveCount}");

Console.ReadKey();


int CountPositive(int[] numbers)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number > 0)
        {
            count++;
        }
    }

    return count;
}
