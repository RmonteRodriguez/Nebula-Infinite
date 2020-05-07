using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void sceneRestart()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void menuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
