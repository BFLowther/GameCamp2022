using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    Scene scene;
    public void sceneChange()
    {
        //Change to next scene
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
    public void backToStartChange()
    {
        //Change to next scene
        SceneManager.LoadScene("StartScene");
    }
}
