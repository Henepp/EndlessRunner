using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource Audiosource;

    public AudioClip Whoosh;
    public AudioClip CheckPoint;

    public bool Isplaying;
    public bool Isplaying1;
    public bool HitAgain = true;

    private void Awake()
    {
        //singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void StartWhoosh()
    {
        StartCoroutine(PlayWhooshSoundEffect());
    }


    IEnumerator PlayWhooshSoundEffect()
    {
        if (Isplaying) yield return 0;


        Isplaying = true;

        //plays the sound effect
        Audiosource.PlayOneShot(Whoosh);

        //waits 2 seconds
        yield return new WaitForSeconds(2);

        //sets bool to false so you can play the sound effect again
        Isplaying = false;
    }
}