using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player2 : MonoBehaviour
{
    //righthand
    bool win;
    private Animator anim;
    private Score2 theyre_score;
	private Player1 player1;
	public bool rock;
	public bool paper;
	public bool scissors;
    // Start is called before the first frame update
    void Start()
    {
        int Data = PlayerPrefs.GetInt("Scores", 0);
        GameObject.Find("ScoreBoard2").GetComponent<Score2>().theyscore = Data;
        theyre_score = GameObject.Find("ScoreBoard2").GetComponent<Score2>();
		player1 = GameObject.Find("Player1").GetComponent<Player1>();
		anim = GetComponent<Animator>();
		rock = false;
		paper = false;
		scissors = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("8"))
        {
            anim.Play("cpu2rock");
			rock = true;

            if (player1.scissors == true)
            {
                win = true;
                theyre_score.theyscore = +1;
            }
            else
            {
                win = false;
            }
        }
        if (Input.GetKeyDown("9"))
        {
            anim.Play("cpu2paper");
			paper = true;
            if (player1.rock == true)
            {
                win = true;
                theyre_score.theyscore++;
            }
            else
            {
                win = false;
            }
        }
        if (Input.GetKeyDown("0"))
        {
            anim.Play("cpu2scissors");
			scissors = true;
            if (player1.paper == true)
            {
                win = true;
                theyre_score.theyscore++;
            }
            else
            {
                win = false;
            }
        }

      

            
        
    }
}
