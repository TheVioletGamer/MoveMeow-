using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour 
{
    //changes the screen
    public void LoadScene(int screenIndex)
    {
        SceneManager.LoadScene(screenIndex);
    }
}
