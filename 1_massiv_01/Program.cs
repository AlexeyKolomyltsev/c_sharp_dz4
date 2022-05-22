// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void PrintArr(int[] array)
{
    foreach(int var in array) Console.Write(var + " ");
}

int[] arr01 = new int[8];
int len = arr01.Length;
for (int i = 0; i < len; i++) arr01[i] = new Random().Next(0,2);

PrintArr(arr01);