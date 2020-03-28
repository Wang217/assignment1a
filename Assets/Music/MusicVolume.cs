using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    
    public Slider Volume; // Slider in settings
    public AudioSource music;

    private void Update()
    {
        music.volume = Volume.value;
    }



}
