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
    

    void OnTriggerEnter(Collider other) //Check for the player.
    {

        if(Input.GetKeyDown(KeyCode.E))
        { Debug.Log("E");
        //Play the animation
        anim.Play("Open");
        
        //Spawn the health potion using Istantiation.
        potion = Instantiate(potion, transform.position, transform.rotation);
       
        }
    }
}
