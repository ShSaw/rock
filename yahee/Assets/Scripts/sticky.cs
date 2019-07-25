using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class sticky : MonoBehaviour
{
    Animator anim;
    Transform tform;

    void Start()
    {
        anim = GetComponent<Animator>();
        tform = GetComponent<Transform>();
    }
    // Start is called before the first frame update

    void Update ()
    {
       if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 moveRight = new Vector3(20, 0, 0);
            tform.position += moveRight;
            anim.Play("stickyright");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 moveLeft = new Vector3(-20, 0, 0);
            tform.position += moveLeft;
            anim.Play("stickyleft");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 moveUp = new Vector3(0, 20, 0);
            tform.position += moveUp;
            anim.Play("stickyup");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 moveDown = new Vector3(0, -20, 0);
            tform.position += moveDown;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("First"))
        {
            SceneManager.LoadScene("gameplay1", LoadSceneMode.Single);
        }
    }
}
