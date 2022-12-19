using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslatma : MonoBehaviour
{

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("Level 1");
        }
        if(Input.GetKeyDown("e")){
            SceneManager.LoadScene("Forest Scene");
        }
        if(Input.GetKeyDown("m")){
            SceneManager.LoadScene("Start Scene");
        }
    }
}
