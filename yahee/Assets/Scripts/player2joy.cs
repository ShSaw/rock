using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2joy : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("8"))
        {
            anim.Play("player2left");
        }
        if (Input.GetKeyDown("9"))
        {
            anim.Play("player2right");
        }
    }
}
