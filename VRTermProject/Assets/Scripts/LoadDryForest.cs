using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDryForest : MonoBehaviour
{
    public void FQuitGame()
    {
        SceneManager.LoadScene("DryForestEnvironment");
    }
}
