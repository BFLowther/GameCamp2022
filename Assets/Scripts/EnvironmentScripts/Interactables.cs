using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Door works");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Trigger active");

            if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.JoystickButton3))
            {
                if (gameObject.tag == "DestructableDoor")
                {
                    Debug.Log("Door still works");
                    gameObject.SetActive(false);
                }

                if (gameObject.tag == "OpenableDoor")
                {
                    anim.Play("DoorOpen");

                }

            }
        }        
    }
}
