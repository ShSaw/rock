using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftscissors : MonoBehaviour
{
    bool scissors_bool; 
    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
        scissors_bool = true;
        }
        if (scissors_bool == true)
        {
        animation.Play("leftscissors");
        }
        
    }
}