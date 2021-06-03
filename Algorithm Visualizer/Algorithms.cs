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

    public static void bubbleSort(int[] arr)
    {
        Boolean swap = true;
        while (swap) {
            swap = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swap = true;
                }
            }
        }
    }

    public static void insertionSort(int[] arr)
    {

    }


}
