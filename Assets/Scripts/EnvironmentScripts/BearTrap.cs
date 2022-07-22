using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BearTrap : MonoBehaviour
{
    //[HideInInspector]
    private playerBehavior pb;
    [HideInInspector]
    private Rigidbody2D rigi;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("aaaaaa you got bear trapped lmao");
            //Close trap
            pb = other.gameObject.GetComponent<playerBehavior>();
            healthBar hb = pb.HealthBar;
            rigi = other.gameObject.GetComponent<Rigidbody2D>();
            hb.SetHealth(hb.currentHealth - 1);
            Debug.Log("-1 Health");
            anim.Play("BearTrap");
            rigi.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            StartCoroutine(Trapped());
            if (hb.currentHealth == 0)
                SceneManager.LoadScene("Ross2");

        }
    }
    private IEnumerator Trapped()
    {
        while (true)
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
            break;
        }
    }
}
