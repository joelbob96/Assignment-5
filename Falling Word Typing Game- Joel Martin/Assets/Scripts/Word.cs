using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {


    public string word;
    private int typeIndex;

    private WordDisplay display;

    public Transform position;

    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public Transform getPosition()
    {
        if (display != null)
        {
            position = display.getPosition();
            return position;
        }
        else
        {
            return null;
        }
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            display.RemoveWord();
        }
        return wordTyped;
    }

    public void DestroyWord()
    {
        display.RemoveWord();
    }
}
