using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeChange : MonoBehaviour
{

    public Slider masterVal;
    public Slider musicVal;
    public Slider sfxVal;
    public  AudioMixer masterMixer;


    // Update is called once per frame
    void Update()
    {
        SetSound((masterVal.value * 20), (musicVal.value * 20), (sfxVal.value * 20));
        
    }

    public void SetSound(float masterLevel, float musicLevel, float sfxLevel)
    {
        masterMixer.SetFloat("masterVol", masterLevel);
        masterMixer.SetFloat("musicVol", musicLevel);
        masterMixer.SetFloat("sfxVol", sfxLevel);
    }
}
