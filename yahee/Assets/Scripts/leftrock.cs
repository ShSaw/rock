using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftrock : MonoBehaviour

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
        if (Input.GetKeyDown("1"))
        {
        animation_bool = true;
        }
        if (animation_bool == true)
        {
        animation.Play("rock left");
        }
    }
}
