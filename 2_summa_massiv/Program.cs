// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void PrintArr(int[] array)
{
    foreach (int var in array) Console.Write(var + " ");
}

int[] arr = new int[12];
int len = arr.Length;
for (int i = 0; i < len; i++) arr[i] = new Random().Next(-9, 10);
PrintArr(arr);

int nNum = 0, pNum = 0;
foreach (int var in arr)
{
    if (var < 0) nNum += var;
    else pNum += var;
}
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел массива = {nNum}, сумма положительных чисел = {pNum}");