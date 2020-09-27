using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    
    public List<AudioClip> clips;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlaySpecificClip(int clip)
    {
        audioSource.PlayOneShot(clips[clip]);
    }

}
