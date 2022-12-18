using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTravel : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(sceneToLoad);
    }
}
