// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] GenerateArr(int n, int min, int max)  // генерирует массив со случаными от min до max
{
    double[] arrNum = new double[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

void PrintArray(double[] arr) // Выводит массив на экран
{
    for (int i = 0; i < arr.Length; Console.Write(arr[i++] + " ")) { }
}


int countChet(double[] arr) // Считает количество чётных элементов массива
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) counter++;
    }
    return counter;
}

double sumChet(double[] arr, bool chetNechet) // Считает сумму четных (true) или нечетных (false) элементов массива 
{
    double counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((!(i % 2 == 0 ^ chetNechet))) counter = counter + arr[i];
    }
    return counter;

}

double ArrMinMax(double[] arr, bool MinMax) // MinMax = true - min, false - max
{

    int i = 1;
    double result = arr[0];

    while (i < arr.Length)
    {
        switch (MinMax)
        {
            case true:
                if (arr[i] < result) result = arr[i];
                // Console.WriteLine(MinMax + "  " + i);
                break;

            case false:
                if (arr[i] > result) result = arr[i];
                //Console.WriteLine(MinMax + "  " + i);
                break;
            default:
                Console.WriteLine("Какая то  фигня c переменной MinMax!");
                break;
        }
        i++;
    }
    return result;
}



int TaskNum = 34;
int n;
Console.Write("Введите размерность массива: ");
while (!Int32.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}
Console.Write("Введите номер задачи (34, 36 или 38): ");
while (!Int32.TryParse(Console.ReadLine(), out TaskNum))
{
    Console.WriteLine($"Ввод неверный. - {TaskNum} Пожалуйста, введите целое");
}

double[] Array = new double[n];
switch (TaskNum)
{
    case 34:
        Console.WriteLine("Задача 34: Массив заполняется случайными положительными трёхзначными числами. Выводтся количество чётных чисел в массиве.");
        Console.WriteLine();
        Array = GenerateArr(n, 100, 999);
        PrintArray(Array);
        Console.WriteLine();
        Console.WriteLine("Количество чётных в массиве:" + countChet(Array));

        break;
    case 36:

        Console.WriteLine("Задача 36: Одномерный массив заполненняется случайными числами. Выводится сумма элементов, стоящих на нечётных позициях");
        Console.WriteLine();
        Array = GenerateArr(n, -999, 999);
        PrintArray(Array);
        Console.WriteLine();
        Console.WriteLine("Сумма элементов на нечетных позициях:" + sumChet(Array, false));
        break;
    case 38:
        Console.WriteLine("Задача 38: Задаётся массив вещественных чисел. Находится разница между максимальным и минимальным элементами массива.");
        Console.WriteLine();
        Array = GenerateArr(n, -999, 999);
        PrintArray(Array);
        Console.WriteLine();
        Console.WriteLine("Разница между максимальным (" + ArrMinMax(Array, false) + ") и минимальным (" + ArrMinMax(Array, true) + ") элементами  равна: " + (ArrMinMax(Array, false) - ArrMinMax(Array, true)));
        break;
    default:
        Console.WriteLine("Такой задачки нет! Обратитесь к разработчику!");
        break;
}
