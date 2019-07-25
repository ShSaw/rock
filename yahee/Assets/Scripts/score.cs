using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public int thescore;
    public Text ScoreBoard;
    public int round; 

    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard.text = thescore.ToString();

        PlayerPrefs.SetInt("Score", thescore);

        thescore = PlayerPrefs.GetInt("Score");

        if (PlayerPrefs.HasKey("Round") == false)
        {
            PlayerPrefs.SetInt("Round", 0);
            Debug.Log("ROUND DIDN'T Exist");
        }
        else
        {
            round = PlayerPrefs.GetInt("Round");
            Debug.Log("Round Existed");
            round++;
            PlayerPrefs.SetInt("Round", round);
        }
        
        Debug.Log(round);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBoard.text = thescore.ToString();
    }
}
