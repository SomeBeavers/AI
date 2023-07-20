namespace Nuget;

public class ParentClassWithImplementation
{
    public virtual void MyCustomUtmostEffectiveSort(int[] arr)
    {
        int temp;
        for (var j = 0; j <= arr.Length - 2; j++)
        for (var i = 0; i <= arr.Length - 2; i++)
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
    }
}