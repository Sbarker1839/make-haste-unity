using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class load : MonoBehaviour {

    public void loadgame()
    {
        SceneManager.LoadScene("Game");
    }

    public void loadmain()
    {
        SceneManager.LoadScene("Main_menu");
    }

    public void loadins()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void quit()
    {

        Application.Quit();

    }
    
}
