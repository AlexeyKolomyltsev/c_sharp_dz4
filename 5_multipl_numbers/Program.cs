// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void PrintArr(int[] array)
{
    foreach (int var in array) Console.Write(var + " ");
}

Console.Write("Задайте длину массива, который будет заполнен случайными числами от -9 до 50 = ");
int len = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[len];
for (int i = 0; i < len; i++) arr[i] = new Random().Next(-9, 51);
Console.Write("Массив: ");
PrintArr(arr);

int lenMult = len / 2;           // инициализация массива, заполненного перемножениями пар оригинального массива
int[] arrMult = new int[lenMult];
for (int i = 0; i < lenMult; i++)
{
    arrMult[i] = arr[i] * arr[^(i + 1)];
}

Console.WriteLine();
Console.Write("Массив перемножения пар: ");
PrintArr(arrMult);