using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraReference : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void LateUpdate() //happens after update to not compete with movement
    {
        transform.position = target.position + offset;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
