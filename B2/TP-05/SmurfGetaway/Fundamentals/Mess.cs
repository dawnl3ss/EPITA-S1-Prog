namespace SmurfGetaway.Fundamentals;

public class Mess
{
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    var tempVar = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tempVar;
                }
            }    
        }
    }

    public static int[] ArrayMerge(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];

        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] <= arr2[j])
            {
                mergedArray[k] = arr1[i];
                i++;
            }
            else
            {
                mergedArray[k] = arr2[j];
                j++;
            }
            k++;
        }

        while (i < arr1.Length)
        {
            mergedArray[k] = arr1[i];
            i++;
            k++;
        }

        while (j < arr2.Length)
        {
            mergedArray[k] = arr2[j];
            j++;
            k++;
        }

        return mergedArray;
    }

    public static int MatEquals(int[,] mat1, int[,] mat2)
    {
        int rows1 = mat1.GetLength(0);
        int rows2 = mat2.GetLength(0);
        int cols1 = mat1.GetLength(1);
        int cols2 = mat2.GetLength(1);

        if (rows1 != rows2 || cols1 != cols2)
            return -1;

        int diffCount = 0;

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                if (mat1[i, j] != mat2[i, j])
                    diffCount++;
            }
        }

        return diffCount;
    }
}