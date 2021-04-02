using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    void Start()
    {
        WordTimer.wordDelay = 1.5f;
        WordManager.score = 0;
        SendText.theName = " ";
    }

    public void setSpeed(float newSpeed)
    {
        WordTimer.wordDelay = newSpeed;
        Debug.Log(WordTimer.wordDelay.ToString());
    }
}
