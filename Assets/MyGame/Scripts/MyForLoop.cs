using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyForLoop : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        for (int x = 0; x < 5; x++)
        {
            Debug.Log("Done" + " " + x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
