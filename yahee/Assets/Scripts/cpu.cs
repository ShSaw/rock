using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cpu : MonoBehaviour
{
    System.Random r;
    int num;
    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        r = new System.Random();
        num = r.Next(1,4);
        animation = GetComponent<Animator>();
        StartCoroutine(Wait());
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
        animation.SetBool("rock", true);
        animation.Play("rock");
        }
        else if (num == 2)
        {
        animation.SetBool("paper", true);
        }
        else 
        {
        animation.SetBool("scissors", true);
        }
    }
}
