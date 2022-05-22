// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void PrintArr(int[] array)
{
    foreach (int var in array) Console.Write(var + " ");
}

int[] arr = new int[20];
int len = arr.Length;
for (int i = 0; i < len; i++) arr[i] = new Random().Next(100, 1000);
PrintArr(arr);

int CountEven = 0, CountOdd = 0;  //Инициализация счетчика
foreach (int var in arr)
{
    if (var % 2 == 0) CountEven += 1;
    else CountOdd += 1;
}
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива = {CountEven}, нечетных = {CountOdd}");