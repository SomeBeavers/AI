﻿namespace Core_Lib_Referenced;

public class ParentClassFromReferencedProject
{
    public virtual void CustomSort(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
        {
            var key = arr[i];
            var j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }
}