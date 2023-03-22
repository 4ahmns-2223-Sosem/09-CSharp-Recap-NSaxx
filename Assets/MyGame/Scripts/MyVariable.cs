using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariable : MonoBehaviour
{
    public string myString;
    public bool myBool;
    public int myInt;
    public float myFloat;

    void Start()
    {
        myString = "Yippie";
        myBool = true;
        myInt = 1;
        myFloat = 1.34224f;

        Debug.Log("Done" + " " + "MyString" + " " + myString);
        Debug.Log("Done" + " " + "MyBool" + " " + myBool);
        Debug.Log("Done" + " " + "MyInt" + " " + myInt);
        Debug.Log("Done" + " " + "MyFloat" + " " + myFloat);
    }

}
