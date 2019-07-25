using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cpu_script_real : MonoBehaviour
{
    System.Random r;
    public int num;
    private Animator anim;
    private Animator solutionAnim;
    private int score;
    private score cpu_score;
    bool win;
    
    // Start is called before the first frame update
    void Start()
    {
        int Data = PlayerPrefs.GetInt("Score", 0);
        GameObject.Find("ScoreBoard").GetComponent<score>().thescore = Data;
        r = new System.Random();
        num = r.Next(1, 4);
        anim = GetComponent<Animator>();
        solutionAnim = GameObject.FindGameObjectWithTag("Solution").GetComponent<Animator>();
        StartCoroutine(Wait());
        StartCoroutine(SolutionWait());
        StartCoroutine(SceneloadWait());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        if (num == 1)
        {
            anim.SetBool("rock", true);
        }
        else if (num == 2)
        {
            anim.SetBool("paper", true);
            //playerScissors_bool = true;
        }
        else
        {
            anim.SetBool("scissors", true);
            //playerRock_bool = true;
        }

    }
    
    IEnumerator SolutionWait()
    {
        yield return new WaitForSeconds(1);

        if (num == 1)
        {
            solutionAnim.SetBool("isRock", true);
        }
        if (num == 2)
        {
            solutionAnim.SetBool("isPaper", true);
        }
            if (num == 3)
        {
            solutionAnim.SetBool("isScissors", true);
        }
    }
    IEnumerator SceneloadWait()
    {
        yield return new WaitForSeconds(6);
        int the_score = GameObject.Find("ScoreBoard").GetComponent<score>().thescore;
        int round = GameObject.Find("ScoreBoard").GetComponent<score>().round;
        PlayerPrefs.SetInt("Score", the_score);

        if (the_score >= 2 && round == 4)
        {
            PlayerPrefs.SetInt("Score", 0);
            SceneManager.LoadScene("gameplay2", LoadSceneMode.Single);
        }
        else if (the_score < 2 && round == 10)
        {
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
        }
        else if (the_score >= 4 && round == 10)
        {
            SceneManager.LoadScene("win", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("RELOADING SAME SCENE");
            int currentscene = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("Score", the_score);
            SceneManager.LoadScene(currentscene, LoadSceneMode.Single);
        }
        
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("Round");
        print("quit");
    }

}
