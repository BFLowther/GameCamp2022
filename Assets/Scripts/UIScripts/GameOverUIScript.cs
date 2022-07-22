using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUIScript : MonoBehaviour
{
    

    public void restart()
    {
        SceneManager.LoadScene("Level1");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Why?");
    }
}
