// Программа, которая принимает на вход два числа и выдает какое
// число большее, а какое меньшее.

// Определение входных чисел
Console.WriteLine("Введите два числа: ");

int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());

// Проверка условия задачи и вывод
if(number_1 > number_2)
{
    Console.WriteLine($"{number_1} Большее число, а {number_2} меньшее");
}

if(number_1 < number_2)
{
    Console.WriteLine($"{number_2} Большее число, а {number_1} меньшее");
}