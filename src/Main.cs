using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

    public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void GameLauncher()
    {
        SceneManager.LoadScene(1);
    }

	public void QuitButton()
    {
        Application.Quit();
    }
}
