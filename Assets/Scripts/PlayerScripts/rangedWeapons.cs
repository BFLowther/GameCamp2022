using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedWeapons : MonoBehaviour
{
    public GameObject bulletGO;
    public float lifeTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
         Fire();
    }
    private void Fire()
    {
       Instantiate(bulletGO, transform); 
    }
}
