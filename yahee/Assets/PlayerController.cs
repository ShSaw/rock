using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool paper_bool;
    bool rock_bool;
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
        if (Input.GetKeyDown("2"))
        {
            paper_bool = true;
        }
        if (paper_bool == true)
        {
            animation.Play("leftpaper");
        }
        if (Input.GetKeyDown("1"))
        {
            rock_bool = true;
        }
        if (rock_bool == true)
        {
            animation.Play("rock left");
        }
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
