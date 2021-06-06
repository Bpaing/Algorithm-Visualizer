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
        for (int i = 1; i < arr.Length; i++)
        {
            int value = arr[i];
            int j = i - 1;
            while (j > -1 && value < arr[j])
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = value;
        }
    }

    public static void mergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return;
        }

        int[] leftHalf = new int[arr.Length / 2];
        int[] rightHalf = new int[arr.Length - leftHalf.Length];
        for (int l = 0; l < leftHalf.Length; l++)
        {
            leftHalf[l] = arr[l];
        }
        for (int r = 0; r < rightHalf.Length; r++)
        {
            rightHalf[r] = arr[leftHalf.Length + r];
        }

        mergeSort(leftHalf);
        mergeSort(rightHalf);
        int f = 0, s = 0, n = 0;
        while (f < leftHalf.Length && s < rightHalf.Length)
        {
            if (leftHalf[f] < rightHalf[s])
            {
                arr[n++] = leftHalf[f++];
            }
            else
            {
                arr[n++] = rightHalf[s++];
            }
        }
        while (f < leftHalf.Length)
        {
            arr[n++] = leftHalf[f++];
        }
        while (s < rightHalf.Length)
        {
            arr[n++] = rightHalf[s++];
        }
    }

    public static void quickSort(int[] arr, int low, int high)
    {
        if (arr.Length == 1)
        {
            return;
        }
        int piv = partition(arr, low, high);
        quickSort(arr, 0, piv);
        quickSort(arr, piv, high);
    }

    private static int partition(int[] arr, int low, int high)
    {
        Random rand = new Random();
        int pivot = rand.Next(low, high);
        int leftMarker = low, rightMarker = high;
        while (leftMarker < pivot && rightMarker > pivot)
        {
            while (arr[leftMarker] < arr[pivot])
                leftMarker++;
            while (arr[rightMarker] >= arr[pivot])
                rightMarker--;
            if (arr[leftMarker] >= arr[pivot] && arr[rightMarker] <= arr[pivot])
            {
                int temp = arr[leftMarker];
                arr[leftMarker] = arr[rightMarker];
                arr[rightMarker] = temp;
            }
        }
        if (arr[pivot] < arr[leftMarker])
        {
            int temp = arr[leftMarker];
            arr[leftMarker] = arr[pivot];
            arr[pivot] = temp;
        }
        pivot = leftMarker;
        return pivot;
    }

}
