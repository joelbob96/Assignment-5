using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    public static int score;
    public List<Word> words;

    public WordSpawner wordSpawner;

    public bool hasActiveWord;
    public Word activeWord;

    //public Text scoreDisplay;

    private void Start()
    {
        //score = 0;
    }

    public void Update()
    {
        if (hasActiveWord)
        {
            if (activeWord.getPosition().position.y < -5)
            {
                activeWord.DestroyWord();
                hasActiveWord = false;
                words.Remove(activeWord);
            }
        }

        foreach(Word word in words)
        {
            if(word.getPosition().position.y < -5)
            {
                word.DestroyWord();
                words.Remove(word);
            }
        }
    }

    public void AddWord()
    {
        //WordDisplay wordDisplay = wordSpawner.SpawnWord();

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        //Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }

        }
        else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            score++;
}
    }
}
