using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public Animator anim;
    private int pauseTimeScale = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            anim.SetTrigger("Play");

            if(pauseTimeScale == 0)
            {
                pauseTimeScale = 1;
                Time.timeScale = 1.0f;
            }
            else
            {
                pauseTimeScale = 0;
                Time.timeScale = 0f;
            }
            Debug.Log("We Just Paused :D");
        }
    }

    public void QuitGame()
    {
        //Quit The Game
        Application.Quit();
        Debug.Log("It Quit!");
    }
 }