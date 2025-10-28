using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    [SerializeField] private int n;
    [SerializeField] private int y;
    [SerializeField] private int x;

    // Start is called before the first frame update
    void Start()
    {
        if (IsEven(n) == true)
        {
            Debug.Log("The number " + n + " is even");
        }
        else
        {
            Debug.Log("The number " + n + " is odd");
        }
        if (IsMultipleOf(y, x) == true)
        {
            Debug.Log("The number " + y + " is multiple of the number " + x);
        }
        else
        {
            Debug.Log("The number " + y + " is not mulitple of the number " + x);
        }
    }

    bool IsEven(int number)
    {
        if ((number % 2) == 0)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

    bool IsMultipleOf(int baseNumber, int multiple)
    {
        if ((baseNumber % multiple) == 0)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
