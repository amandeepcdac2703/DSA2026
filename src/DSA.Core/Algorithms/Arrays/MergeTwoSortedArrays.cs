public static class MergeTwoSortedArrays
{
    public static void Run()
    {
        // merge two sorted array
        int[] arr1 = [1,2,3,4,5,0];
        int[] arr2 = [56, 45, 34, 89];

        BubbleSort(arr1);
        BubbleSort(arr2);

        Console.WriteLine("After sorting the arrays are ");

        Console.WriteLine(string.Join(", ", arr1));
        Console.WriteLine(string.Join(", ", arr2));

        // merge two sorted array

        int[] arr3 = MergeSortedArrays(arr1, arr2);

        Console.WriteLine("After merging the array becomes: ");
        Console.WriteLine(string.Join(' ', arr3));
    }

    public static void BubbleSort(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            bool swapeed = false;

            for(int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    swapeed = true;
                    (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                }
            }

            if (!swapeed)
            {
                break;
            }
        }
    }

    public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] arr3 = new int[arr1.Length + arr2.Length];

        int i = 0, j = 0,  k = 0;

        while(i < arr1.Length &&  j < arr2.Length)
        {
            if (arr1[i] <= arr2[j])
            {
                arr3[k++] = arr1[i++];
            } else
            {
                arr3[k++] = arr2[j++];
            }
        }

        while(i < arr1.Length)
        {
            arr3[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            arr3[k++] = arr2[j++];
        }


        return arr3;
    }
}