using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public Animator anim;
    public Animator transitionAnim;
    public GameObject optionsMenu;
    public GameObject creditsMenu;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
   public void playButton()
    {
        //Play Animation
        //anim.SetTrigger("Play");
        transitionAnim.SetTrigger("endScene");

        //Start the coroutine we define below named ExampleCoroutine.
        //StartCoroutine(ExampleCoroutine());

    }
    public void quitButton()
    {
        //Quit The Game
        Application.Quit();
        Debug.Log("It Quit!");
    }

    public void optionsBack()
    {    
        optionsMenu.SetActive(false);
    }

    public void creditsBack()
    {
        creditsMenu.SetActive(false);

    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2.0f);


        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
