using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool paper_bool;
    bool rock_bool;
    bool scissors_bool;
    bool debounce;
    private Animator animation;
    private cpu_script_real cpu;
    private score your_score;
    bool win; 
    // Start is called before the first frame update
    void Start()
    {
        debounce = true;
        animation = GetComponent<Animator>();
        cpu = GameObject.Find("cpu").GetComponent<cpu_script_real>();
        your_score = GameObject.Find("ScoreBoard").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("2"))
        {
            animation.Play("leftpaper");
            if (cpu.num == 1)
            {
                win = true;
                Debug.Log("You win");
                if (debounce == true)
                {
                    your_score.thescore++;
                    debounce = false;
                }
               
            }
            else
            {
                win = false;
                Debug.Log("You lose");
                debounce = false;
            }
        }

        if (Input.GetKeyDown("1") && debounce == true)
        {
            animation.Play("rock left");
            if (cpu.num == 3)
            {
                win = true;
                Debug.Log("You win");
                if (debounce == true)
                {
                    your_score.thescore++;
                    debounce = false;
                }
            }
            else
            {
                win = false;
                Debug.Log("You lose");
                debounce = false;
            }
        }
        
        if (Input.GetKeyDown("3") && debounce == true)
        {
            animation.Play("leftscissors");
            if (cpu.num == 2)
            {
                win = true;
                Debug.Log("You win");
                if (debounce == true)
                {
                    your_score.thescore++;
                    debounce = false;
                }
            }
            else
            {
                win = false;
                Debug.Log("You lose");
                debounce = false;
            }
        }
        
    }
}
