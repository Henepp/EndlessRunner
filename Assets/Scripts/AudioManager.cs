using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource Audiosource;

    public AudioClip Whoosh;
    public bool Isplaying;
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

    public void PlayWhooshSoundEffect()
    {
        //stops it from playing multiple times
        if (Isplaying) return;

        /*if (HitAgain)
        {
            Audiosource.Stop();
            Audiosource.PlayOneShot(Whoosh);
        }*/

        Isplaying = true;
        Audiosource.PlayOneShot(Whoosh);
    }
}