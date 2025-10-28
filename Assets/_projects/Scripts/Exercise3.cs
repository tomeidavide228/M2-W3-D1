using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
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
        Debug.Log("The minimun number is " + FindMin(array));
        Debug.Log("The Maximum number is " + FindMax(array));

    }
    int[] GeneralArray(int dim, int min, int max)
    {
        int[] array= new int[dim];
        for (int i = 0; i < dim; i++) 
        {
            array[i] = Random.Range(min, max);
        }
        return array;
    }
    void PrintArray(int[] array)
    {
        for (int i = 0;i < array.Length;i++)
        {
            Debug.Log(array[i]);
        }
    }
    int FindMin(int[] array) 
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min)
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
