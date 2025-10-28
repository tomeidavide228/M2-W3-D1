using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    [SerializeField] private int dim;
    // Start is called before the first frame update
    void Start()
    {
        int[] array = GeneralArray(5, 1, 10);
        PrintArray(array);
        array = ChangeDimArray(array, dim);
        Debug.Log("New array with dimension " + dim);
        PrintArray(array);

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

    int[] ChangeDimArray(int[] array, int dim)
    {
        if (array.Length > dim)
        {
            int[] newarray = new int[dim];
            for (int i = 0; i < newarray.Length; i++)
            {
                newarray[i] = array[i];
            }
            return newarray;
        }
        else if (array.Length < dim)
        {
            int[] newarray = new int[dim];
            for (int i = 0; i < newarray.Length; i++)
            {
                if (i < array.Length)
                {
                    newarray[i] = array[i];
                }
                else
                {
                    newarray[i] = 0;
                }
            }
            return newarray;
        }
        else
        {
            return array;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}