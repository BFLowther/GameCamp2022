using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public List<Transform> path;
    public float fudge = 0.1f;
    public float speed = 1;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fudge > Vector3.Distance(path[index].position, transform.position))
        {
            index++;

            if (index >= path.Count)
            {
                index = 0;
            }
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
            path[index].position,
            speed * Time.deltaTime
        );
    }

    public void KillBoss()
    {

    }
}
