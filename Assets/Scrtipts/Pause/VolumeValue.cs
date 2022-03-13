using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeValue : MonoBehaviour
{
   public AudioSource AudioSrc;
   private float musicVolume;

    void Awake()
    {
    musicVolume = PlayerPrefs.GetFloat("LoadVolume");
    }

    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        AudioSrc.volume = musicVolume; 
        PlayerPrefs.SetFloat("LoadVolume", musicVolume);
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        vol = PlayerPrefs.GetFloat("LoadVolume");
    }
}
