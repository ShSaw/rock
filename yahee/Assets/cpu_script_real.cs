using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cpu_script_real : MonoBehaviour
{
    System.Random r;
    int num;
    private Animator anim;
    private Animator solutionAnim;
    // Start is called before the first frame update
    void Start()
    {
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
        }
        else
        {
            anim.SetBool("scissors", true);
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
        SceneManager.LoadScene("gameplay1", LoadSceneMode.Single);
    }
         
}
