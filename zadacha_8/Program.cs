// Написать программу, которая на вход принимает число (N)
// а на выход показывает все четные числа от 1 до (N).


// Определение входного числа
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());


// Введение необходимых переменных
int result = number % 2;
int startNumber = 0;

// Добавил эту строку после написания программы для общего усвоения и понимания, 
// понимаю что это необязательно было
Console.WriteLine($"Вывелись все четные числа от 1 до {number}"); 

// Запуск цикла, который выводит все четные числа от 1 до N
while (startNumber < number -1) {
    if (result == 0)
    {
        startNumber = startNumber + 2;
        Console.WriteLine(startNumber);
    }
    else
    {
        startNumber = startNumber + 2;
        Console.WriteLine(startNumber);
    }
}