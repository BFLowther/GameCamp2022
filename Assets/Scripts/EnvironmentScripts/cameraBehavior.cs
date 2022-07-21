using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{

    

    public IEnumerator Shake ()
    {
        Vector3 originalPos = transform.localPosition; 
        for (int i = 0; i > 5000; i++)
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, 1f);
            transform.localPosition = new Vector3(x, y, originalPos.z);
            yield return null;
        }
        transform.localPosition = originalPos;
    }
    

}

