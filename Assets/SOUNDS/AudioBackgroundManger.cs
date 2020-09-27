using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBackgroundManger : MonoBehaviour
{
    public List<AudioClip> tracks;
    public AudioSource audioSource;
    private int count;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            Play(tracks[count]);
            count++;

        }
        if (count >= 6)
            count = 0;
    }

    void Play(AudioClip clip)
    {
            audioSource.PlayOneShot(clip);
    }
}
