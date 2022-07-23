using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bulletCounter : MonoBehaviour
{
    public TMP_Text text;
    public playerBehavior player;


    // Update is called once per frame
    void Update()
    {
        text.text = ""+player.RangedWeapons.bulletPack.bullets;
    }
}
