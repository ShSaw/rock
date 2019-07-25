using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player1 : MonoBehaviour
{
    private Animator anim;
    private Player1Score player1score;
	private Player2 player2;
	public bool rock;
	public bool paper;
	public bool scissors;
	// Start is called before the first frame update
	void Start()
    {
        int Data = PlayerPrefs.GetInt("Score", 0);
        anim = GetComponent<Animator>();
        player1score = GameObject.Find("ScoreBoard1").GetComponent<Player1Score>();
		player2 = GameObject.Find("Player2").GetComponent<Player2>();
		rock = false;
		paper = false;
		scissors = false;
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown("1"))
        {
            anim.Play("rock left");
            if (player2.scissors == true)
            {
                player1score.player1score++;
            }
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("leftpaper");
            if (player2.rock == true)
            {
                player1score.player1score++;
            }
        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("leftscissors");
            if (player2.paper == true)
            {
                player1score.player1score++;
            }
        }
    }
}
