using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowTo : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Intruct ()
    {
        SceneManager.LoadScene("intructions", LoadSceneMode.Single);
    }

}
