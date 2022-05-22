// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void PrintArr(int[] array)
{
    foreach (int var in array) Console.Write(var + " ");
}

int[] arr = new int[123];
int len = arr.Length;
for (int i = 0; i < len; i++) arr[i] = new Random().Next(-500, 501);
PrintArr(arr);

int Count = 0;  //Инициализация счетчика
foreach (int var in arr) if (var > 9 && var < 100) Count += 1;
Console.WriteLine();
Console.WriteLine($"Количество элементов массива из отрезка [10,99] = {Count}");