using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSkele : MonoBehaviour
{
    private Animator anim;
    public Transform pos1, pos2;
    public Transform startPos;
    public float speedOfEnemy = 1;
    Vector3 nextPos;
    private Vector3 lastPosition;
    public SpriteRenderer spriteRenderer;



    // Start is called before the first frame update
    void Start()
    {

        //Rigidbody m_Rigidbody;
        lastPosition = transform.position;
        nextPos = startPos.position;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speedOfEnemy * Time.deltaTime); //Movement!
        anim.SetFloat("Speed", speedOfEnemy);
        spriteRenderer.flipX = ((transform.position - lastPosition).x > 0.0f);

        lastPosition = transform.position;
    }
}
