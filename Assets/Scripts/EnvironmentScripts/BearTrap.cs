using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BearTrap : MonoBehaviour
{
    
    public GameObject Player;
    [HideInInspector]
    public playerBehavior pb;
    [HideInInspector]
    public Rigidbody2D rigi;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        pb = Player.GetComponent<playerBehavior>();
        rigi = Player.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    IEnumerator Trapped()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        rigi.constraints = RigidbodyConstraints2D.None;
        rigi.constraints = RigidbodyConstraints2D.FreezeRotation;
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        
        //Open trap
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Close trap
            pb.health -= 1;
            anim.Play("BearTrap");
            rigi.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            StartCoroutine(Trapped());
        }
        
        if (pb.health == 0)
            SceneManager.LoadScene("Ross2");
    }
}
