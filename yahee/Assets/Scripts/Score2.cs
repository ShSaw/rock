using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public int theyscore;
    public Text ScoreBoard2;
    public int rounds;

    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard2.text = theyscore.ToString();

        PlayerPrefs.SetInt("Scores", theyscore);

        theyscore = PlayerPrefs.GetInt("Scores");

        if (PlayerPrefs.HasKey("Rounds") == false)
        {
            PlayerPrefs.SetInt("Rounds", 0);
        }
        else
        {
            rounds = PlayerPrefs.GetInt("Rounds");
            rounds++;
            PlayerPrefs.SetInt("Rounds", rounds);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBoard2.text = theyscore.ToString();
    }
}
