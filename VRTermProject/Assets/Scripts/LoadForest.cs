using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadForest : MonoBehaviour
{
    public void FQuitGame()
    {
        SceneManager.LoadScene("Forest Scene");
    }
}