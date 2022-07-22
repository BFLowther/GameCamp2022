using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    //Get the player
    public GameObject player;
    //Get the potion we are spawning as a prefab
    public GameObject potion;
    // Start is called before the first frame update
    public Animator anim;

    private bool colliding = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && colliding == true)
        {
            Debug.Log("E");
            //Play the animation
            anim.Play("Open");

            //Spawn the health potion using Istantiation.
            potion = Instantiate(potion, transform.position + new Vector3(0, 1, 0), transform.rotation);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        colliding = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        colliding = false;
    }
}
