using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMethode : MonoBehaviour
{

    public int randomNumber;

    void Start()
    {
        randomNumber = Random.Range(0, 2);

        if(randomNumber % 2 == 0)
        {
            Booltrue();
        }

        else
        {
            Boolfalse();
        }
    }

    void Booltrue()
    {
        Debug.Log("true");
    }

    void Boolfalse()
    {
        Debug.Log("false");
    }
}
