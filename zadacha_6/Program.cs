// Программа, которая на вход принимает число и выдает -
// является ли число четным (делится ли оно на два без остатка)

// Определение входного числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

// Получаем значение половины числа c остатком
int result = number % 2;


// Специально не ставил фигурные скобки,
// а до этого также работало с фигурными, жду обратную связь почему и так и так можно
if (result == 0) // проверяется условие задачи, здесь также можно писать комментарий к строке как я понял

    Console.WriteLine($"{number} Является четным числом");

else

    Console.WriteLine($"{number} Не является четным числом");
