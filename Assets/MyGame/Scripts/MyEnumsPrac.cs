using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Done,
    WIP,
    Cancle
}

public class MyEnumsPrac : MonoBehaviour
{
    State myState;

    void Start()
    {
        myState = State.Done;

        switch (myState)
        {
            case State.Done:
                Debug.Log(State.Done + " " + (int)State.Done);
                break;
            case State.WIP:
                Debug.Log((int)State.WIP);
                break;
            case State.Cancle:
                Debug.Log((int)State.Cancle);
                break;
        }
        if(myState == State.Done)
        {
            Debug.Log(State.Done + " " + (int)State.Done);
        }
        else if (myState == State.WIP)
        {
            Debug.Log(State.WIP + " " + (int)State.WIP);
        }
        else if (myState == State.Cancle)
        {
            Debug.Log(State.Cancle + " " + (int)State.Cancle);
        }

    }

}
