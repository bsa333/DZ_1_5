//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] GetPairMult(int[] array)
{
    int size = 0;
    int[] result = null;

    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
        result = new int[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = array[i] * array[array.Length - i -1];
        }
    }
    else
    {
        size = (array.Length / 2) + 1;
        result = new int[size];

        for (int i = 0; i < size; i++)
        {
            if (i == ( size - 1))
            {
                result[i] = array[i];
            }
            else
            {
                result[i] = array[i] * array [size - i - 1];
            }
        }
     
    }
    return result;
}

int[] array = new int[] { 1, 4, 6, 3, 7 };
int[] result = GetPairMult(array);

Console.WriteLine("");