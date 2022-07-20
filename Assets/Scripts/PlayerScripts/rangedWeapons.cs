using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedWeapons : MonoBehaviour
{   
    public GameObject flashGO;
    public GameObject firePoint;
    public GameObject bulletGO;
    public BulletPickup bulletPack;
    public float hideFlashPercent = 0.9f;
    public float lifeTime = 3.0f;
    public float cooldownTime = 2.0f;
    private float direction = 1.0f;
    private float currentCountdown = 0.0f;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        currentCountdown -= Time.deltaTime;
        if(currentCountdown < hideFlashPercent * cooldownTime){
            flashGO.SetActive(false);
        }
        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            direction = 1.0f;
             transform.eulerAngles = new Vector3(0, 0, 0);
        }
         if (Input.GetAxis("Horizontal") < 0.0f)
        {
            direction = -1.0f;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
         if (Input.GetAxis("Fire1") > 0.0f && bulletPack.bullets > 0 && currentCountdown <= 0.0f)
            Fire();
    }
    private void Fire()
    {
        flashGO.SetActive(true);
        currentCountdown = cooldownTime;
       bulletPack.bullets -= 1;
       GameObject bullet = Instantiate(bulletGO, firePoint.transform.position, firePoint.transform.rotation); 
       bullet.GetComponent<Bullet>().direction = direction;
    }
}
