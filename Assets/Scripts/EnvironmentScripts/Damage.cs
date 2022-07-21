using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject Player;
    public playerBehavior pb;


    // Start is called before the first frame update
    void Start()
    {
       pb = Player.GetComponent<playerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            pb.currentHealth -= 1;
        if (pb.currentHealth == 0)
            SceneManager.LoadScene("Ross2");
    }

}
