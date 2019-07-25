using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player1Score : MonoBehaviour
{
    public int player1score;
    public Text ScoreBoard1;
    public int round;
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard1.text = player1score.ToString();

        PlayerPrefs.SetInt("Score", player1score);

        player1score = PlayerPrefs.GetInt("Score");

        if(PlayerPrefs.HasKey("Round") == false)
        {
            PlayerPrefs.SetInt("Round", 0);
        }
        else
        {
            round = PlayerPrefs.GetInt("Round");
            round++;
            PlayerPrefs.SetInt("Rounds", round);

        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBoard1.text = player1score.ToString();
    }
}
