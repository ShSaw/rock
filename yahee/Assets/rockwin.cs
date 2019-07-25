using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockwin : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Roc());
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Roc()
    {
        yield return new WaitForSeconds(2);
   
            anim.Play("ROCKWINS");
    }
        }
   
