using System;

public static class Algorithms
{
    public static void selectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int min = i;
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                    min = j;
            }
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
}
