using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIfElsePrac : MonoBehaviour
{
    public int I = 1;

    void Start()
    {
        if (I == 1)
        {
            Debug.Log("Done" + " " + I);
        }

        else if (I == 2)
        {
            Debug.Log("Done" + " " + I);
        }

        else
        {
            Debug.Log("Done" + " " + I);
        }
    }

}
