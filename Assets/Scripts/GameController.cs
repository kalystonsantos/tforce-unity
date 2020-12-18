using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int Score;

    public int coinScore;

    public Text scoreText;

    public Text coinText;

    public float ScorePerSecond;

    public static GameController current;

    public bool PlayerIsAlive;
    // Start is called before the first frame update
    void Start()
    {
        current = this;
        PlayerIsAlive = true;

    }

    float ScoreUpdated;
    // Update is called once per frame
    void Update()
    {
        if(PlayerIsAlive)
        {
            ScoreUpdated += ScorePerSecond * Time.deltaTime;
            Score = (int)ScoreUpdated;

            //att o elemento de texto da interface.
            scoreText.text = Score.ToString("0000");
        }

    }

    public void AddScore(int value)
    {
        coinScore += value;
        coinText.text = coinScore.ToString("0000");
    }

}
