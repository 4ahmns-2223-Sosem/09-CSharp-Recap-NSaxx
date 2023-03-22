using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArray : MonoBehaviour
{

    string[] MyTest = new string[6];

    void Start()
    {
        for (int i = 0; i < MyTest.Length; i++)
        {
            if(i % 2 ==0)
            {
                Debug.Log(i + " " + "is an evenNumber");
            }

            else
            {
                Debug.Log(i + " " + "is an unevenNumber");
            }

        }

    }


}
