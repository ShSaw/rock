﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftpaper : MonoBehaviour
{
    bool animation_bool; 
    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
        animation_bool = true;
        }
        if (animation_bool == true)
        {
        animation.Play("leftpaper");
        }
    }
}