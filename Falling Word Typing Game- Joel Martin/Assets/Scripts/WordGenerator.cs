using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {
        "good", "bad", "ugly", "Delorean", "time", "machine", "dog", "cat", "mouse", "Michael", "Jonathan", "Joel", "Martin", "Brown", "red", "green", "blue", "yellow", "orange", "purple", "one", "two",
        "three", "four", "five", "six", "seven", "eight", "nine", "ten", "animal", "Giraffe", "eliphant", "tiger", "lion", "bear", "hippopotamus", "snake", "viper", "zombie", "fairy", "fiend", "dinosaur",
        "beast", "warrior", "bird", "beast-warrior", "spellcaster", "dragon", "fish", "sea serpent", "aqua", "poison", "psychic", "water", "fire", "earth", "light", "dark", "wind", "devine", "Somebody",
        "once", "told", "me", "the", "world", "is", "going", "to", "own", "me", "I", "ain't", "Sharpest", "tool", "in", "the", "shed", "she", "was", "looking", "kind of", "dumb", "with", "her", "finger", "and", 
        "her", "thumb", "shape", "of", "an", "L", "on", "forehead", "Well", "years", "start", "coming", "they", "don't", "stop", "fed", "rules", "hit", "ground", "running", "didn't", "make", "sense", "not", "live",
        "for", "fun", "your", "brain", "gets", "smart", "but", "head", "gets", "So", "much", "say", "see", "what's", "wrong", "taking", "back", "street", "you'll", "never", "know", "if", "go", "shine", "glow",
        "Hey", "now", "you're", "an", "all-star", "get", "your", "game", "on", "go", "play"};
    
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
