using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Word") {
            /*if (other.gameObject == WordManager.activeWord)
            {
                WordManager.hasActiveWord = false;
            }*/
                Destroy(other.gameObject);
        }
    }
}
