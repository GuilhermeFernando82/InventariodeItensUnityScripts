using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController corrent;
    public AudioClip sfx;
    public AudioClip annother;
    public AudioClip BGM;
    public AudioClip Shot;

    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        corrent = this;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayMusic(AudioClip clip)
    {
        audiosource.PlayOneShot(clip);
    }
}
