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

    public static void quickSort(int[] arr)
    {
        quickSort(arr, 0, arr.Length - 1);
    }

    private static void quickSort(int[] arr, int low, int high)
    {
        if (low >= high)
            return;
        int pivotIndex = partition(arr, low, high);
        quickSort(arr, low, pivotIndex);
        quickSort(arr, pivotIndex + 1, high);
    }
    private static int partition(int[] arr, int low, int high)
    {
        int pivotIndex = low;
        int pivotValue = arr[low];

        while (low < high)
        {
            while (high > pivotIndex && arr[high] >= pivotValue)
                high--;
            if (high > pivotIndex)
            {
                arr[pivotIndex] = arr[high];
                arr[high] = pivotValue;
                pivotIndex = high;
            }
            while (low < pivotIndex && arr[low] <= pivotValue)
                low++;
            if (low < pivotIndex)
            {
                arr[pivotIndex] = arr[low];
                arr[low] = pivotValue;
                pivotIndex = low;
            }
        }
        return pivotIndex;
    }
    public static void heapSort(int[] arr)
    {
        for (int i = arr.Length / 2 - 1; i >= 0; i--)
        {
            maxHeap(arr, i, arr.Length);
        }
        for (int end = arr.Length - 1; end > 0; end--)
        {
            int temp = arr[end];
            arr[end] = arr[0];
            arr[0] = temp;
            maxHeap(arr, 0, end);
        }
    }

    public static void maxHeap(int[] arr, int node, int n)
    {
        int max = node;
        int left = (2 * node) + 1;
        int right = (2 * node) + 2;

        if (left < n && arr[left] > arr[max])
            max = left;
        if (right < n && arr[right] > arr[max])
            max = right;

        if (max != node)
        {
            int temp = arr[max];
            arr[max] = arr[node];
            arr[node] = temp;
            maxHeap(arr, max, n);
        }
    }
    public static void countingSort(int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
                return;
            else if (arr[i] > max)
                max = arr[i];
        }
        int[] numIndex = new int[max + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            numIndex[arr[i]]++;
        }
        int[] result = new int[arr.Length];
        for (int i = 0; i < numIndex.Length; i++)
        {
            if (numIndex[arr[i]] > 0)
            {
                result[numIndex[arr[i]]] = arr[i];
                numIndex[arr[i]]--;
            }
        }
        Array.Copy(result, arr, arr.Length);
    }


}