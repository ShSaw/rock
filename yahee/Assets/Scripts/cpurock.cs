using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cpurock : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
        animation_bool = true;
        }
        if (scissors_bool == true)
        {
        animation.Play("leftscissors");
        }
        
    }
}