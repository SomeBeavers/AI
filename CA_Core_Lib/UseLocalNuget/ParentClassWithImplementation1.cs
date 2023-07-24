namespace CA_Core_Lib.UseLocalNuget;

public class ParentClassWithImplementation1
{
    public virtual void MyCustomUtmostEffectiveSort(int[] arr)
    {
        for (int index1 = 0; index1 <= arr.Length - 2; ++index1)
        {
            for (int index2 = 0; index2 <= arr.Length - 2; ++index2)
            {
                if (arr[index2] > arr[index2 + 1])
                {
                    int num = arr[index2 + 1];
                    arr[index2 + 1] = arr[index2];
                    arr[index2] = num;
                }
            }
        }
    }
}