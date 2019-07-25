using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpujoy : MonoBehaviour
{
    private cpu_script_real cpu;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        cpu = GameObject.Find("cpu").GetComponent<cpu_script_real>();
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
   
    
}
