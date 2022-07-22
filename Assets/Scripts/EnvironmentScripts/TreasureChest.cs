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
    public int numOfPotions = 1;
    public float distance = 1.0f;

    private bool colliding = false;

    void Start()
    {
        if (player == null)
            Debug.LogError("Player not connected to chest");
    }

    private void Update()
    {
        float dis = Vector3.Distance(transform.position, player.transform.position);
        if ((Input.GetAxis("Fire3") > 0.0f) && dis < distance && numOfPotions > 0)
        {
            Debug.Log("Open");
            //Play the animation
            anim.Play("Open");
            numOfPotions--; 

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