using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Text textbox;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        time = 4;
        textbox.text = ((int) time).ToString();
        StartCoroutine(SceneWait());
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        textbox.text =     ((int) time).ToString();
        if (time < 1)
        {
            textbox.text = "GO!";
        }
    }
    IEnumerator SceneWait()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("multiplayer", LoadSceneMode.Single);
    }
}
