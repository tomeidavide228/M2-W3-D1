using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    [SerializeField] private int dim;
    [SerializeField] private int min;
    [SerializeField] private int max;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneralArray(dim, min, max);
        Debug.Log("Array Print");
        PrintArray(array);
        FindMin2(array);
        FindMax2(array);

    }
    int[] GeneralArray(int dim, int min, int max)
    {
        int[] array = new int[dim];
        for (int i = 0; i < dim; i++)
        {
            array[i] = Random.Range(min, max);
        }
        return array;
    }
    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }
    int FindMin(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    void FindMin2(int[] array)
    {
        int min = array[0];
        int min2 = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            {
                min2 = min;
                min = array[i];
            }
        }
        Debug.Log("The two minimum numbers are " + min2 + " and " + min);

    }
    void FindMax2(int[] array)
    {
        int max = array[0];
        int max2 = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max2 = max;
                max = array[i];
            }
        }
        Debug.Log("The two maximum numbers are " + max2 + " and " + max);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
