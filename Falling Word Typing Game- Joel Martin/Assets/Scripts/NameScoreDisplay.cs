using UnityEngine;
using UnityEngine.UI;

public class NameScoreDisplay : MonoBehaviour
{
    public Text PlayerName;
    public Text Score;
    public void Start()
    {
        PlayerName.text = "Player: " + SendText.theName;
    }
    public void Update()
    {
        Score.text = "Score:" + WordManager.score.ToString();
    }
}
